using System;

namespace PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

             bool isTrue = ValidLenght(password) &&
                         ValidateLetterDigits(password)&&
                         PasswordHaTwoDigits(password);

            if (isTrue)
            {
                Console.WriteLine("Password is valid");
            }
            else
            {
                if (!ValidLenght(password))
                {
                    Console.WriteLine("Password must be between 6 and 10 characters");
                }
                if (!ValidateLetterDigits(password))
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                }
                if (!PasswordHaTwoDigits(password))
                {
                    Console.WriteLine("Password must have at least 2 digits");
                }
            }
        }

        private static bool PasswordHaTwoDigits(string password)
        {
            int count = 0;
            foreach (char c in password)
            {
                if (char.IsDigit(c))
                {
                    count++;
                }
            }
            if (count>=2)
            {
                return true;
            }
            return false;
        }

        private static bool ValidateLetterDigits(string password)
        {
            foreach (char c in password)
            {
                if (!char.IsLetterOrDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        private static bool ValidLenght(string password)
        {
            if (password.Length>=6&&password.Length<=10)
            {
                bool isTrue=true;
                return isTrue;
            }
            return false;
        }
    }
   
}
