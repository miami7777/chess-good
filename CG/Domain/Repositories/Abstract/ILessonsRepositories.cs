using CG.Domain.Entities;

namespace CG.Domain.Repositories.Abstract
{
    public interface ILessonsRepositories
    {
        IQueryable<StudentsTrainers> GetLessons();
        Task<StudentsTrainers> GetLessonByIdAsync(int id);
        IQueryable<StudentsTrainers> GetLessonsByTrainerId(string id);
        Task SaveLessonAsync(StudentsTrainers lesson);
        Task DeleteLessonAsync(int id);
    }
}
