/* eslint-disable react/prop-types */
import React from 'react';
import './Plate.css'; // Assuming styles are defined here

const Plate = ({ data }) => {
    console.log(data);
    let playerClass = data.currentData.isSub === true ? " player-sub" : "";
    playerClass += data.currentData.hasYellow === true ? " player-with-yellow" : "";

    const isHomeTeam = data.isHomeTeam; // Assuming this property exists at the correct level in your data object
    
    return (
        <div className={`player-plate${playerClass}`} style={{ display: 'flex', alignItems: 'center', flexDirection: isHomeTeam ? 'row' : 'row-reverse' }}>
            <img width="50" height="50" src={data.playerInfo} alt="Player Avatar" style={{ margin: isHomeTeam ? '0 10px 0 0' : '0 0 0 10px' }} />
            <div className={`${isHomeTeam ? "home-team-display" : "away-team-display"}`} style={{ width: '100%', textAlign: isHomeTeam ? 'left' : 'right' }}>
                <div>{data.currentData.player.name}</div>
                <div style={{ color: 'black' }} className="player-position">{data.completeData.positions[0].position}</div>
            </div>
            {data.currentData.isSubbed && <div className="sub-plate">Subbed</div>}
            {data.currentData.isSub && <div className="sub-plate">Sub</div>}
        </div>
    );
}

export default Plate;