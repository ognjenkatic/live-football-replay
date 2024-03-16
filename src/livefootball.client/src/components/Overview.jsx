/* eslint-disable react/prop-types */
//import React from 'react';

const Overview = (overview) => {
    console.log(overview);
    return <div>
        <img width="100" height="100" src={overview?.data?.homeTeaminfo?.strTeamBadge} alt="Team Avatar"/>
        <div>
            <span>{overview?.data?.home_team?.home_team_name} vs {overview?.data?.away_team?.away_team_name}</span>
        </div>
    </div>
};

export default Overview;