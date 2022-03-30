using System.Net.Http.Headers;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ScaleBot.Shared
{
    public static class PitchClient
    {
        public class Recording
        {
            [JsonPropertyName("is_recording")]
            public bool IsRecording { get; set; }

            [JsonPropertyName("recording_completed")]
            public bool RecordingCompleted { get; set; }
        }

        public class RecordingStatus
        {
            [JsonPropertyName("recording")]
            public Recording? Recording { get; set; }
        }

        public class StopResult
        {
            [JsonPropertyName("scale")]
            public string? Scale { get; set; }

            [JsonPropertyName("percent_accuracy")]
            public string? PercentAccuracy { get; set; }
        }

        public class Status
        {
            [JsonPropertyName("recording_status")]
            public RecordingStatus? RecordingStatus { get; set; }

            [JsonPropertyName("actual_notes")]
            public List<string>? ActualNotes { get; set; }

            [JsonPropertyName("actual_pitches")]
            public List<float>? ActualPitches { get; set; }

            [JsonPropertyName("scale")]
            public string? Scale { get; set; }

            [JsonPropertyName("each_note_accuracy")]
            public string? EachNoteAccuracy { get; set; }

            [JsonPropertyName("percent_accuracy")]
            public string? PercentAccuracy { get; set; }
        }

        public class ApiClient
        {
            private static readonly HttpClient client = new HttpClient();
            private string apiUrl;

            public ApiClient(string apiUrl)
            {
                this.apiUrl = apiUrl;
            }

            public RecordingStatus? Start()
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    var response = client.GetAsync(this.apiUrl + "/start").Result;
                    if (response.IsSuccessStatusCode)
                    {
                        return JsonSerializer.Deserialize<RecordingStatus>(response.Content.ReadAsStringAsync().Result);
                    }
                }
                catch (Exception)
                {
                    // Ignore error and return null
                }

                return null;
            }

            public StopResult? Stop()
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    var response = client.GetAsync(this.apiUrl + "/stop").Result;
                    if (response.IsSuccessStatusCode)
                    {
                        return JsonSerializer.Deserialize<StopResult>(response.Content.ReadAsStringAsync().Result);
                    }
                }
                catch (Exception)
                {
                    // Ignore error and return null
                }

                return null;
            }

            public Status? GetStatus()
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    var response = client.GetAsync(this.apiUrl + "/status").Result;
                    if (response.IsSuccessStatusCode)
                    {
                        return JsonSerializer.Deserialize<Status>(response.Content.ReadAsStringAsync().Result);
                    }
                }
                catch (Exception)
                {
                    // Ignore error and return null
                }

                return null;
            }
        }
    }
}
