namespace GSP.Services
{
    using System.Collections.Generic;
    using System.IO;
    using System.Data.SQLite;
    
    using Models;
    using Interfaces;

    public class DatabaseService : IDatabaseService
    {
        private const string DATABASE_NAME = "GSP.sqlite";

        public void Add(Password pass, SQLiteConnection con)
        {
            string sql = "insert into Password (Title, Level, Username, Pass) values ('" + pass.Place + "', '" + pass.Level + "', '" + pass.Username + "', '" + pass.Password + "')";
            SQLiteCommand addNewPassword = new SQLiteCommand(sql, con);
            addNewPassword.ExecuteNonQuery();
            con.Close();
        }

        public void Delete(Password pass, SQLiteConnection con)
        {

        }

        public void Update(Password pass, SQLiteConnection con)
        {

        }

        public HashSet<Password> All(SQLiteConnection con)
        {
            var allPasswords = new HashSet<Password>();

            return allPasswords;
        }

        public Password FindByDomain(string domain, SQLiteConnection con)
        {
            Password pass = new Password();

            return pass;
        }

        public Password FindById(int id, SQLiteConnection con)
        {
            Password pass = new Password();

            return pass;
        }

        public Password FindByUsername(string username, SQLiteConnection con)
        {
            Password pass = new Password();

            return pass;
        }

        public void Backup()
        {

        }

        public void Restore()
        {

        }

        public void Create()
        {
            if (!File.Exists(DATABASE_NAME))
            {
                SQLiteConnection.CreateFile(DATABASE_NAME);
                SQLiteConnection conn = new SQLiteConnection("Data Source=" + DATABASE_NAME + ";Version=3");
                conn.Open();

                string sql = "CREATE TABLE Passwords (Id INTEGER PRIMARY KEY ASC, Title VARCHAR(50), Level VARCHAR(10), Username VARCHAR(30), Pass VARCHAR(30))";
                SQLiteCommand createPasswordsTable = new SQLiteCommand(sql, conn);
                createPasswordsTable.ExecuteNonQuery();

                sql = "CREATE TABLE Users (Id INTEGER PRIMARY KEY ASC, Username VARCHAR(30), Password VARCHAR(100), Email VARCHAR(30))";
                SQLiteCommand createUsersTable = new SQLiteCommand(sql, conn);
                createUsersTable.ExecuteNonQuery();

                conn.Close();
            }
        }

        public void Connect(string db)
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=" + db + ";Version=3");
            conn.Open();
        }
    }
}
