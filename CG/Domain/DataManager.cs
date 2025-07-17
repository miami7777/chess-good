using CG.Domain.Repositories.Abstract;
using CG.Service.Interfaces;

namespace CG.Domain
{
    public class DataManager
    {
        public IServiceRepositories serviceRepositories;
        public ICourseRepositories courseRepositories;
        public ICategoryRepositories categoryRepositories;
        public IStatusCoursesRepositories statusCoursesRepositories;
        public IUsersRepositories userRepositories;
        public IWebinarRepositories webinarRepositories;
        public ITariffsRepositories tariffRepositories;
        public IReviewsRepositories reviewsRepositories;
        public ISettingsRepositories settingsRepositories;
        public ILessonsRepositories lessonsRepositories;
        public ICourseFilesRepositories courseFilesRepositories;
        public IWebinarFilesRepositories webinarFilesRepositories;
        public IChaptersRepositories chaptersRepositories;
        public ICourseDetailsRepositories courseDetailsRepositories;
        public ILichessUsersRepositories lichessUsersRepositories;
        public IClockTournamentsRepositories clockTournamentsRepositories;  
        public IUserFilesRepositories userFilesRepositories;

        public DataManager(IServiceRepositories serviceRepositories, IWebinarRepositories webinarRepositories, ICourseRepositories courseRepositories,
            IUsersRepositories userRepositories, IStatusCoursesRepositories statusCoursesRepositories, ICategoryRepositories categoryRepositories, 
            ITariffsRepositories tariffRepositories, IReviewsRepositories reviewsRepositories, ISettingsRepositories settingsRepositories, 
            ILessonsRepositories lessonsRepositories, ICourseFilesRepositories courseFilesRepositories, IChaptersRepositories chaptersRepositories,
            ICourseDetailsRepositories courseDetailsRepositories, IWebinarFilesRepositories webinarFilesRepositories, ILichessUsersRepositories lichessUsersRepositories,
            IClockTournamentsRepositories clockTournamentsRepositories, IUserFilesRepositories userFilesRepositories)
        {
            this.serviceRepositories = serviceRepositories;
            this.webinarRepositories = webinarRepositories;
            this.courseRepositories = courseRepositories;
            this.userRepositories = userRepositories;
            this.categoryRepositories = categoryRepositories;
            this.statusCoursesRepositories = statusCoursesRepositories;
            this.tariffRepositories = tariffRepositories;
            this.reviewsRepositories = reviewsRepositories;
            this.settingsRepositories = settingsRepositories;
            this.lessonsRepositories = lessonsRepositories;
            this.courseFilesRepositories = courseFilesRepositories;
            this.chaptersRepositories = chaptersRepositories;
            this.courseDetailsRepositories = courseDetailsRepositories;
            this.webinarFilesRepositories = webinarFilesRepositories;
            this.lichessUsersRepositories = lichessUsersRepositories;
            this.clockTournamentsRepositories = clockTournamentsRepositories; 
            this.userFilesRepositories = userFilesRepositories;
        }
    }
}
