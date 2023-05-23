using Dapper;
using System.Data;
using System.Data.SQLite;

namespace SocialNetwork.DAL.Repositories;

public class BaseRepository
{
    protected T QueryFirstOrDefault<T>(string sql, object parameters = null)
    {
        using (var connection = CreateConnection())
        {
            connection.Open();
            return connection.QueryFirstOrDefault<T>(sql, parameters);
        }
    }

    protected List<T> Query<T>(string sql, object parameters = null)
    {
        using (var connection = CreateConnection())
        {
            connection.Open();
            return connection.Query<T>(sql, parameters).ToList();
        }
    }

    protected int Execute(string sql, object parameters = null)
    {
        using (var connection = CreateConnection())
        {
            connection.Open();
            return connection.Execute(sql, parameters);
        }
    }

    private IDbConnection CreateConnection()
    {
        // /Users/ownermac/Documents/VS_Projects/Skill Factory/SocialNetwork/SocialNetwork/DAL/DB/social_network_db.db

        string connection =
            $"Data Source = DAL{Path.DirectorySeparatorChar}DB" +
            $"{Path.DirectorySeparatorChar}social_network_db.db; Version = 3";
        
        return new SQLiteConnection(connection);
    }
}