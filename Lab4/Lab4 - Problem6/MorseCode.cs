using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4___Problem6
{
    class MorseCode
    {
        // field for Morse code 
        private String[] code = {   ".-", "-...", "-.-.", "-..", ".", "..-.",
                                    "--.", "....", "..", ".---", "-.-", ".-..",
                                    "--", "-.", "---", ".--.", "--.--", ".-.",
                                    "...", "-", "..-", "...-", ".--", "-..-",
                                    "-.--", "--.."  };
        
        // encode text
        public String encode(string text)
        {
            string encodedText = ""; // hold the encoded text
            
            // array that encodes every letter of text
            for (int i = 0; i < text.Length; i++)
            {
                encodedText += code[(int)text[i] - 65];
                encodedText += " ";
            }

            return encodedText;
        }

        // decode text
        public String decode(string encodedText)
        {
            string text = ""; // hold the decoded text

            // array that decodes every letter of encoded text
            for (int i = 0; i < encodedText.Length; ++i)
            {
                if (encodedText[i] == ' ')
                {
                    ++i;
                }
                else
                {
                    int p = i;
                    string letterToDecode = "";

                    while (p < encodedText.Length && encodedText[p] != ' ')
                    {
                        letterToDecode += encodedText[i];
                        ++p;
                    }

                    for (int k = 0; k < code.Length; k++)
                    {
                        if (letterToDecode == code[k])
                        {
                            text += (char)(k + 65);
                            break;
                        }
                    }

                    i = p;
                }
            }

            return text;
        }
    }
}
