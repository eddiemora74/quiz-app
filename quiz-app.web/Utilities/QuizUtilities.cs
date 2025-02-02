using Microsoft.JSInterop;
using quiz_app.web.Entities;

namespace quiz_app.web.Utilities;

public static class QuizUtilities
{
    public static IQueryable<Quiz> GetQuizzes(this ILocalStorageService localStorageService)
    {
        return localStorageService.GetItem<List<Quiz>>("quizzes")?.AsQueryable()
            ?? new List<Quiz>().AsQueryable();
    }

    public static Quiz GetQuiz(this ILocalStorageService localStorageService, Guid quizId)
    {
        return localStorageService
            .GetItem<List<Quiz>>("quizzes")
            ?.FirstOrDefault(q => q.Id.Equals(quizId)) ?? new Quiz() { Id = Guid.Empty };
    }
}