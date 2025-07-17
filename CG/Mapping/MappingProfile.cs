using AutoMapper;
using CG.Domain;
using CG.Domain.Entities;
using CG.Domain.Enum;
using CG.Helpers;
using CG.Models;
using CG.Models.Lichess;

namespace CG.Mapping
{
    public class MappingProfile : AutoMapper.Profile
    {
        public MappingProfile()
        {
            CreateMap<ApplicationUser, UserViewModel>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(x => x.Id))
                .ForMember(dest => dest.Avatar, opt => opt.MapFrom(x => x.Avatar))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(x => x.Name))
                .ForMember(dest => dest.Surname, opt => opt.MapFrom(x => x.Surname))
                .ForMember(dest => dest.FIO, opt => opt.MapFrom(x => x.GetFio()))
                .ForMember(dest => dest.Region, opt => opt.MapFrom(x => x.Region))
                .ForMember(dest => dest.City, opt => opt.MapFrom(x => x.City))
                .ForMember(dest => dest.Stag, opt => opt.MapFrom(x => x.Stage))
                .ForMember(dest => dest.ChessTitle, opt => opt.MapFrom(x => x.ChessTitle))
                .ForMember(dest => dest.YearReceiveTitle, opt => opt.MapFrom(x => x.YearReceiveTitle))
                .ForMember(dest => dest.Rating, opt => opt.MapFrom(x => x.Rating))
                .ForMember(dest => dest.AvatarFilesId, opt => opt.MapFrom(x => x.AvatarFilesId))
                .ForMember(dest => dest.AvatarFile,opt => opt.MapFrom(x => x.AvatarFile))
                .ForMember(dest => dest.Age, opt => opt.Ignore())
                .ForMember(dest => dest.Roles, opt => opt.Ignore())
                .ForMember(dest => dest.CoursesCount, opt => opt.Ignore())
                .ForMember(dest => dest.WebinarsCount, opt => opt.Ignore())
                .ForMember(dest => dest.StudentsCount, opt => opt.Ignore())
                .ForMember(dest => dest.LichessData, opt => opt.Ignore())
                .ForMember(dest => dest.Lessons, opt => opt.Ignore())                
                ;
            CreateMap<LichessUsers, LichessAccountDto>()
                .ForMember(dest => dest.Profile, opt => opt.Ignore())
                .ForMember(dest => dest.Perfs, opt => opt.Ignore());
            CreateMap<LichessAccountDto, LichessUsers>()
                .ForMember(dest => dest.Profile, opt => opt.Ignore())
                .ForMember(dest => dest.Perfs, opt => opt.Ignore())
                .ForMember(dest => dest.PerfsId, opt => opt.Ignore())
                .ForMember(dest => dest.ProfileId, opt => opt.Ignore());
            CreateMap<Models.Lichess.PerfsStatistics, PerfsStatisticsLichess>()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                ;
        }
    }
}
