using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using SocialNetwork.PLL.Helpers;

namespace SocialNetwork.PLL.Views;

public class RegistrationView
{
    private UserService _userService;

    public RegistrationView(UserService userService)
    {
        this._userService = userService;
    }

    public void Show()
    {
        var userRegistrationData = new UserRegistrationData();
        
        Console.WriteLine("Для создания нового профиля введите ваше имя:");
        userRegistrationData.FirstName = Console.ReadLine();
        
        Console.Write("Ваша фамилия:");
        userRegistrationData.LastName = Console.ReadLine();

        Console.Write("Пароль:");
        userRegistrationData.Password = Console.ReadLine();

        Console.Write("Почтовый адрес:");
        userRegistrationData.Email = Console.ReadLine();

        try
        {
            this._userService.Register(userRegistrationData);
            SuccessMessage.Show(
                "Ваш профиль успешно создан. Теперь Вы можете войти в систему под своими учетными данными.");
        }
        catch (ArgumentException)
        {
            AlertMessage.Show("Введите корректное значение.");
        }
        catch (Exception)
        {
            AlertMessage.Show("Произошла ошибка при регистрации.");
        }
    }
}