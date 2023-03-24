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
        public static List<SongList> MainList = new List<SongList>();
        public static SoundPlayer player = new SoundPlayer();
        //Encrypt = False
        static string connectionStringFromDB = @"Data Source = DESKTOP-K60TA32\SQLEXPRESS; Initial Catalog = master; Trusted_Connection=True; Encrypt = False";
        static string connectionString = @"Data Source = DESKTOP-K60TA32\SQLEXPRESS; Initial Catalog = MusicPlayerDB; Trusted_Connection=True; Encrypt = False";

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

                    command.CommandText = "CREATE TABLE MainList(Id INT IDENTITY PRIMARY KEY, ListName NVARCHAR(100) UNIQUE)";
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

                    command.CommandText = $"CREATE TABLE {tableName}(Id INT IDENTITY PRIMARY KEY, SongName NVARCHAR(1000) UNIQUE)";
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

        public static bool AddToSongsList(string nameSongsList, List<string> songs)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string sqlCommand = $"INSERT INTO {nameSongsList} VALUES";
                    
                    for (int i = 0; i < songs.Count; i++)
                    {
                        sqlCommand += $"('{songs[i]}')";
                        if (i != songs.Count - 1)
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

        public static SongList ReadFromSongsList(string nameSongsList)
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
                    return new SongList(nameSongsList, list);
                }
                catch (Exception)
                {
                    return new SongList("", new List<string>());
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

        public static void WriteDataToDB()
        {
            CreateSQLDataBase();
            CreateTableForMainList();
            foreach (var item in MainList)
            {
                AddToMainList(item.Name);
                CreateTableForSongsList(item.Name);
                AddToSongsList(item.Name, item.Songs);
            }
        }

        public static void ReadDataFromDB()
        {
            List<string> list = ReadFromMainList();
            MainList = new List<SongList>();
            if(list?.Count > 0)
            {
                foreach (var item in list)
                {
                    SongList songList = ReadFromSongsList(item);
                    if (!MainList.Contains(songList))
                        MainList.Add(songList);
                }
            }
        }
    }
}
