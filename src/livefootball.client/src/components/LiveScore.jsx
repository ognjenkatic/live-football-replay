/* eslint-disable react/prop-types */
import React from 'react';
import './LiveScore.css'; // Assuming styles are defined here


function getEventDescription(event) {
    switch (event?.type?.name) {
        case "Shot":
            return `with ${event.shot.technique?.name}`;
        case "Pass":
            return `to ${event.pass.recipient?.name}`;
        default:
            return "";
    }
}

function getEventOutcome(event) {
    let outcome = "";
    switch (event?.type?.name) {
        case "Pass":
            outcome = event.pass?.outcome?.name ?? "";
            break;
        case "Shot":
            outcome = event.shot?.outcome.name;
            break;
        default:
            outcome = "";
            break;
    }

    if (outcome != "")
        return outcome + " ";

    return outcome;
}
const LiveScore = ({ matchData }) => {
    return (
        <div>
            {matchData.events.map((event, index) => (
                <div key={index} className={`event ${event.isHomeTeam ? 'home' : 'away'}`}>
                    {(
                        <>
                            <div className={`player-and-type ${event.isHomeTeam ? 'home-team-display' : 'away-team-display'}`}>
                                <span className="team-name">{event.player?.name}</span>
                                <span className="event-type"><span className="event-outcome">{getEventOutcome(event)}</span><span className="event-typename">{event.type?.name} </span><span>{getEventDescription(event)}</span></span>
                            </div>
                            <span className="event-time">{`${event.minute}'`}</span>
                        </>
                    )}
                </div>
            ))}
        </div>
    );
};

export default LiveScore;
