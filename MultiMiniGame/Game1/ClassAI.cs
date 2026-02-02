using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace MultiMiniGame.Game1
{
    public class AIManager
    {
        private readonly HttpClient _http = new HttpClient { BaseAddress = new Uri("http://localhost:11434") };
        private List<object> _chatHistory = new List<object>(); // Store memory
        private string _model = "phi3:mini";

        public async Task<string> GetResponseAsync(string prompt)
        {
            // 1. Add user message to memory
            _chatHistory.Add(new { role = "user", content = prompt });

            var requestBody = new
            {
                model = _model,
                messages = _chatHistory,
                stream = false // ber dak true add foreach
            };

            try
            {
                var response = await _http.PostAsJsonAsync("/api/chat", requestBody);
                var result = await response.Content.ReadFromJsonAsync<OllamaChatResponse>();

                // 2. Add AI response to memory, only if result and message are not null
                if (result?.message?.content != null)
                {
                    _chatHistory.Add(new { role = "assistant", content = result.message.content });
                    return result.message.content;
                }
                else
                {
                    return "Error: No response from AI model.";
                }
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }

        public void ResetMemory() => _chatHistory.Clear();

        // Small classes to map the JSON response
        private class OllamaChatResponse { public Message? message { get; set; } }
        private class Message { public string content { get; set; } = string.Empty; }
    }
}
