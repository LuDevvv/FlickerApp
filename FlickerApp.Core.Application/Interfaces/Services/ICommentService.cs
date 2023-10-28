using FlickerApp.Core.Application.ViewModels.Comment;

namespace FlickerApp.Core.Application.Interfaces.Services
{
    public interface ICommentService : IGenericService<SaveCommentViewModel, CommentViewModel>
    {
        Task<List<CommentViewModel>> GetCommentsByPublicationIdAsync(int publicationId);
    }
}
