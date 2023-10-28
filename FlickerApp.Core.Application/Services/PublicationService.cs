using AutoMapper;
using FlickerApp.Core.Application.Interfaces.Repositories;
using FlickerApp.Core.Application.Interfaces.Services;
using FlickerApp.Core.Application.ViewModels.Publication;
using FlickerApp.Core.Domain.Entities;

namespace FlickerApp.Core.Application.Services
{
    public class PublicationService : IGenericService<SavePublicationViewModel, PublicationViewModel>
    {
        private readonly IPublicationRepository _publicationRepository;
        private readonly IMapper _mapper;

        public PublicationService(IPublicationRepository publicationRepository, IMapper mapper)
        {
            _publicationRepository = publicationRepository;
            _mapper = mapper;
        }

        public async Task Add(SavePublicationViewModel viewModel)
        {
            Publication publication = _mapper.Map<Publication>(viewModel);
            await _publicationRepository.AddAsync(publication);
        }

        public async Task Delete(int publicationId)
        {
            var publication = await _publicationRepository.GetByIdAsync(publicationId);
            if (publication != null)
            {
                await _publicationRepository.DeleteAsync(publication);
            }
        }

        public async Task<SavePublicationViewModel> GetByIdSaveViewModel(int publicationId)
        {
            var publication = await _publicationRepository.GetByIdAsync(publicationId);
            return _mapper.Map<SavePublicationViewModel>(publication);
        }

        public async Task<List<PublicationViewModel>> GetAllViewModel()
        {
            var publications = await _publicationRepository.GetAllAsync();
            return _mapper.Map<List<PublicationViewModel>>(publications);
        }

        public async Task Update(SavePublicationViewModel viewModel)
        {
            Publication publication = _mapper.Map<Publication>(viewModel);
            await _publicationRepository.UpdateAsync(publication);
        }
    }
}
