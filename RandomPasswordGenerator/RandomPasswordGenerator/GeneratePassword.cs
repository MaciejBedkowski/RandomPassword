using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomPasswordGenerator
{
    public static class GeneratePassword
    {
        public static string signs = "!@#$%&*";
        public static string numbers = "0123456789";
        public static string lowerCharacter = "qwertyuiopasdfghjklzxcvbnm";
        public static string upperCharacter = "QWERTYUIOPASDFGHJKLZXCVBNM";
        public static string charactersToPassword;
        public static string password;
        public static Random rand = new Random();
        public static int losNumber;
        public static string CreatePassword(int passwordLength, bool attachSymbols, bool attachNumbers, bool attachLowercaseCharacters, bool attachUpercaseCharacters)
        {
            if (attachSymbols)
                charactersToPassword += signs;
            if (attachNumbers)
                charactersToPassword += numbers;
            if (attachLowercaseCharacters)
                charactersToPassword += lowerCharacter;
            if (attachUpercaseCharacters)
                charactersToPassword += upperCharacter;

            for(int i = 0; i < passwordLength; i++)
            {
                losNumber = rand.Next(0, charactersToPassword.Length-1);
                password += charactersToPassword[losNumber];
            }

            return password;
        }
    }
}
