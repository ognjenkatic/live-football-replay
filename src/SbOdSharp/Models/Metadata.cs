using System.Text.Json.Serialization;

namespace SbOdSharp
{
    public record Metadata(
        [property: JsonPropertyName("data_version")] string? DataVersion,
        [property: JsonPropertyName("shot_fidelity_version")] string? ShotFidelityVersion,
        [property: JsonPropertyName("xy_fidelity_version")] string? XyFidelityVersion
    );
}
