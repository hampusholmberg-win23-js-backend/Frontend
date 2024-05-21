using System.Text.Json;
using System.Text.Json.Serialization;

namespace Frontend.Components.Models.GraphQL;

public class DynamicGraphQLResponse
{
    [JsonPropertyName("data")]
    public Data? Data { get; set; }
}
