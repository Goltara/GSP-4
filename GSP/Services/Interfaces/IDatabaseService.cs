namespace GSP.Services.Interfaces
{
    using Models;

    public interface IDatabaseService
    {
        void Create();

        void Connect();

        void Add(Password pass);

        void Delete(Password pass);

        void Update(Password pass);

        void All();

        Password FindByDomain(string domain);

        Password FindById(int id);

        Password FindByUsername(string username);

        void Backup();

        void Restore();
    }
}
