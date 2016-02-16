using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Problem3
{
    class Program
    {
        public static void Main(string[] args)
        {
          
            //declaration
            int numberForEncryption = 0; //declaration of the phoneNumber
            int fourthDigit = 0; //declaration of fourth digit
            int thirdDigit = 0;  //declaration of third digit
            int secondDigit = 0; //declaration of second digit
            int firstDigit = 0;  //declaration of first digit 
            int encryptedNumber = 0; //declaration of encrypted integer
            int decryptedNumber = 0; //declaration of decrypted number

            Console.Write("Insert number for encryption: ");
            numberForEncryption = int.Parse(Console.ReadLine()); // converts the phone number from string to integer

            encrypt(numberForEncryption, firstDigit, secondDigit, thirdDigit, fourthDigit, ref encryptedNumber);
            decrypt(encryptedNumber, firstDigit, secondDigit, thirdDigit, fourthDigit, ref decryptedNumber);
        }


        //method for encryption of the phone number
        public static void encrypt(int numberForEncryption, int firstDigit, int secondDigit, int thirdDigit, int fourthDigit, ref int encryptedInteger)
        {
            // case when the number starts with three zeros
            if (numberForEncryption >= 0 && numberForEncryption <= 9)
            {
                //inicialization of digits
                fourthDigit = numberForEncryption; 
                thirdDigit = 0; 
                secondDigit = 0;
                firstDigit = 0; 
             }

            //case when the number startrs with two zeros
            else if (numberForEncryption >= 10 && numberForEncryption <= 99)
            {
                //inicialization of digits
                fourthDigit = numberForEncryption % 10; 
                thirdDigit = numberForEncryption / 10;
                secondDigit = 0;
                firstDigit = 0;            
            }

            //case when the number starts with a zero
            else if (numberForEncryption >= 100 && numberForEncryption <= 999)
            {
                //inicialization of digits
                fourthDigit = numberForEncryption % 10;       
                thirdDigit = (numberForEncryption / 10) % 10;
                secondDigit = numberForEncryption / 100;
                firstDigit = 0;
            }

            //case when the number is bigger than 999
            else
            {
                //inicialization of digits
                fourthDigit = numberForEncryption % 10;          
                thirdDigit = (numberForEncryption / 10) % 10;    
                secondDigit = (numberForEncryption / 100) % 10;  
                firstDigit = numberForEncryption / 1000;         
            }

            //encypt digits
            fourthDigit = (fourthDigit + 7) % 10;
            thirdDigit = (thirdDigit + 7) % 10;
            secondDigit = (secondDigit + 7) % 10;
            firstDigit = (firstDigit + 7) % 10;

            //create encrypted integer
            encryptedInteger = thirdDigit * 1000 + fourthDigit * 100 + firstDigit * 10 + secondDigit;

            Console.Write("Encrypted number:");
            Console.WriteLine(encryptedInteger);
        }

        static void decrypt(int encryptedNumber, int firstDigit, int secondDigit, int thirdDigit, int fourthDigit, ref int decryptedNumber)
        {
            //arr as code for decryption
            int[] arr = { 3, 4, 5, 6, 7, 8, 9, 0, 1, 2 };

            // case when the number starts with three zeros
            if (encryptedNumber >= 0 && encryptedNumber <= 9)
            {
                //inicalization of digits
                fourthDigit = encryptedNumber;
                
                //encrypt number
                fourthDigit = decryptDigit(fourthDigit, arr);       
            }

            //case when the number startrs with two zeros
            else if (encryptedNumber >= 10 && encryptedNumber <= 99)
            {
                //inicialization of digits
                fourthDigit = encryptedNumber % 10; 
                thirdDigit = encryptedNumber / 10;  
                
       
            }

            //case when the number starts with a zero
            else if (encryptedNumber >= 100 && encryptedNumber <= 999)
            {
                //inicialization of digits
                fourthDigit = encryptedNumber % 10;       
                thirdDigit = (encryptedNumber / 10) % 10; 
                secondDigit = encryptedNumber / 100;      
                firstDigit = 0;       
            }

            //case when the number is bigger than 999
            else
            {
                //inicialization of digits
                fourthDigit = encryptedNumber % 10;          
                thirdDigit = (encryptedNumber / 10) % 10;    
                secondDigit = (encryptedNumber / 100) % 10;  
                firstDigit = encryptedNumber / 1000;         
            }

            //encypt digits
            fourthDigit = decryptDigit(fourthDigit, arr);
            thirdDigit = decryptDigit(thirdDigit, arr);
            secondDigit = decryptDigit(secondDigit, arr);
            firstDigit = decryptDigit(firstDigit, arr);

            //create encrypted integer
            decryptedNumber = thirdDigit * 1000 + fourthDigit * 100 + firstDigit * 10 + secondDigit;

            Console.Write("Decrypted number:");
            Console.WriteLine(decryptedNumber);
        }

        static int decryptDigit(int digit, int[] arr)
        {
            switch (digit)
            {
                case 0: return arr[0];
                case 1: return arr[1];
                case 2: return arr[2];
                case 3: return arr[3];
                case 4: return arr[4];
                case 5: return arr[5];
                case 6: return arr[6];
                case 7: return arr[7];
                case 8: return arr[8];
                case 9: return arr[9];
            }
            return 0;
        }
    }
}
