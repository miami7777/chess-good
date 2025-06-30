using CG.Domain.Entities;

namespace CG.Domain.Repositories.Abstract
{
    public interface IReviewsRepositories
    {
        Task<IQueryable<Reviews>> GetReviewsAsync();       
        Task<Reviews> GetReviewByIdAsync(int id);
        Task SaveReviewAsync(Reviews review);
        Task DeleteReviewAsync(int id);
    }
}
