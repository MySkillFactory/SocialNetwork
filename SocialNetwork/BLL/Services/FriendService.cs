using System.ComponentModel.DataAnnotations;
using SocialNetwork.BLL.Exceptions;
using SocialNetwork.BLL.Models;
using SocialNetwork.DAL.Entities;
using SocialNetwork.DAL.Repositories;

namespace SocialNetwork.BLL.Services;

public class FriendService
{
    public IFriendRepository _friendRepository;
    private IUserRepository _userRepository;

    public FriendService()
    {
        _friendRepository = new FriendRepository();
        _userRepository = new UserRepository();
    }

    public IEnumerable<FriendEntity> GetFriends(int userId)
    {
        return _friendRepository.FindAllByUserId(userId).ToList();
    }

    public void AddFriend(AddFriendData friendData)
    {
        var findUserEntity = this._userRepository.FindByEmail(friendData.friend_email);

        if (findUserEntity is null)
            throw new UserNotFoundException();

        if (friendData.user_id == findUserEntity.id)
            throw new MySelfException();

        var friendEntity = new FriendEntity()
        {
            user_id = friendData.user_id,
            friend_id = findUserEntity.id
        };

        if (_friendRepository.Create(friendEntity) == 0)
            throw new Exception();
    }
}