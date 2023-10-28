using FlickerApp.Core.Application.Interfaces.Services;
using FlickerApp.Core.Application.Services;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace FlickerApp.Core.Application
{
    public static class ServiceRegistration
    {
        public static void AddApplicationLayer(this IServiceCollection services)
        {
            //services.AddAutoMapper(Assembly.GetExecutingAssembly());

            #region Services
            //services.AddTransient(typeof(IGenericService<,,>), typeof(GenericService<,,>));
            //services.AddTransient<IUserService, UserService>();
            //services.AddTransient<IPublicationService, PublicationService>();
            //services.AddTransient<ICommentService, CommentService>();
            //services.AddTransient<IFriendService, FriendService>();
            #endregion
        }
    }
}
