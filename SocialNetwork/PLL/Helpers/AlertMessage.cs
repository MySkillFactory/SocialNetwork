namespace SocialNetwork.PLL.Helpers;

public static class AlertMessage
{
    public static void Show(string message)
    {
        ConsoleColor originalColor = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"\n{message}\n");
        Console.ForegroundColor = originalColor;
    }
}