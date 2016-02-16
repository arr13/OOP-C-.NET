using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4___Problem6
{
    class Problem6
    {
        static void Main(string[] args)
        {
            string text = "String";
            text = text.ToUpper();

            MorseCode morseCode = new MorseCode();

            string encodedText = morseCode.encode(text);
            Console.WriteLine(encodedText);

            string decodedText = morseCode.decode(encodedText);
            Console.WriteLine(decodedText);
        }
    }
}
