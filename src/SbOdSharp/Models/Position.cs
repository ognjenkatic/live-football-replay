using System.Text.Json.Serialization;

namespace SbOdSharp
{
    public record Position(
        [property: JsonPropertyName("id")] int Id,
        [property: JsonPropertyName("name")] string Name
    )
    {
        public static readonly Position Goalkeeper = new(1, "Goalkeeper");
        public static readonly Position RightBack = new(2, "Right Back");
        public static readonly Position RightCenterBack = new(3, "Right Center Back");
        public static readonly Position CenterBack = new(4, "Center Back");
        public static readonly Position LeftCenterBack = new(5, "Left Center Back");
        public static readonly Position LeftBack = new(6, "Left Back");
        public static readonly Position RightWingBack = new(7, "Right Wing Back");
        public static readonly Position LeftWingBack = new(8, "Left Wing Back");
        public static readonly Position RightDefensiveMidfield = new(9, "Right Defensive Midfield");
        public static readonly Position CenterDefensiveMidfield =
            new(10, "Center Defensive Midfield");
        public static readonly Position LeftDefensiveMidfield = new(11, "Left Defensive Midfield");
        public static readonly Position RightMidfield = new(12, "Right Midfield");
        public static readonly Position RightCenterMidfield = new(13, "Right Center Midfield");
        public static readonly Position CenterMidfield = new(14, "Center Midfield");
        public static readonly Position LeftCenterMidfied = new(15, "Left Center Midfield");
        public static readonly Position LeftMidfield = new(16, "Left Midfield");
        public static readonly Position RightWing = new(17, "Right Wing");
        public static readonly Position RightAttackingMidfield =
            new(18, "Right Attacking Midfield");
        public static readonly Position CenterAttackingMidfield =
            new(19, "Center Attacking Midfield");
        public static readonly Position LeftAttackingMidfield = new(20, "Left Attacking Midfield");
        public static readonly Position LeftWing = new(21, "Left Wing");
        public static readonly Position RightCenterForward = new(22, "Right Center Forward");
        public static readonly Position Striker = new(23, "Striker");
        public static readonly Position LeftCenterForward = new(24, "Left Center Forward");
        public static readonly Position SecondaryStriker = new(25, "Secondary Striker");

        // TODO: Check if these goalkeeper positions belong here
        public static readonly Position Moving = new(42, "Moving");
        public static readonly Position Prone = new(43, "Prone");
        public static readonly Position Set = new(44, "Set");
    }
}
