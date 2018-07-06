using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpotifyAPIApplication.Classes
{
    public class ResTopTracks
    {
        public partial class Welcome
        {
            [JsonProperty("tracks")]
            public Track[] Tracks { get; set; }
        }

        public partial class Track
        {
            [JsonProperty("album", NullValueHandling = NullValueHandling.Ignore)]
            public Album Album { get; set; }

            [JsonProperty("artists", NullValueHandling = NullValueHandling.Ignore)]
            public Artist[] Artists { get; set; }

            [JsonProperty("available_markets", NullValueHandling = NullValueHandling.Ignore)]
            public string[] AvailableMarkets { get; set; }

            [JsonProperty("disc_number", NullValueHandling = NullValueHandling.Ignore)]
            public long? DiscNumber { get; set; }

            [JsonProperty("duration_ms", NullValueHandling = NullValueHandling.Ignore)]
            public long? DurationMs { get; set; }

            [JsonProperty("explicit", NullValueHandling = NullValueHandling.Ignore)]
            public bool? Explicit { get; set; }

            [JsonProperty("external_ids", NullValueHandling = NullValueHandling.Ignore)]
            public ExternalIds ExternalIds { get; set; }

            [JsonProperty("external_urls", NullValueHandling = NullValueHandling.Ignore)]
            public ExternalUrls ExternalUrls { get; set; }

            [JsonProperty("href", NullValueHandling = NullValueHandling.Ignore)]
            public string Href { get; set; }

            [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
            public string Id { get; set; }

            [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
            public string Name { get; set; }

            [JsonProperty("popularity", NullValueHandling = NullValueHandling.Ignore)]
            public long? Popularity { get; set; }

            [JsonProperty("preview_url", NullValueHandling = NullValueHandling.Ignore)]
            public string PreviewUrl { get; set; }

            [JsonProperty("track_number", NullValueHandling = NullValueHandling.Ignore)]
            public long? TrackNumber { get; set; }

            [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
            public string Type { get; set; }

            [JsonProperty("uri", NullValueHandling = NullValueHandling.Ignore)]
            public string Uri { get; set; }
        }

        public partial class Album
        {
            [JsonProperty("album_type")]
            public string AlbumType { get; set; }

            [JsonProperty("artists")]
            public Artist[] Artists { get; set; }

            [JsonProperty("available_markets")]
            public string[] AvailableMarkets { get; set; }

            [JsonProperty("external_urls")]
            public ExternalUrls ExternalUrls { get; set; }

            [JsonProperty("href")]
            public string Href { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("images")]
            public Image[] Images { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("type")]
            public string Type { get; set; }

            [JsonProperty("uri")]
            public string Uri { get; set; }
        }

        public partial class Artist
        {
            [JsonProperty("external_urls")]
            public ExternalUrls ExternalUrls { get; set; }

            [JsonProperty("href")]
            public string Href { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("type")]
            public string Type { get; set; }

            [JsonProperty("uri")]
            public string Uri { get; set; }
        }

        public partial class ExternalUrls
        {
            [JsonProperty("spotify")]
            public string Spotify { get; set; }
        }

        public partial class Image
        {
            [JsonProperty("height")]
            public long Height { get; set; }

            [JsonProperty("url")]
            public string Url { get; set; }

            [JsonProperty("width")]
            public long Width { get; set; }
        }

        public partial class ExternalIds
        {
            [JsonProperty("isrc")]
            public string Isrc { get; set; }
        }

      
    }
}