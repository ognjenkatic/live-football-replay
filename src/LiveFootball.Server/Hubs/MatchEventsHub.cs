using LiveFootball.Application.Matches;
using Microsoft.AspNetCore.SignalR;
using SbOdSharp;
using System;
using System.Runtime.CompilerServices;

namespace LiveFootball.Server.Hubs
{
    public class MatchEventsHub(MatchService matchService) : Hub
    {
        private readonly MatchService matchService = matchService;

        public async IAsyncEnumerable<PlayEvent> StreamMatchEvents(
        int matchId,
        int speed,
        string[] eventsOfInterest,
        [EnumeratorCancellation]
        CancellationToken cancellationToken)
        {
            if (speed < 0 || speed > 1000)
            {
                throw new InvalidCastException("Invalid speed value, expected between 0 and 1000 non inclusive");
            }

            eventsOfInterest ??= [];
            var events = matchService.GetMatchEvents(matchId).Where(e => eventsOfInterest.Contains(e.Type?.Name)).ToArray();

            for (int i = 0; i < events.Length; i++)
            {
                cancellationToken.ThrowIfCancellationRequested();

                yield return events[i];

                if (i < events.Length - 1) 
                { 
                    var waitInterval = new TimeSpan((events[i+1].Timestamp.Ticks - events[i].Timestamp.Ticks)/speed);
                    await Task.Delay(waitInterval, cancellationToken);
                }
            }
        }
    }
}
