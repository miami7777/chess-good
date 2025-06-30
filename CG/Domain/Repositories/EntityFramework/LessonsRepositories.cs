using Microsoft.EntityFrameworkCore;
using CG.Domain.Entities;
using CG.Domain.Repositories.Abstract;

namespace CG.Domain.Repositories.EntityFramework
{
    public class LessonsRepositories : ILessonsRepositories
    {
        private readonly AppDbContext _context;

        public LessonsRepositories(AppDbContext context)
        {
            _context = context;
        }

        public async Task DeleteLessonAsync(int id)
        {
            _context.StudentsTrainers.Remove(new StudentsTrainers { Id = id});
            await _context.SaveChangesAsync();
        }

        public async Task<StudentsTrainers> GetLessonByIdAsync(int id)
        {
           return await _context.StudentsTrainers.Include(x => x.Students).Include(x => x.Trainers).FirstOrDefaultAsync(x => x.Id == id);            
        }

        public IQueryable<StudentsTrainers> GetLessonsByTrainerId(string id)
        {
            return _context.StudentsTrainers.Include(x => x.Students).Include(x => x.Trainers).Where(x => x.TrainerId == id).OrderByDescending(x => x.CreatedDate).AsQueryable();
        }

        public IQueryable<StudentsTrainers> GetLessons()
        {            
            return _context.StudentsTrainers.Include(x => x.Students).Include(x => x.Trainers).OrderByDescending(x => x.CreatedDate).AsQueryable();
        }
        

        public async Task SaveLessonAsync(StudentsTrainers lesson)
        {
            if (lesson.Id == default)
            {
                _context.Entry(lesson).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            }
            else
            {
                _context.Entry(lesson).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }
            await _context.SaveChangesAsync();
        }
    }
}
