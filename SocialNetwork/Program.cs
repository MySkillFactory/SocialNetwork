using SocialNetwork.BLL.Exceptions;
using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using SocialNetwork.PLL.Views;


class Program
{
    static MessageService messageService;
    static UserService userService;
    static FriendService friendService;
    private static MainView mainView;
    public static RegistrationView registrationView;
    public static AuthenticationView authenticationView;
    public static UserMenuView userMenuView;
    public static UserInfoView userInfoView;
    public static UserDataUpdateView userDataUpdateView;
    public static MessageSendingView messageSendingView;
    public static FriendsView friendsView;
    public static UserIncomingMessageView userIncomingMessageView;
    public static UserOutcomingMessageView userOutcomingMessageView;

    static void Main(string[] args)
    {
        userService = new UserService();
        messageService = new MessageService();
        friendService = new FriendService();

        mainView = new MainView();
        registrationView = new RegistrationView(userService);
        authenticationView = new AuthenticationView(userService);
        userMenuView = new UserMenuView(userService);
        userInfoView = new UserInfoView();
        userDataUpdateView = new UserDataUpdateView(userService);
        messageSendingView = new MessageSendingView(messageService, userService);
        friendsView = new FriendsView(friendService);
        userIncomingMessageView = new UserIncomingMessageView();
        userOutcomingMessageView = new UserOutcomingMessageView();

        while (true)
        {
            mainView.Show();
        }
    }
}
