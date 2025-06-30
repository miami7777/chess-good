using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NuGet.DependencyResolver;
using System.Reflection.Emit;
using CG.Domain.Entities;
using CG.Domain.Entities;

namespace CG.Domain
{
    public class AppDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string, IdentityUserClaim<string>,
    ApplicationUserRole, IdentityUserLogin<string>,
    IdentityRoleClaim<string>, IdentityUserToken<string>>
    {
        private static string _connectionStringOrName = "name=projectConnection";
        public AppDbContext() 
        {        
           
        }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseDetails> CourseDetails { get; set; }
        public DbSet<Chapters> Chapters { get; set; }
        public DbSet<Webinar> Webinars { get; set; }
        public DbSet<Tariffs> Tariffs { get; set; }
        public DbSet<DirectoryCategory> DirectoryCategory { get; set; }
        public DbSet<DirectoryStatusCourses> DirectoryStatusCourses { get; set; }
        public DbSet<CG.Domain.Entities.Service> Services { get; set; }
        public DbSet<Settings> Settings { get; set; }
        public DbSet<Reviews> Reviews { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<CourseFiles> CourseFiles { get; set; }
        public DbSet<WebinarFiles> WebinarFiles { get; set; }
        public DbSet<StudentsTrainers> StudentsTrainers { get; set; }
        public DbSet<ProfileLichess> profileLichesses { get; set; }
        public DbSet<PerfsLichess> perfsLichesses { get; set; }
        public DbSet<PerfsStatisticsLichess> perfsStatisticsLichesses { get; set; }
        public DbSet<Perfs> perfs { get; set; }
        public DbSet<PerfsStatistics> perfsStatistics { get; set; }
        public DbSet<LichessUsers> LichessUsers { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<ClockTournament> ClockTournament { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<ApplicationUserRole>(userRole =>
            {
                userRole.HasKey(ur => new { ur.UserId, ur.RoleId });

                userRole.HasOne(ur => ur.Role)
                    .WithMany(r => r.UserRoles)
                    .HasForeignKey(ur => ur.RoleId)
                    .IsRequired();

                userRole.HasOne(ur => ur.User)
                    .WithMany(r => r.UserRoles)
                    .HasForeignKey(ur => ur.UserId)
                    .IsRequired();
            });
            builder.Entity<Chapters>(chapter => chapter                
                .HasOne(c => c.ChapterPreview)
                .WithMany()                
                .HasConstraintName("Chapters_PreviewCourseFiles_FK1")
                .OnDelete(DeleteBehavior.Restrict));
            builder.Entity<Chapters>(chapter => chapter
                .HasOne(c => c.ChapterVideo)
                .WithMany()                
                .HasConstraintName("Chapters_VideoCourseFiles_FK1")
                .OnDelete(DeleteBehavior.Restrict));

            builder.Entity<ApplicationRole>().HasData(new ApplicationRole
            {
                Id = "1",
                Name = "admin",
                NormalizedName = "ADMIN"
            });
            builder.Entity<ApplicationRole>().HasData(new ApplicationRole
            {
                Id = "2",
                Name = "organizer",
                NormalizedName = "ORGANIZER"
            });
            builder.Entity<ApplicationRole>().HasData(new ApplicationRole
            {
                Id = "3",
                Name = "user",
                NormalizedName = "USER"
            });
            builder.Entity<ApplicationRole>().HasData(new ApplicationRole
            {
                Id = "4",
                Name = "member",
                NormalizedName = "MEMBER"
            });
            builder.Entity<ApplicationUser>().HasData(new ApplicationUser
            {
                Id = "1",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "admin@admin.ru",
                NormalizedEmail = "ADMIN@ADMIN.RU",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "password"),
                SecurityStamp = string.Empty,
                Name = "Максим",
                Surname = "Королёв",
                Patronymic = "Владимирович",
                Avatar = "avatar-3.jpg"
            });
            builder.Entity<ApplicationUserRole>().HasData(new ApplicationUserRole
            {
                RoleId = "1",
                UserId = "1",
            });

            builder.Entity<ApplicationUser>().HasData(new ApplicationUser
            {
                Id = "2",
                UserName = "trainer1",
                NormalizedUserName = "TRAINER1",
                Email = "trainer@trainer.ru",
                NormalizedEmail = "TRAINER@TRAINER.RU",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "password"),
                SecurityStamp = string.Empty,
                Name = "Максим",
                Surname = "Королёв",
                Patronymic = "Владимирович",
                Avatar = "avatar-3.jpg",
                Profile = "team-9.jpg",                
                PreviewTrainerPhoto = "trainer-6.jpg",
                Country = "Россия",
                Region = "Ставропольский край",
                City = "Ставрополь",
                Sex = Enum.Sex.Male,
                DateBirthday = new DateTime(1983, 12, 29)

            });
            builder.Entity<ApplicationUserRole>().HasData(new ApplicationUserRole
            {
                RoleId = "2",
                UserId = "2",
            });
            builder.Entity<ApplicationUser>().HasData(new ApplicationUser
            {
                Id = "3",
                UserName = "trainer2",
                NormalizedUserName = "TRAINER2",
                Email = "trainer@trainer.ru",
                NormalizedEmail = "TRAINER@TRAINER.RU",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "password"),
                SecurityStamp = string.Empty,
                Name = "Майя",
                Surname = "Порожняк",
                Patronymic = "Владимировна",
                Avatar = "avatar-1.jpg",
                Profile = "team-7.jpg",
                TrainerPhoto = "trainer-1-3.jpg",
                PreviewTrainerPhoto = "trainer-4.jpg",
                Country = "Россия",
                Region = "Краснодарский край",
                City = "Краснодар",
                Sex = Enum.Sex.Female,
                DateBirthday = new DateTime(1998, 05, 26),
                ChessTitle = Enum.ChessTitle.WCM,
                Trophy = "Чемпионка Краснодарского края 2022 года"
            });
            builder.Entity<ApplicationUserRole>().HasData(new ApplicationUserRole
            {
                RoleId = "2",
                UserId = "3",
            });
            builder.Entity<ApplicationUser>().HasData(new ApplicationUser
            {
                Id = "4",
                UserName = "trainer3",
                NormalizedUserName = "TRAINER3",
                Email = "trainer@trainer.ru",
                NormalizedEmail = "TRAINER@TRAINER.RU",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "password"),
                SecurityStamp = string.Empty,
                Name = "Мурат",
                Surname = "Болотчиев",
                Patronymic = "Муратович",
                Avatar = "avatar-2.jpg",
                Profile = "team-8.jpg",
                TrainerPhoto = "trainer-1-4.jpg",
                PreviewTrainerPhoto = "trainer-5.jpg",
                Country = "Россия",
                Region = "Ростовская область",
                City = "Ростов-на-Дону",
                Sex = Enum.Sex.Male,
                DateBirthday = new DateTime(1984, 10, 10),
                Stage = 10
            });
            builder.Entity<ApplicationUserRole>().HasData(new ApplicationUserRole
            {
                RoleId = "2",
                UserId = "4",
            });
            builder.Entity<ApplicationUser>().HasData(new ApplicationUser
            {
                Id = "5",
                UserName = "user",
                NormalizedUserName = "USER",
                Email = "user@user.ru",
                NormalizedEmail = "USER@USER.RU",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "password"),
                SecurityStamp = string.Empty
            });
            builder.Entity<ApplicationUserRole>().HasData(new ApplicationUserRole
            {
                RoleId = "3",
                UserId = "5",
            });
            builder.Entity<ApplicationUser>().HasData(new ApplicationUser
            {
                Id = "6",
                UserName = "student1",
                NormalizedUserName = "STUDENT1",
                Email = "student@student.ru",
                NormalizedEmail = "STUDENT@STUDENT.RU",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "password"),
                SecurityStamp = string.Empty,
                Name = "name",
                Country = "Россия",
                City = "Краснодар",
                Region = "Краснодарский край"
            });
            builder.Entity<ApplicationUserRole>().HasData(new ApplicationUserRole
            {
                RoleId = "4",
                UserId = "6",
            });
            builder.Entity<ApplicationUser>().HasData(new ApplicationUser
            {
                Id = "7",
                UserName = "student2",
                NormalizedUserName = "STUDENT2",
                Email = "student@student.ru",
                NormalizedEmail = "STUDENT@STUDENT.RU",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "password"),
                SecurityStamp = string.Empty
            });
            builder.Entity<ApplicationUserRole>().HasData(new ApplicationUserRole
            {
                RoleId = "4",
                UserId = "7",
            });
            builder.Entity<ApplicationUser>().HasData(new ApplicationUser
            {
                Id = "8",
                UserName = "student3",
                NormalizedUserName = "STUDENT3",
                Email = "student@student.ru",
                NormalizedEmail = "STUDENT@STUDENT.RU",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "password"),
                SecurityStamp = string.Empty
            });
            builder.Entity<ApplicationUserRole>().HasData(new ApplicationUserRole
            {
                RoleId = "4",
                UserId = "8",
            });
            builder.Entity<ApplicationUser>().HasData(new ApplicationUser
            {
                Id = "9",
                UserName = "student4",
                NormalizedUserName = "STUDENT4",
                Email = "student@student.ru",
                NormalizedEmail = "STUDENT@STUDENT.RU",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "password"),
                SecurityStamp = string.Empty
            });
            builder.Entity<ApplicationUserRole>().HasData(new ApplicationUserRole
            {
                RoleId = "4",
                UserId = "9",
            });
            builder.Entity<DirectoryCategory>().HasData(new DirectoryCategory
            {
                Id = 1,
                Name = "Основы шахмат",
                Description = "",
                Url = "",
                Icon = "book",
                ListOrder = 1,
                Color = "ffbb2c",
                IsActive = true,
            });
            builder.Entity<DirectoryCategory>().HasData(new DirectoryCategory
            {
                Id = 2,
                Name = "Дебют",
                Description = "",
                Url = "",
                Icon = "door-open",
                ListOrder = 2,                
                Color = "5578ff",
                IsActive = true,
            });
            builder.Entity<DirectoryCategory>().HasData(new DirectoryCategory
            {
                Id = 3,
                Name = "Миттельшпиль",
                Description = "",
                Url = "",
                Icon = "medium",
                ListOrder = 3,
                Color = "e80368",
                IsActive = true,
            });
            builder.Entity<DirectoryCategory>().HasData(new DirectoryCategory
            {
                Id = 4,
                Name = "Эндшпиль",
                Description = "",
                Url = "",
                Icon = "door-closed",
                ListOrder = 4,
                Color = "e361ff",
                IsActive = true,
            });
            builder.Entity<DirectoryCategory>().HasData(new DirectoryCategory
            {
                Id = 5,
                Name = "Стратегия",
                Description = "",
                Url = "",
                Icon = "shuffle",
                ListOrder = 5,
                Color = "47aeff",
                IsActive = true,
            });
            builder.Entity<DirectoryCategory>().HasData(new DirectoryCategory
            {
                Id = 6,
                Name = "Тактика",
                Description = "",
                Url = "",
                Icon = "star",
                ListOrder = 6,
                Color = "ffa76e",
                IsActive = true,
            });
            builder.Entity<DirectoryCategory>().HasData(new DirectoryCategory
            {
                Id = 7,
                Name = "Матовые конструкции",
                Description = "",
                Url = "",
                Icon = "stop-circle-fill",
                ListOrder = 7,
                Color = "11dbcf",
                IsActive = true,
            });
            builder.Entity<DirectoryCategory>().HasData(new DirectoryCategory
            {
                Id = 8,
                Name = "Патовые конструкции",
                Description = "",
                Url = "",
                Icon = "stop-circle",
                ListOrder = 8,
                Color = "4233ff",
                IsActive = true,
            });
            builder.Entity<DirectoryCategory>().HasData(new DirectoryCategory
            {
                Id = 9,
                Name = "Тактические приемы",
                Description = "",
                Url = "",
                Icon = "textarea-t",
                ListOrder = 9,
                Color = "b2904f",
                IsActive = true,
            });
            builder.Entity<DirectoryCategory>().HasData(new DirectoryCategory
            {
                Id = 10,
                Name = "Чемпионы мира",
                Description = "",
                Url = "",
                Icon = "people-fill",
                ListOrder = 10,
                Color = "b20969",
                IsActive = true,
            });
            builder.Entity<DirectoryCategory>().HasData(new DirectoryCategory
            {
                Id = 11,
                Name = "Литература",
                Description = "",
                Url = "",
                Icon = "stack",
                ListOrder = 11,
                Color = "ff5828",
                IsActive = true,
            });
            builder.Entity<DirectoryCategory>().HasData(new DirectoryCategory
            {
                Id = 12,
                Name = "Задачи",
                Description = "",
                Url = "",
                Icon = "list-task",
                ListOrder = 12,
                Color = "29cc61",
                IsActive = true,
            });
            builder.Entity<DirectoryStatusCourses>().HasData(new DirectoryStatusCourses
            {
                Id = 1,
                Name = "Опубликован",
                Description = "",
                ListOrder = 1,
            });
            builder.Entity<DirectoryStatusCourses>().HasData(new DirectoryStatusCourses
            {
                Id = 2,
                Name = "В разработке",
                Description = "",
                ListOrder = 2,
            });
            builder.Entity<DirectoryStatusCourses>().HasData(new DirectoryStatusCourses
            {
                Id = 3,
                Name = "На модерации",
                Description = "",
                ListOrder = 3,
            });
            builder.Entity<DirectoryStatusCourses>().HasData(new DirectoryStatusCourses
            {
                Id = 4,
                Name = "Одобрен",
                Description = "",
                ListOrder = 4,
            });
            builder.Entity<DirectoryStatusCourses>().HasData(new DirectoryStatusCourses
            {
                Id = 5,
                Name = "В продаже",
                Description = "",
                ListOrder = 5,
            });
            builder.Entity<DirectoryStatusCourses>().HasData(new DirectoryStatusCourses
            {
                Id = 6,
                Name = "В архиве",
                Description = "",
                ListOrder = 6,
            });
            builder.Entity<Course>().HasData(new Course
            {
                Id = 1,
                Name = "Северный гамбит",
                Description = "Один из острейших дебютов в шахматах, так как там с первых же ходов жертвуются две пешки. В данном видео рассматриваются ловушки за белых и черных, \r\n                        которых так много в представленном дебютном варианте. Изучив их, вы сможете вылавливать тех соперников, которые слабо знакомы с тонкостями \r\n                        Северного гамбита. К тому же многие из этих ловушек очень красивы, поэтому даже если вы не собираетесь применять данный вариант на практике, то все \r\n                        равно получите незабываемое эстетическое удовольствие от просмотра этого ролика.",
                CategoryId = 2,
                Currency = Enum.Currency.RUB,
                Purchases = 30,
                Duration = 120,
                StartTimeCourse = new DateTime(2024, 08, 01, 18, 0, 0),
                EndTimeCourse = new DateTime(2024, 08, 01, 20, 0, 0),
                StatusId = 5,
                Price = 165,
                TrainerId = "3",                
                Views = 50,
                Likes = 25

            });
            builder.Entity<Course>().HasData(new Course
            {
                Id = 2,
                Name = "Ловушки в северном гамбите",
                Description = "В курсе рассказывается как ставить ловушки в северном гамбите",
                CategoryId = 2,
                Currency = Enum.Currency.RUB,
                Purchases = 30,
                Duration = 60,
                StartTimeCourse = new DateTime(2024, 08, 15, 18, 0, 0),
                EndTimeCourse = new DateTime(2024, 08, 15, 19, 0, 0),
                StatusId = 5,
                Price = 125,
                TrainerId = "3",                
                Views = 50,
                Likes = 25
            });
            builder.Entity<Webinar>().HasData(new Webinar
            {
                Id = 1,
                Name = "Северный гамбит",
                Description = "Майя Порожняк расскажет вам про один из самых романтических дебютов в Шахматной Истории, о северном гамбите, дебют, где белые жертвуют две пешки ради развития сверхмощной инициативы.",
                CategoryId = 2,
                TypeWebinar = Enum.TypeWebinar.GroupWebinar,
                Currency = Enum.Currency.RUB,
                Purchases = 30,
                Duration = 120,
                StartTimeWebinar = new DateTime(2024, 08, 01, 18, 0, 0),
                EndTimeWebinar = new DateTime(2024, 08, 01, 20, 0, 0),
                StatusId = 5,
                Price = 165,
                TrainerId = "3",              
                Views = 50,
                Likes = 25,
                AvailableSeats = 30
            });
            builder.Entity<Webinar>().HasData(new Webinar
            {
                Id = 2,
                Name = "Шахматная интуиция",
                Description = "Роль шахмат в развитии интуиции и творческого мышления учащихся",
                CategoryId = 2,
                TypeWebinar = Enum.TypeWebinar.GroupWebinar,
                Currency = Enum.Currency.RUB,
                Purchases = 30,
                Duration = 120,
                StartTimeWebinar = new DateTime(2024, 08, 01, 18, 0, 0),
                EndTimeWebinar = new DateTime(2024, 08, 01, 20, 0, 0),
                StatusId = 5,
                Price = 165,
                TrainerId = "3",                
                Views = 50,
                Likes = 25,
                AvailableSeats = 30
            });
            builder.Entity<CG.Domain.Entities.Service>().HasData(new CG.Domain.Entities.Service
            {
                Id = 1,
                Name = "Пробный урок",
                Description = "Пробный урок"
            });
            builder.Entity<CG.Domain.Entities.Service>().HasData(new CG.Domain.Entities.Service
            {
                Id = 2,
                Name = "Доступ к открытым курсам",
                Description = "Доступ к открытым курсам"
            });
            builder.Entity<CG.Domain.Entities.Service>().HasData(new CG.Domain.Entities.Service
            {
                Id = 3,
                Name = "Доступ к открытым вебинарам",
                Description = "Доступ к открытым вебинарам"
            });
            builder.Entity<CG.Domain.Entities.Service>().HasData(new CG.Domain.Entities.Service
            {
                Id = 4,
                Name = "Доступ к закрытым курсам"
            });
            builder.Entity<CG.Domain.Entities.Service>().HasData(new CG.Domain.Entities.Service
            {
                Id = 5,
                Name = "Доступ к закрытым вебинарам",
                Description = "Доступ к закрытым курсам"
            });
            builder.Entity<CG.Domain.Entities.Service>().HasData(new CG.Domain.Entities.Service
            {
                Id = 6,
                Name = "Доступ к закрытым вебинарам, 10 вебинаров в месяц длительность 1 час 30 мин.",
                Description = "Доступ к закрытым вебинарам, 10 вебинаров в месяц длительность 1 час 30 мин."
            });
            builder.Entity<CG.Domain.Entities.Service>().HasData(new CG.Domain.Entities.Service
            {
                Id = 7,
                Name = "Доступ к индивидуальным занятиям 10 занятий в месяц длительность 1 час 30 мин.",
                Description = "Доступ к индивидуальным занятиям 10 занятий в месяц длительность 1 час 30 мин."
            });
            builder.Entity<Tariffs>().HasData(new Tariffs
            {
                Id = 1,
                Name = "Бесплатно",
                Description = "Бесплатно",
                ServicesIds = "1;2;3",
                PriceMonth = 0,
            });
            builder.Entity<Tariffs>().HasData(new Tariffs
            {
                Id = 2,
                Name = "Самостоятельное обучение",                
                Description = "Самостоятельное обучение",
                ServicesIds = "1;2;3;4;5",
                PriceMonth = 3000,
                IsFeatured = true                 
            });
            builder.Entity<Tariffs>().HasData(new Tariffs
            {
                Id = 3,
                Name = "Групповые занятия",
                Description = "Групповые занятия",
                ServicesIds = "1;2;3;4;5;6",
                PriceMonth = 7000 
                 
            });
            builder.Entity<Tariffs>().HasData(new Tariffs
            {
                Id = 4,
                Name = "Индивидуальные занятия",                
                Description = "Индивидуальные занятия",
                ServicesIds = "1;2;3;4;5;6;7",
                IsAdvanced = true,
                PriceMonth = 12000
            });
            builder.Entity<Chapters>().HasData(new Chapters
            {
                Id = 1,
                Name = "Принятый северный гамбит",
                Description = "Прослушав курс вы поймете основные идеи данного гамбита, и историю возникновения. Узнаете кто из современников играет этот дебют.\r\n                                        Научитесь играть в комбинационные активные шахматы.",
                Header = "",
                NavigationTitle = "Основная идея гамбита"               
            });
            builder.Entity<Chapters>().HasData(new Chapters
            {
                Id = 2,
                Name = "Основные варианты дебюта",
                Description = "Обсуждается возможный план игры в миттельшпиле. Основные плюсы и минусы данного дебюта.",
                Header = "Глубокий разбор основных линий в дебюте, последнии новинки.",
                NavigationTitle = "Основные варианты"
            });
            builder.Entity<Chapters>().HasData(new Chapters
            {
                Id = 3,
                Name = "Отказанный северный гамбит",
                Description = "Расматривается основные возражения против северного гамбита. Способы уйти в удобные для черных линии.Обсуждается возможный план игры в миттельшпиле.",
                Header = "",
                NavigationTitle = "Как защищаться черным в северном гамбите"
            });
            builder.Entity<CourseDetails>().HasData(new CourseDetails
            {
                Id = 1,
                CourseId = 1,
                ChapterId = 1,
            });
            builder.Entity<CourseDetails>().HasData(new CourseDetails
            {
                Id = 2,
                CourseId = 1,
                ChapterId = 2,
            });
            builder.Entity<CourseDetails>().HasData(new CourseDetails
            {
                Id = 3,
                CourseId = 1,
                ChapterId = 3,
            });
            builder.Entity<Reviews>().HasData(new Reviews
            {
                Id = 1,
                Name = "Виктория Нос",
                Title = "Мама ученика",
                Description = "Занимается онлайн года 4,5 точно. Тренеры Майя Порожняк и Мурат Болотчиев ❤️❤️❤️самые лучшие тренера! Активные, позитивные, интересные!",
                Image = "testimonials-1.jpg",
                ListOrder = 1,
                Rating = 5,
            });
            builder.Entity<Reviews>().HasData(new Reviews
            {
                Id = 2,
                Name = "Иван Савелов",
                Title = "Отец ученика",
                Description = "Сын занимается около полугода, очень доволен!\r\n                                    На урок всегда идет с удовольвствием. Тренеру Максиму Королёву - отдельная благодарность!",
                Image = "testimonials-2.jpg",
                ListOrder = 2,
                Rating = 5,
            });
            builder.Entity<Reviews>().HasData(new Reviews
            {
                Id = 3,
                Name = "Виктория Нос",
                Title = "Мама ученика",
                Description = "Занимается онлайн года 4,5 точно. Тренеры Майя Порожняк и Мурат Болотчиев ❤️❤️❤️самые лучшие тренера! Активные, позитивные, интересные!",
                Image = "testimonials-3.jpg",
                ListOrder = 3,
                Rating = 5,
            });
            builder.Entity<Reviews>().HasData(new Reviews
            {
                Id = 4,
                Name = "Yana",
                Title = "Мать ученика",
                Description = "Мой сын начал заниматься в шахматной школе почти год назад и мы просто в восторге от результатов! Каждое занятие не только увлекательно, но и полезно.",
                Image = "testimonials-4.jpg",
                ListOrder = 4,
                Rating = 4,
            });
            builder.Entity<Reviews>().HasData(new Reviews
            {
                Id = 5,
                Name = "Светлана Лацерда",
                Title = "Ученица",
                Description = "Рекомендую школу шахмат!\r\n                                    Там работают самые добрые , умные люди !",
                Image = "testimonials-5.jpg",
                ListOrder = 5,
                Rating = 5,
            });
            builder.Entity<Reviews>().HasData(new Reviews
            {
                Id = 6,
                Name = "Денис Медведев",
                Title = "Приобрел курс по дебюту Дамиано",
                Description = "Это просто ужасно!Ужасный дебют, как можно такой дебют рекомендовать играть своим ученикам. ",
                Image = "testimonials-5.jpg",
                ListOrder = 6,
                Rating = 1,
            });
            builder.Entity<Settings>().HasData(new Settings
            {
                Id = 1,
                Name = "Главный заголовок",               
                Description = "Заголовок на главной странице на первом баннере",
                Key = "HeaderMain",
                Section = "Headers",
                Value = "Шахматная школа"
            });
        }
    }
}
