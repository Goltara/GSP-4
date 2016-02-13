namespace GSP.Services
{
    using System;

    using DataTypes.Enumerations;
    using Interfaces;
    using System.Threading;

    public class PasswordGeneratorService : IPasswordGeneratorService
    {
        public string GenerateNewRandomPassword(byte length)
        {
            string allSymbols = @"\|zZxXcCvVbBnNmM,<.>/?\|'"":;lL kKjJhHgGfFdDsSaAqQwWeErRtTyYuUiIoOpP[{]}=+-_0)9(8*7&6^5%4$3#2@1!`~";

            Random rnd = new Random();
            char[] buffer = new char[length];

            for (int i = 0; i < length; i++)
            {
                buffer[i] = allSymbols[rnd.Next(0, allSymbols.Length)];
            }

            return new string(buffer);
        }
    }
}
