using quiz_app.web.Primitives;

namespace quiz_app.web.Entities;

public class Question : Entity
{
    public string Text { get; set; } = null!;
    public List<Answer> Answers { get; set; } = [];
}