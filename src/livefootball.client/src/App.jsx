/* eslint-disable react/prop-types */
import { useEffect, useState } from 'react';
import './App.css';
import { HubConnectionBuilder } from "@microsoft/signalr";

const LiveScore = ({matchData}) => {
    return <div>
        {matchData.events.map(((event, index) => {
            return (<div key={index} className="event">
                <span className="team-name">{event.player?.name}</span>
                <span className="event-type">{event.type?.name}</span>
                <span className="event-time">{`${event.minute}:${event.second}`}</span>
            </div>)
        }))}
    </div>
}

const Result = ({ data }) => {
    if (!data) return;
    let keys = Object.keys(data);

    if (keys.length < 2) return;


    let home = keys[0];
    let away = keys[1];
    return <div>

        <div>
            <div>
                <span>{home} vs {away}</span>
            </div>

            <div>
                <span>{data[home]?.goals ?? 0}</span>-
                <span>{data[away]?.goals ?? 0}</span>
            </div>
        </div>

        
    </div>
}

function App() {
    

    useEffect(() => {
        populateWeatherData();
        
    }, []);


    const [matchData, setMatchData] = useState({
        events: [] // Initialize matchData as an object with an 'events' array
    });

    const [score, setScore] = useState({});
    
    // Adjusted check to matchData.events.length to handle the initial empty state
    //const contents = matchData.events.length === 0
    //    ? <p><em>Loading... Please refresh once the ASP.NET backend has started. See <a href="https://aka.ms/jspsintegrationreact">https://aka.ms/jspsintegrationreact</a> for more details.</em></p>
    //    : <div className="events-container">
    //        {matchData.events.map((event, index) => {
    //            return (<div key={index} className="event">
    //                <span className="team-name">{event.player?.name}</span>
    //                <span className="event-type">{event.type?.name}</span>
    //                <span className="event-time">{`${event.minute}:${event.second}`}</span>
    //            </div>)
    //        })}
    //    </div>;

    return (
        <div>
            <h1 id="tabelLabel">Match Events</h1>
            <p>This component demonstrates fetching and streaming data from the server.</p>
            
            <div className="main">
                <div>Left</div>
                <div className="main-middle">
                <Result data={score} />
                    <LiveScore matchData={matchData} />
                </div>
                <div>

                </div>

            </div>
        </div>
    );

    async function populateWeatherData() {
        const matchResponse = await fetch(`api/match/3890561/lineup`, {
            headers: {
                "Content-Type": "application/json",
            }
        })

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
