using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer
{
    internal class Data
    {
        public static Form1? form1;
        public static CreatePleyList? formCreatePlayList;

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

                    command.CommandText = "CREATE TABLE MainList(Id INT IDENTITY PRIMARY KEY, ListName NVARCHAR(50) NOT NULL)";
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
                    SqlCommand command = new SqlCommand($"INSERT INTO MainList VALUES({nameSongsList})", connection);

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

                    command.CommandText = $"CREATE TABLE {tableName}(Id INT IDENTITY PRIMARY KEY, SongName NVARCHAR(50) NOT NULL)";
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
    }
}
