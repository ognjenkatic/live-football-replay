/* eslint-disable react/prop-types */

const LiveScore = ({ matchData }) => {
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

export default LiveScore;