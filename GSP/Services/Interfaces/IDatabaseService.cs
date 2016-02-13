namespace GSP.Services.Interfaces
{
    using System.Collections.Generic;
    using System.Data.SQLite;

    using Models;

    public interface IDatabaseService
    {
        void Create();

        void Connect(string db);

        void Add(Password pass, SQLiteConnection con);

        void Delete(Password pass, SQLiteConnection con);

        void Update(Password pass, SQLiteConnection con);

        HashSet<Password> All(SQLiteConnection con);

        Password FindByDomain(string domain, SQLiteConnection con);

        Password FindById(int id, SQLiteConnection con);

        Password FindByUsername(string username, SQLiteConnection con);

        void Backup(SQLiteConnection con);

        void Restore();
    }
}
