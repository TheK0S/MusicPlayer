using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer
{
    internal class Data
    {
        public static Form1? form1;
        public static CreatePleyList? formCreatePlayList;
        public static Dictionary<string, List<string>> dictLists = new Dictionary<string, List<string>>();
        public static SoundPlayer player = new SoundPlayer();

        static string connectionStringFromDB = @"Data Source = DESKTOP-HHO6PH0; Initial Catalog = master; Trusted_Connection=True; Encrypt = False";
        static string connectionString = @"Data Source = DESKTOP-HHO6PH0; Initial Catalog = MusicPlayerDB; Trusted_Connection=True; Encrypt = False";

        public static bool CreateSQLDataBase()
        {
            string sqlExpression = "CREATE DATABASE MusicPlayerDB";

            using(SqlConnection connection = new SqlConnection(connectionStringFromDB))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    command.CommandText = sqlExpression;
                    command.Connection = connection;
                                                    
                    command.ExecuteNonQuery();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public static bool CreateTableForMainList()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();

                    command.CommandText = "CREATE TABLE MainList(Id INT IDENTITY PRIMARY KEY, ListName NVARCHAR(50) UNIQUE)";
                    command.Connection = connection;
                
                    command.ExecuteNonQuery();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public static bool AddToMainList(string nameSongsList)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand($"INSERT INTO MainList VALUES('{nameSongsList}')", connection);

                    return command.ExecuteNonQuery() > 0;
                }
                catch (Exception)
                {
                    return false;
                }

            }
        }

        public static List<string> ReadFromMainList()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand($"SELECT * FROM MainList", connection);

                    SqlDataReader reader = command.ExecuteReader();

                    List<string> list = new List<string>();

                    if(reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            list.Add(reader["ListName"].ToString()??"no list name");
                        }
                    }
                    return list;
                }
                catch (Exception)
                {
                    return new List<string>();
                }

            }
        }

        public static bool DeleteSongsListFromMainList(string nameSongsList)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string sqlCommand = $"DELETE FROM MainList WHERE ListName = '{nameSongsList}'";

                    SqlCommand command = new SqlCommand(sqlCommand, connection);

                    return command.ExecuteNonQuery() > 0;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public static bool CreateTableForSongsList(string tableName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();

                    command.CommandText = $"CREATE TABLE {tableName}(Id INT IDENTITY PRIMARY KEY, SongName NVARCHAR(50) UNIQUE)";
                    command.Connection = connection;

                    command.ExecuteNonQuery();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public static bool AddToSongsList(string nameSongsList, string[] songs)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string sqlCommand = $"INSERT INTO {nameSongsList} VALUES";
                    
                    for (int i = 0; i < songs.Length; i++)
                    {
                        sqlCommand += $"('{songs[i]}')";
                        if (i != songs.Length - 1)
                            sqlCommand += ", ";
                    }

                    SqlCommand command = new SqlCommand(sqlCommand, connection);

                    return command.ExecuteNonQuery() > 0;
                }
                catch (Exception)
                {
                    return false;
                }

            }
        }

        public static List<string> ReadFromSongsList(string nameSongsList)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand($"SELECT * FROM {nameSongsList}", connection);

                    SqlDataReader reader = command.ExecuteReader();

                    List<string> list = new List<string>();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            list.Add(reader["SongName"].ToString() ?? "no list name");
                        }
                    }
                    return list;
                }
                catch (Exception)
                {
                    return new List<string>();
                }

            }
        }

        public static bool DeleteSongFromSongsList(string songName,string nameSongsList)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string sqlCommand = $"DELETE FROM {nameSongsList} WHERE SongName = '{songName}'";

                    SqlCommand command = new SqlCommand(sqlCommand, connection);

                    return command.ExecuteNonQuery() > 0;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }        
    }
}
