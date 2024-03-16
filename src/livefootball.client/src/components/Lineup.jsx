/* eslint-disable react/prop-types */
import React, { useState, useEffect } from 'react';
import Plate from './player/Plate.jsx';

async function fetchPlayerCutout(name) {
    const playerInfoResponse = await fetch(`api/players?name=${name}`);
    const playerInfo = await playerInfoResponse.json();

    return playerInfo.strCutout ?? playerInfo.strThumb;
}

const Lineup = ({ data }) => {
    const [players, setPlayers] = useState([]);

    useEffect(() => {
        const fetchPlayerInfo = async () => {
            if (!data?.currentLineup) return;

            const playersWithInfo = await Promise.all(data.currentLineup.map(async (member) => {
                const playerInfo = await fetchPlayerCutout(member.player.name);
                return {
                    isHomeTeam: data.isHomeTeam,
                    currentData: member,
                    completeData: data.completeLineup.find(l => l.player_name === member.player.name),
                    playerInfo,
                };
            }));

            playersWithInfo.sort((a, b) => a.completeData.positions[0].position_id - b.completeData.positions[0].position_id);
            setPlayers(playersWithInfo);
        };

        fetchPlayerInfo();
    }, [data.currentLineup, data.completeLineup]); // This effect depends on `data`, it will re-run when `data` changes.

    const activePlayers = players.filter(e => !e.currentData.isSubbed);
    const subs = players.filter(e => e.currentData.isSubbed);

    if (!data?.currentLineup) return null;

    return (
        <div>
            <div>
                {activePlayers.map((player, index) => (
                    <Plate key={index} data={player} />
                ))}
            </div>
            <br />
            <div className="player-subbed">
                {subs.map((player, index) => (
                    <Plate key={index} data={player} />
                ))}
            </div>
        </div>
    );
};

export default Lineup;
