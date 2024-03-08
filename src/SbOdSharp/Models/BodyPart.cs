using System.Text.Json.Serialization;

namespace SbOdSharp
{
    public record BodyPart(
        [property: JsonPropertyName("id")] int Id,
        [property: JsonPropertyName("name")] string Name
    )
    {
        public static readonly BodyPart BothHands = new(35, "Both Hands");
        public static readonly BodyPart Chest = new(36, "Chest");
        public static readonly BodyPart Head = new(37, "Head");
        public static readonly BodyPart LeftFoot = new(38, "Left Foot");
        public static readonly BodyPart LeftHand = new(39, "Left Hand");
        public static readonly BodyPart RightFoot = new(40, "Right Foot");
        public static readonly BodyPart RightHand = new(41, "Right Hand");
        public static readonly BodyPart DropKick = new(68, "Drop Kick");
        public static readonly BodyPart KeeperArm = new(69, "Keeper Arm");
        public static readonly BodyPart Other = new(70, "Other");
        public static readonly BodyPart NoTouch = new(106, "No Touch");
    }
}
