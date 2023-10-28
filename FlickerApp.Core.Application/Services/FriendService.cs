using AutoMapper;
using FlickerApp.Core.Application.Interfaces.Repositories;
using FlickerApp.Core.Application.Interfaces.Services;
using FlickerApp.Core.Application.ViewModels.Friend;
using FlickerApp.Core.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FlickerApp.Core.Application.Services
{
    public class FriendService : IGenericService<SaveFriendViewModel, FriendViewModel>
    {
        private readonly IFriendRepository _friendRepository;
        private readonly IMapper _mapper;

        public FriendService(IFriendRepository friendRepository, IMapper mapper)
        {
            _friendRepository = friendRepository;
            _mapper = mapper;
        }

        public async Task Add(SaveFriendViewModel viewModel)
        {
            Friend friend = _mapper.Map<Friend>(viewModel);
            await _friendRepository.AddAsync(friend);
        }

        public async Task Delete(int friendId)
        {
            var friend = await _friendRepository.GetByIdAsync(friendId);
            if (friend != null)
            {
                await _friendRepository.DeleteAsync(friend);
            }
        }

        public async Task<SaveFriendViewModel> GetByIdSaveViewModel(int friendId)
        {
            var friend = await _friendRepository.GetByIdAsync(friendId);
            return _mapper.Map<SaveFriendViewModel>(friend);
        }

        public async Task<List<FriendViewModel>> GetAllViewModel()
        {
            var friends = await _friendRepository.GetAllAsync();
            return _mapper.Map<List<FriendViewModel>>(friends);
        }

        public async Task Update(SaveFriendViewModel viewModel)
        {
            Friend friend = _mapper.Map<Friend>(viewModel);
            await _friendRepository.UpdateAsync(friend);
        }
    }
}
