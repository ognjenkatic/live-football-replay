/* eslint-disable react/prop-types */
import { useEffect, useState } from 'react';
import './App.css';
import { HubConnectionBuilder } from "@microsoft/signalr";
import Result  from './components/Result.jsx';
import LiveScore from './components/LiveScore.jsx';
import Lineup from './components/Lineup.jsx';
import Overview from './components/Overview.jsx';

function App() {

    useEffect(() => {
        populateWeatherData();

    }, []);


    const [matchData, setMatchData] = useState({
        events: []
    });
    const [score, setScore] = useState({});
    const [overview, SetOverview] = useState({});
    const [lineup, SetLineup] = useState([{}, {}]);
    

    return (
        <div>
            <Overview data={overview} />
            
            <div className="main">
                <div>
                    <Lineup data={lineup[0]} />
                </div>
                <div className="main-middle">
                    <Result data={score} />
                    <LiveScore matchData={matchData} />
                </div>
                <div>
                    <Lineup data={lineup[1]} />
                </div>

            </div>6
        </div>
    );


    function performSubstitution(team, sub) {

        let lineup = team.currentLineup;

        let subName = sub.player.name;

        let subbedPlayer = lineup.find(e => e.player.name == subName);

        if (subbedPlayer !== undefined) {
            subbedPlayer.isSubbed = true;
        }

        lineup.push({
            player: sub.substitution.replacement,
            isSub: true
        });

        return team;
    }

    function performCarding(team, player, card) {

        let lineup = team.currentLineup;
        let cardedPlayerName = player.name;

        let cardedPlayer = lineup.find(e => e.player.name == cardedPlayerName);

        if (cardedPlayer !== undefined) {
           
            if (card.name == "Yellow Card") {
                if (cardedPlayer.hasYellow === true) {
                    cardedPlayer.hasYellow = false;
                    cardedPlayer.hasTwoYellows = true;
                } else {
                    cardedPlayer.hasYellow = true;
                }
            } else if (card.name == "Red") {
                cardedPlayer.hasRed = true;
            }
        }

        return team;
    }

    async function populateWeatherData() {
        const matchId = 3890561;

        const matchLineupResponse = await fetch(`api/match/${matchId}/lineup`)
        const matchOverviewResponse = await fetch(`api/match/${matchId}`)

        const matchLineup = await matchLineupResponse.json();
        const matchOverview = await matchOverviewResponse.json();

        const homeTeamName = matchOverview.home_team.home_team_name;
        const awayTeamName = matchOverview.away_team.away_team_name;

        const homeTeamInfoResponse = await fetch(`api/teams?name=${homeTeamName}`);
        const awayTeamInfoResponse = await fetch(`api/teams?name=${awayTeamName}`);


        const homeTeamInfo = await homeTeamInfoResponse.json();
        const awayTeamInfo = await awayTeamInfoResponse.json();

        matchOverview.homeTeaminfo = homeTeamInfo;
        matchOverview.awayTeamInfo = awayTeamInfo;


        const homeLineup = matchLineup.find(l => l.team_name == homeTeamName).lineup;
        const awayLineup = matchLineup.find(l => l.team_name == awayTeamName).lineup;

        console.log(matchData);

        SetOverview(matchOverview);

        const lineupData = [
            {
                isHomeTeam: true,
                teamName: homeTeamName,
                currentLineup: null,
                completeLineup: homeLineup
            },
            {
                isHomeTeam: false,
                teamName: awayTeamName,
                currentLineup: null,
                completeLineup: awayLineup,
            }
        ];
        SetLineup(lineupData);

        setMatchData(prevMatchData => ({
            ...prevMatchData,
            events: [...(prevMatchData.events ?? []).slice(-14), []] 
        }));

        var connection = new HubConnectionBuilder().withUrl("https://localhost:7027/MatchHub").build();
        console.log("Subscribing");
        connection.start().then(function () {
            connection.stream("StreamMatchEvents", 3890561, 250, ["Substitution", "Starting XI", "Shot", "Foul Committed"])
                .subscribe({
                    next: (item) => {
                        switch (item?.type?.name) {
                            case "Foul Committed": {
                                if (item.foul_committed == null)
                                    break;
                                if (item.foul_committed.advantage)
                                    break;
                                if (item.foul_committed.card != null) {
                                    SetLineup(lineup => {
                                        performCarding(lineup.find(t => t.teamName == item.team.name), item.player, item.foul_committed.card);
                                        return lineup
                                    });
                                }
                                break;
                            }
                            case "Substitution": {
                                let teamName = item.team.name;
                                SetLineup(lineup => {
                                    performSubstitution(lineup.find(t => t.teamName == teamName), item);
                                    return lineup;
                                });
                                break;
                            }
                            case "Starting XI": {
                                SetLineup(lineup => {
                                    lineup.find(t => t.teamName == item.team.name).currentLineup = item.tactics.lineup
                                    return lineup;
                                    }
                                );
                                
                                setScore(prev => {
                                    if (!prev[item.team.name]) {
                                        prev[item.team.name] = { goals: 0, scorers: [] };
                                    }
                                    return prev;
                                });

                                break;
                            }
                            case "Shot":
                                if (item.shot.outcome.name == "Goal") {
                                    let teamName = item.team.name;
                                    let player = item.player.name;
                                    setScore(prev => {
                                        if (!prev[teamName]) {
                                            prev[teamName] = { goals: 0, scorers: [] };
                                        }
                                        prev[teamName].goals++;
                                        prev[teamName].scorers.push(player);
                                        
                                        return prev;
                                    });
                                    return;
                                }

                                setMatchData(prevMatchData => ({
                                    ...prevMatchData, 
                                    events: [item, ...prevMatchData.events.slice(0, 14)]
                                }));
                                break;
                                
                            default:
                                setMatchData(prevMatchData => ({
                                    ...prevMatchData,
                                    events: [item, ...prevMatchData.events.slice(0, 14)]
                                }));
                                break;
                        }
                        
                    },
                    complete: () => {
                        console.log("done streaming");
                    },
                    error: (err) => {
                        console.log(err);
                    },
                });
        }).catch(function (err) {
            return console.error(err.toString());
        });
    }
}

export default App;
