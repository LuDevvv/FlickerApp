using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using FlickerApp.Core.Application.Interfaces.Repositories;
using FlickerApp.Core.Application.Interfaces.Services;
using FlickerApp.Core.Application.ViewModels.Comment;
using FlickerApp.Core.Domain.Entities;

namespace FlickerApp.Core.Application.Services
{
    public class CommentService : IGenericService<SaveCommentViewModel, CommentViewModel>
    {
        private readonly ICommentRepository _commentRepository;
        private readonly IMapper _mapper;

        public CommentService(ICommentRepository commentRepository, IMapper mapper)
        {
            _commentRepository = commentRepository;
            _mapper = mapper;
        }

        public async Task Add(SaveCommentViewModel viewModel)
        {
            Comment comment = _mapper.Map<Comment>(viewModel);
            await _commentRepository.AddAsync(comment);
        }

        public async Task Delete(int commentId)
        {
            var comment = await _commentRepository.GetByIdAsync(commentId);
            if (comment != null)
            {
                await _commentRepository.DeleteAsync(comment);
            }
        }

        public async Task<SaveCommentViewModel> GetByIdSaveViewModel(int commentId)
        {
            var comment = await _commentRepository.GetByIdAsync(commentId);
            return _mapper.Map<SaveCommentViewModel>(comment);
        }

        public async Task<List<CommentViewModel>> GetCommentsByPublicationIdAsync(int publicationId)
        {
            var comments = await _commentRepository.GetCommentsByPublicationIdAsync(publicationId);
            return _mapper.Map<List<CommentViewModel>>(comments);
        }

        public async Task Update(SaveCommentViewModel viewModel)
        {
            Comment comment = _mapper.Map<Comment>(viewModel);
            await _commentRepository.UpdateAsync(comment);
        }

        public async Task<List<CommentViewModel>> GetAllViewModel()
        {
            var comments = await _commentRepository.GetAllAsync();
            return _mapper.Map<List<CommentViewModel>>(comments);
        }
    }
}
