using SocialNetwork.BLL.Exceptions;
using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using SocialNetwork.PLL.Helpers;

namespace SocialNetwork.PLL.Views;

public class FriendsView
{
    private FriendService _friendService;

    public FriendsView(FriendService friendService)
    {
        _friendService = friendService;
    }
    
    public void Show(User user)
    {
        var addFriendData = new AddFriendData();
            
        Console.Write("Введите почтовый адрес друга: ");
        addFriendData.friend_email = Console.ReadLine();

        addFriendData.user_id = user.Id;

        try
        {
            _friendService.AddFriend(addFriendData);
            SuccessMessage.Show("Пользователь добавлен в друзья");
        }
        catch (UserNotFoundException)
        {
            AlertMessage.Show("Не найден пользователь с данным e-mail!");
        }
        catch (MySelfException)
        {
            AlertMessage.Show("Нельзя добавить в друзья самого себя!");
        }
        catch (Exception ex)
        {
            AlertMessage.Show($"Ошибка: {ex.Message}");
        }
    }
}