namespace SocialNetwork.DAL.Entities;

/// <summary>
/// Модель сущности - Друг
/// </summary>
public class FriendEntity {
    public int id { get; set; }
    public int user_id { get; set; }
    public int friend_id { get; set; }
}