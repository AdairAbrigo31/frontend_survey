using System.Net.Http.Json;
using frontend_survey.Models;

namespace frontend_survey.Services;

public class SurveyService(HttpClient http)
{
    public async Task<SurveyResponse?> GetByTokenAsync(string token)
    {
        var response = await http.GetAsync($"api/survey/{token}");
        if (!response.IsSuccessStatusCode) return null;
        return await response.Content.ReadFromJsonAsync<SurveyResponse>();
    }

    public async Task<HttpResponseMessage> SubmitAsync(string token, List<AnswerRequest> answers) =>
        await http.PostAsJsonAsync($"api/survey/{token}/submit", new { Answers = answers });
}
