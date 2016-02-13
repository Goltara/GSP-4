namespace GSP.Models
{
    using DataTypes.Enumerations;

    public class Password
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public PasswordLevelEnum Level { get; set; }

        public Domain Place { get; set; }
    }
}
