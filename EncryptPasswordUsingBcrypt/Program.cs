using System;
using BCrypt.Net;
namespace EncryptPasswordUsingBcrypt
{
    class Program
    {
        static void Main(string[] args)
        {
            var plainPassword = Console.ReadLine();

            var EncryptedPassword = BCrypt.Net.BCrypt.HashPassword(plainPassword);

            Console.WriteLine("Encrypted password is : {0}",EncryptedPassword);

            var isValidPassword = BCrypt.Net.BCrypt.Verify("invalidPassword", EncryptedPassword);

            Console.WriteLine(isValidPassword);
        }
    }
}
