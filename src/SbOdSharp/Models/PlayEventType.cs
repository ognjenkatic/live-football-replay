using System.Text.Json.Serialization;

namespace SbOdSharp
{
    public record PlayEventType(
        [property: JsonPropertyName("id")] int Id,
        [property: JsonPropertyName("name")] string Name
    )
    {
        public static readonly PlayEventType FiftyFifty = new(33, "50/50");
        public static readonly PlayEventType BadBehaviour = new(24, "Bad Behaviour");
        public static readonly PlayEventType BallReceipt = new(42, "Ball Receipt");
        public static readonly PlayEventType BallRecovery = new(2, "Ball Recovery");
        public static readonly PlayEventType Block = new(6, "Block");
        public static readonly PlayEventType Carry = new(43, "Carry");
        public static readonly PlayEventType Clearance = new(9, "Clearance");
        public static readonly PlayEventType Dispossessed = new(3, "Dispossessed");
        public static readonly PlayEventType Dribble = new(14, "Dribble");
        public static readonly PlayEventType DribbledPast = new(39, "Dribbled Past");
        public static readonly PlayEventType Duel = new(4, "Duel");
        public static readonly PlayEventType Error = new(37, "Error");
        public static readonly PlayEventType FoulCommitted = new(22, "Foul Committed");
        public static readonly PlayEventType FoulWon = new(21, "Foul Won");
        public static readonly PlayEventType GoalKeeper = new(23, "Goal Keeper");
        public static readonly PlayEventType HalfEnd = new(34, "Half End");
        public static readonly PlayEventType HalfStart = new(18, "Half Start");
        public static readonly PlayEventType InjuryStoppage = new(40, "Injury Stoppage");
        public static readonly PlayEventType Interception = new(10, "Interception");
        public static readonly PlayEventType Miscontrol = new(38, "Miscontrol");
        public static readonly PlayEventType Offside = new(8, "Offside");
        public static readonly PlayEventType OwnGoalAgainst = new(20, "Own Goal Against");
        public static readonly PlayEventType OwnGoalFor = new(25, "Own Goal For");
        public static readonly PlayEventType Pass = new(30, "Pass");
        public static readonly PlayEventType PlayerOff = new(27, "Player Off");
        public static readonly PlayEventType PlayerOn = new(26, "Player On ");
        public static readonly PlayEventType Pressure = new(17, "Pressure");
        public static readonly PlayEventType RefereeBallDrop = new(41, "Referee Ball-Drop");
        public static readonly PlayEventType Shield = new(28, "Shield");
        public static readonly PlayEventType Shot = new(16, "Shot");
        public static readonly PlayEventType StartingXI = new(35, "Starting XI");
        public static readonly PlayEventType Substitution = new(19, "Substitution");
        public static readonly PlayEventType TacticalShift = new(36, "Tactical Shift");
    }
}
