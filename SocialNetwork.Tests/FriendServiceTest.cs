using Moq;
using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using SocialNetwork.DAL.Entities;
using SocialNetwork.DAL.Repositories;

namespace SocialNetwork.Tests;

public class FriendServiceTest
{
    [Fact]
    public void Test1()
    {
        FriendEntity friendEntity = new()
        {
            user_id = 1,
            friend_id = 2
        };

        var mock = new Mock<IFriendRepository>();
        var friendService = new FriendService() { _friendRepository = mock.Object };

        mock.Setup(r => r.FindAllByUserId(friendEntity.user_id)).Returns(GetTestUsers());

        var result = friendService.GetFriends(friendEntity.user_id);

        var rc = result.Count();

        foreach (var friend in result)
        {
            Assert.Equal(friendEntity.user_id, friend.user_id);
        }
    }

    private List<FriendEntity> GetTestUsers()
    {
        var users = new List<FriendEntity>
        {
            new FriendEntity() { id = 1, user_id = 1, friend_id = 2 },
            new FriendEntity() { id = 2, user_id = 1, friend_id = 3 }
        };
        return users;
    }
}