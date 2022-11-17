using System;
namespace Review
{
    class Program
    {
        static void Main(string[] args)
        {
            bool passUpper = false;
            bool passNumb = false;
            bool passLow = false;
            Console.Write("Please enter your password: ");
            string password = Console.ReadLine();
            int len = password.Length; //gets length of password
            for (int i = 0; i < len; i++)
            {
                char c = password[i];//uses the letter in password as a character to check for uppercase, numbers or lowercase
                bool upper = char.IsUpper(c); // checks each character for uppercase, lowercase and number
                bool lower = char.IsLower(c);
                bool number = char.IsNumber(c);
                if (upper == true)
                {
                    passUpper = true; //returns each qualifier for the password as true if the character is one of those
                }
                if (number == true)
                {
                    passNumb = true;
                }
                if (lower == true)
                { 
                    passLow = true;
                }          
                if ((passLow == true) && (passNumb == true) && (passUpper == true)) //if all conditions are already met it will end the program since its pointless checking the rest
                {
                    Console.WriteLine("Your password passes the check");
                    goto End;
                }
            }
            if ((passUpper == false) || (passNumb || false) || passLow == false) // if any of the conditions have failed it will tell the user what the password needs to pass
            {
                Console.WriteLine("Your password has failed, it needs needs:");
            }
            if (passUpper == false)
            {
                Console.Write(" an uppercase letter");
            }
            if (passLow == false)
            {
                Console.Write(" a lowercase letter");
            }
            if (passNumb == false)
            {
                Console.Write(" a number");
            }
        End:;
            
        }
    }
}
