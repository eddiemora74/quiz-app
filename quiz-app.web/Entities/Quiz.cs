using quiz_app.web.Primitives;

namespace quiz_app.web.Entities;

public class Quiz : Entity
{
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public DateTime DateCreated { get; set; }
    public DateTime DateModified { get; set; }
    public List<Question> Questions { get; set; } = [];
}