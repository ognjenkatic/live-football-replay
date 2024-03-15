/* eslint-disable react/prop-types */
import { useEffect, useState } from 'react';
import './App.css';
import { HubConnectionBuilder } from "@microsoft/signalr";
import Result  from './components/Result.jsx';
import LiveScore from './components/LiveScore.jsx';
import Lineup from './components/Lineup.jsx';




function App() {
   
    useEffect(() => {
        populateWeatherData();
        
    }, []);


    const [matchData, setMatchData] = useState({
        events: [] 
    });

    const [score, setScore] = useState({});
    

    return (
        <div>
            <h1 id="tabelLabel">Match Events</h1>
            <p>This component demonstrates fetching and streaming data from the server.</p>
            
            <div className="main">
                <div>
                    <Lineup/>
                </div>
                <div className="main-middle">
                    <Result data={score} />
                    <LiveScore matchData={matchData} />
                </div>
                <div>
                    <Lineup/>
                </div>

            </div>
        </div>
    );

    async function populateWeatherData() {
        const matchId = 3890561;
        const matchResponse = await fetch(`api/match/${matchId}/lineup`, {
            headers: {
                "Content-Type": "application/json",
            }
        })

        const matchOverviwew = await fetch(`api/match/${matchId}`)

        const matchData = await matchResponse.json();

        console.log(matchData);

        setMatchData(prevMatchData => ({
            ...prevMatchData, // Spread existing matchData
            events: [...(prevMatchData.events ?? []).slice(-14), []] // Properly update events array within matchData
        }));

        var connection = new HubConnectionBuilder().withUrl("https://localhost:7027/MatchHub").build();
        console.log("Subscribing");
        connection.start().then(function () {
            connection.stream("StreamMatchEvents", 3890561, 10)
                .subscribe({
                    next: (item) => {
                        switch (item?.type?.name) {
                            case "Starting XI": {
                                let teamName = item.team.name;
                                setScore(prev => {
                                    if (!prev[teamName]) {
                                        prev[teamName] = { goals: 0, scorers: [] };
                                    }
                                    return prev;
                                });

                                break;
                            }
                            case "Shot":
                                if (item.shot.outcome.name == "Goal") {
                                    console.log("GOAL EVENT");
                                    let teamName = item.team.name;
                                    let player = item.player.name;
                                    setScore(prev => {
                                        if (!prev[teamName]) {
                                            prev[teamName] = { goals: 0, scorers: [] };
                                        }
                                        prev[teamName].goals++;
                                        prev[teamName].scorers.push(player);

                                        console.log("GOOOOOOAL", prev[teamName], item.shot.outcome, item.id);
                                        return prev;
                                    });
                                    return;
                                }

                                setMatchData(prevMatchData => ({
                                    ...prevMatchData, // Spread existing matchData
                                    events: [item, ...prevMatchData.events.slice(0, 14)] // Prepend the new item and keep last 15
                                }));
                                break;
                                
                            default:
                                setMatchData(prevMatchData => ({
                                    ...prevMatchData, // Spread existing matchData
                                    events: [item, ...prevMatchData.events.slice(0, 14)] // Prepend the new item and keep last 15
                                }));
                                break;
                        }
                        
                        //console.log(item);
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
