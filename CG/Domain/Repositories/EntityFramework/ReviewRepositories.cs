using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using CG.Domain.Entities;
using CG.Domain.Repositories.Abstract;

namespace CG.Domain.Repositories.EntityFramework
{
    public class ReviewRepositories : IReviewsRepositories
    {
        private readonly AppDbContext _context;

        public ReviewRepositories(AppDbContext context)
        {
            _context = context;
        }

        public async Task DeleteReviewAsync(int id)
        {
            _context.Reviews.Remove(new Reviews { Id = id});
            await _context.SaveChangesAsync();
        }

        public async Task<Reviews> GetReviewByIdAsync(int id)
        {
           return await _context.Reviews.FirstOrDefaultAsync(x => x.Id == id);            
        }

        public async Task<IQueryable<Reviews>> GetReviewsAsync()
        {            
            return _context.Reviews.OrderBy(x => x.ListOrder).AsQueryable();
        }       

        public async Task SaveReviewAsync(Reviews review)
        {
            if (review.Id == default)
            {
                _context.Entry(review).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            }
            else
            {
                _context.Entry(review).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }
            await _context.SaveChangesAsync();
        }
    }
}
