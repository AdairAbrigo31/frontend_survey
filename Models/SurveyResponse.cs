namespace frontend_survey.Models;

public record AnswerRequest(Guid QuestionId, int? NumericValue, string? TextValue);

public record IndicatorResponse(Guid Id, string Code, string Name, int ScaleMin, int ScaleMax);

public record SurveyQuestionResponse(
    Guid QuestionId,
    string QuestionText,
    string Type,
    int SortOrder,
    IndicatorResponse? Indicator);

public record SurveyResponse(
    Guid SurveyId,
    Guid InvoiceId,
    string Name,
    List<SurveyQuestionResponse> Questions);
