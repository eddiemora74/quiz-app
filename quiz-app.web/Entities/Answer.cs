using quiz_app.web.Primitives;

namespace quiz_app.web.Entities;

public class Answer : Entity
{
    public string AnswerKey { get; set; } = null!;
    public string Text { get; set; } = null!;
    public bool IsCorrect { get; set; } = false;
}