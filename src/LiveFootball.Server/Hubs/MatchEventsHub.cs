using LiveFootball.Application.Matches;
using Microsoft.AspNetCore.SignalR;
using SbOdSharp;
using System.Runtime.CompilerServices;

namespace LiveFootball.Server.Hubs
{
    public class MatchEventsHub(MatchService matchService) : Hub
    {
        private readonly MatchService matchService = matchService;

        public async IAsyncEnumerable<PlayEvent> StreamMatchEvents(
        int matchId,
        int eventInterval,
        string[] eventsOfInterest,
        [EnumeratorCancellation]
        CancellationToken cancellationToken)
        {
            if (eventInterval < 0 || eventInterval > 1000)
            {
                throw new InvalidCastException("Invalid play interval (this will be replaced by play speed in the future)");
            }

            eventsOfInterest ??= [];
            var events = matchService.GetMatchEvents(matchId).Where(e => eventsOfInterest.Contains(e.Type?.Name));

            foreach (var evnt in events)
            {
                // Check the cancellation token regularly so that the server will stop
                // producing items if the client disconnects.
                cancellationToken.ThrowIfCancellationRequested();

                yield return evnt;

                // Use the cancellationToken in other APIs that accept cancellation
                // tokens so the cancellation can flow down to them.
                await Task.Delay(eventInterval, cancellationToken);
            }
        }
    }
}
