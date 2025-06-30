using CG.Domain.Entities;
using CG.Domain.Enum;

namespace CG.Domain.Repositories.Abstract
{
    public interface IWebinarRepositories
    {
        IQueryable<Webinar> GetWebinar();
        Task<Webinar> GetWebinarByIdAsync(int id);
        IQueryable<Webinar> GetWebinarByTrainerId(string trainerId,int status);
        Task SaveWebinarAsync(Webinar category);
        Task DeleteWebinarAsync(int id);
        Task ChangeWebinarAccess(int webinarId, TypeCourse type);
        Task ChangeWebinarKind(int webinarId, TypeWebinar type);
        Task ChangeWebinarStatus(int webinarId, int status);
    }
}
