namespace GSP.Services.Interfaces
{
    using DataTypes.Enumerations;

    public interface IPasswordGeneratorService
    {
        string GenerateNewPassword(PasswordLevelEnum level);
    }
}
