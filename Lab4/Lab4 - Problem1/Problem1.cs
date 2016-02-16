using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4___Problem1
{
    class Problem1
    {
        const int SHIFT_KEY = 3; // const for shift key

        static void Main(string[] args)
        {
            string textToCipher = "String"; // word tha will be ciphered
            char[] textToCipherArray = textToCipher.ToCharArray();
            
            Console.WriteLine(Cipher(ref textToCipherArray)); 
            Console.WriteLine(Decipher(ref textToCipherArray));            
        }

        // cipher the word
        static string Cipher(ref char[] textToCipherArray)
        {
            string cipheredText = ""; // variable that holds the ciphered word

            for (int i = 0; i < textToCipherArray.Length; i++)
            {
                // if ciphered is no longer letter
                if ((char)((int)textToCipherArray[i] + SHIFT_KEY) >= 'A' &&
                    (char)((int)textToCipherArray[i] + SHIFT_KEY) <= 'Z' ||
                    (char)((int)textToCipherArray[i] + SHIFT_KEY) >= 'a' &&
                    (char)((int)textToCipherArray[i] + SHIFT_KEY) <= 'z')
                {
                    textToCipherArray[i] = (char)((int)textToCipherArray[i] + SHIFT_KEY);
                }
                else
                {
                    textToCipherArray[i] = (char)((int)textToCipherArray[i] + SHIFT_KEY - 26);
                }
                cipheredText += textToCipherArray[i];
            }

            return cipheredText;
        }

        // method that decipher the word
        static string Decipher(ref char[] cipheredTextArray)
        {
            string decipheredText = "";

            // if deciphered letter is no longer letter
            for (int i = 0; i < cipheredTextArray.Length; i++)
            {
                if ((char)((int)cipheredTextArray[i] - SHIFT_KEY) >= 'A' &&
                    (char)((int)cipheredTextArray[i] - SHIFT_KEY) <= 'Z' ||
                    (char)((int)cipheredTextArray[i] - SHIFT_KEY) >= 'a' &&
                    (char)((int)cipheredTextArray[i] - SHIFT_KEY) <= 'z')
                {
                    decipheredText += (char)((int)cipheredTextArray[i] - SHIFT_KEY);
                }
                else
                {
                    decipheredText += (char)((int)cipheredTextArray[i] - SHIFT_KEY + 26);
                }
            }

            return decipheredText;
        }
    }
}
