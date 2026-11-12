using System.Net.Http.Json;
using frontend_survey.Models;

namespace frontend_survey.Services;

public class SurveyService(HttpClient http)
{
    public async Task<SurveyResponse?> GetByTokenAsync(string token) =>
        await http.GetFromJsonAsync<SurveyResponse>($"api/survey/{token}");
}
