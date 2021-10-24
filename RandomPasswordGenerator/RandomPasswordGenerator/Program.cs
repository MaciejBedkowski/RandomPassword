using System;

namespace RandomPasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool attachSymbols = false;
            bool attachNumbers = false;
            bool attachLowercaseCharacters = false;
            bool attachUpercaseCharacters = false;
            string userInput;
            string password;
            int passwordLength;

            Console.WriteLine("Enter password length:");
            userInput = Console.ReadLine();

            try
            {
                passwordLength = Int32.Parse(userInput);
            }
            catch(Exception)
            {
                throw new Exception ("Invalid input");
            }

            // INCLUDE SYMBOLS (!,@,#,$,%,&,*)
            Console.WriteLine("Whether to include special characters in the password Y/N:");
            userInput = Console.ReadLine().ToUpper();
            switch(userInput)
            {
                case "Y":
                    attachSymbols = true;
                    break;
                case "N":
                    break;
                default:
                    throw new Exception("Invalid input");
                    break;
            }

            // INCLUDE NUMBERS (0,1,2,3,4,5,6,7,8,9)
            Console.WriteLine("Whether to include numbers in the password Y/N:");
            userInput = Console.ReadLine().ToUpper();
            switch (userInput)
            {
                case "Y":
                    attachNumbers = true;
                    break;
                case "N":
                    break;
                default:
                    throw new Exception("Invalid input");
                    break;
            }

            // INCLUDE LOWERCASE CHARACTERS (a,b,c,d,e)
            Console.WriteLine("Whether to include lowercase characters in the password Y/N:");
            userInput = Console.ReadLine().ToUpper();
            switch (userInput)
            {
                case "Y":
                    attachLowercaseCharacters = true;
                    break;
                case "N":
                    break;
                default:
                    throw new Exception("Invalid input");
                    break;
            }

            // INCLUDE UPERCASE CHARACTERS (A,B,C,D,E)
            Console.WriteLine("Whether to include lowercase characters in the password Y/N:");
            userInput = Console.ReadLine().ToUpper();
            switch (userInput)
            {
                case "Y":
                    attachUpercaseCharacters = true;
                    break;
                case "N":
                    break;      
                default:
                    throw new Exception("Invalid input");
                    break;
            }

            password = GeneratePassword.CreatePassword(passwordLength, attachSymbols, attachNumbers, attachLowercaseCharacters, attachUpercaseCharacters);
            Console.WriteLine($"Youre password:{password}");

            Version version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version ;
            
            string displayableVersion = $"{version}";
            Console.WriteLine($"Actual version:{displayableVersion}");
        }
    }
}
