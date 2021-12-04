using System;
using System.Linq;

namespace PasswordValidator
{
    class Program
    {
        static void passwordValidator(string password)
        {
            if (password.Length >= 6 && password.Length <= 10 && password.Count(char.IsDigit) >= 2 && password.All(char.IsLetterOrDigit))
            {
                Console.WriteLine("Password is valid");
            }

            if (!(password.Length >= 6 && password.Length <= 10))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!(password.All(char.IsLetterOrDigit)))
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (password.Count(char.IsDigit) < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
        }
        static void Main(string[] args)
        {
            passwordValidator(Console.ReadLine());
        }
    }
}



