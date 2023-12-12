﻿using System.Data.SQLite;

namespace OpenSesame
{
    internal class DB
    {
        public DB()
        {
            // Creates the database if it doesn't exist
            if (!File.Exists("./Data.sqlite3"))
            {
                SQLiteConnection.CreateFile("Data.sqlite3");
                using (SQLiteConnection connection = new SQLiteConnection("Data Source = Data.sqlite3"))
                {
                    // Creates the table
                    connection.Open();
                    using (SQLiteCommand command = new SQLiteCommand("CREATE TABLE 'UserData'('Service' TEXT NOT NULL, 'Username' TEXT NOT NULL, 'Password' TEXT NOT NULL, 'URL' TEXT)", connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
        }
       
        public int count()
        {
            // Counts the number of entries in the database
            int entries = 0;
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection("Data Source = Data.sqlite3"))
                {
                    connection.Open();
                    using (SQLiteCommand command = new SQLiteCommand("SELECT * FROM UserData", connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                // Counts the number of entries
                                while (reader.Read())
                                {
                                    entries++;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return entries;
        }

        public string[] Load()
        {
            int entries = count();
            string[] arraytoreturn = new string[entries];
            try
            {
                int index = 0;

                using (SQLiteConnection connection = new SQLiteConnection("Data Source = Data.sqlite3"))
                {
                    connection.Open();
                    using (SQLiteCommand command = new SQLiteCommand($"Select * From Userdata ", connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Adds the of each entry service to the array
                                arraytoreturn[index] = reader["Service"].ToString();
                                index++;
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return arraytoreturn;
        }
    }
}