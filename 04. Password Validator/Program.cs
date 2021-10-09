using System;

namespace _04._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            bool isPasswordLength = ValidatePasswordLength(password);
            bool isPasswContainsValidSymbols = ValidatePasswordText(password);
            bool isPasswordMoreWithTwoDigits = ValidatePasswordDigits(password);
            if (!isPasswordLength)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!isPasswContainsValidSymbols)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!isPasswordMoreWithTwoDigits)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (isPasswordLength && isPasswContainsValidSymbols && isPasswordMoreWithTwoDigits)
            {
                Console.WriteLine("Password is valid");
            }
        }
        //It should contain 6 – 10 characters (inclusive)
        //It should contain only of letters and digits
        //It should contain at least 2 digits
        //"Password must be between 6 and 10 characters"
        //"Password must consist only of letters and digits"
        //"Password must have at least 2 digits"
        static bool ValidatePasswordLength(string text)//How to check if the text contains 6 to 10 characters(inclusice!)

        {
            return text.Length >= 6 && text.Length <= 10;

        }
        static bool ValidatePasswordText(string text)//How to check if the password contain only letters or digits
        {
            foreach (char character in text)
            {
                
                char.IsLetterOrDigit(character);
                if (!char.IsLetterOrDigit(character))
                {
                    return false;
                }
            }
            return true;
        }
        static bool ValidatePasswordDigits(string text)//How to check how many digits the string has
        {
            int countDigit = 0;
            foreach (var character in text)
            {
                //if (char.IsDigit(character)) - the same 
                if (character >= 48 && character <= 57)
                {
                    countDigit++;
                }
            }
            //check if digitCount has more than 2 digits
            return countDigit >= 2;
                
        }



    }
}
