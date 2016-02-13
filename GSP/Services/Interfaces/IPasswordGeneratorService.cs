namespace GSP.Services.Interfaces
{
    public interface IPasswordGeneratorService
    {
        string GenerateNewRandomPassword(byte length);
    }
}
