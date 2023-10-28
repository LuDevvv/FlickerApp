using AutoMapper;
using FlickerApp.Core.Application.ViewModels.Comment;
using FlickerApp.Core.Application.ViewModels.Friend;
using FlickerApp.Core.Application.ViewModels.Publication;
using FlickerApp.Core.Application.ViewModels.User;
using FlickerApp.Core.Domain.Entities;

namespace FlickerApp.Core.Application.Mappings
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<User, UserViewModel>()
                .ForMember(x => x.FullName, opt => opt.MapFrom(src => $"{src.FirstName} {src.LastName}"))
                .ForMember(x => x.Age, opt => opt.MapFrom(src => CalculateAge(src.BirthDate)))
                .ReverseMap();

            CreateMap<SaveUserViewModel, User>()
                .ForMember(x => x.IsActive, opt => opt.Ignore());

            CreateMap<Publication, PublicationViewModel>()
                .ForMember(x => x.PhotoUrl, opt => opt.MapFrom(src => GetPhotoUrl(src.Photo)))
                .ForMember(x => x.PublicationDate, opt => opt.MapFrom(src => FormatPublicationDate(src.CreatedDate)))
                .ReverseMap();

            CreateMap<SavePublicationViewModel, Publication>()
                .ForMember(x => x.CreatedDate, opt => opt.Ignore())
                .ForMember(x => x.LastModified, opt => opt.Ignore());

            CreateMap<Friend, FriendViewModel>()
                .ForMember(x => x.FullFriendName, opt => opt.MapFrom(src => $"{src.User.FirstName} {src.User.LastName}"))
                .ReverseMap();

            CreateMap<SaveFriendViewModel, Friend>()
                .ForMember(x => x.Created, opt => opt.Ignore())
                .ForMember(x => x.LastModified, opt => opt.Ignore());

            CreateMap<Comment, CommentViewModel>()
                // .ForMember(x => x.UserFullName, opt => opt.MapFrom(src => $"{src.User.FirstName} {src.User.LastName}"))
                .ReverseMap()
                .ForMember(x => x.CreatedDate, opt => opt.Ignore());


            CreateMap<SaveCommentViewModel, Comment>()
                .ForMember(x => x.CreatedDate, opt => opt.Ignore());
        }

        private int CalculateAge(DateTime birthDate)
        {
            // Implementa la lógica real para calcular la edad a partir de la fecha de nacimiento
            DateTime today = DateTime.Today;
            int age = today.Year - birthDate.Year;
            if (birthDate.Date > today.AddYears(-age)) age--;
            return age;
        }

        private string GetPhotoUrl(string photo)
        {
            // Implementa la lógica real para obtener la URL de la foto
            // Aquí podrías construir la URL de la foto según tu estructura
            return string.Empty; // Reemplaza esto con la lógica real
        }

        private string FormatPublicationDate(DateTime createdDate)
        {
            // Implementa la lógica real para formatear la fecha de publicación
            return createdDate.ToString("yyyy-MM-dd HH:mm:ss"); // Reemplaza esto con la lógica real
        }
    }
}
