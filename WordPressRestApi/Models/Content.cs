using Newtonsoft.Json;

namespace WordPressRestApi.Models
{
    public class Content
    {
        [JsonProperty("rendered")]
        public string Rendered { get; set; }
        [JsonProperty("raw")]
        public string Raw { get; set; }
    }
}