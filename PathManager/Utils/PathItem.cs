using System.Text.Json.Serialization;

namespace PathManager.Utils;

public class PathItem
{
    // Define as a property (important for BindingSource to recognize)

    [JsonPropertyName("path")]
    public string Path { get; set; } = string.Empty;
    [JsonPropertyName("note")]
    public string Note { get; set; } = string.Empty;
    [JsonPropertyName("last_opened_at")]
    public DateTime LastOpenedAt { get; set; } = new();
    [JsonPropertyName("is_favorite")]
    public bool IsFavorite { get; set; } = false;
}
