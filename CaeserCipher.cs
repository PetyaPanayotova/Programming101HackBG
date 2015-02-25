using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeaserCipher
{
    class CaeserCipher
    {
        static string caeser_encrypt(string str, int n)
        {
            char[] bufferArray = str.ToCharArray();
            for (int i = 0; i < bufferArray.Length; i++)
            {
                char letter = bufferArray[i];
                if (Char.IsLetter(letter) == true)
                {
                    bool isUpper = Char.IsUpper(letter);
                    if (isUpper == true)
                    {
                        letter = Char.ToLower(letter);
                    }
                    letter = (char)(letter + n);
                    if (letter < 'a')
                    {
                        letter = (char)(letter + 26);
                    }
                    else if (letter > 'z')
                    {
                        letter = (char)(letter - 26);
                    }
                    if (isUpper == true)
                    {
                        letter = Char.ToUpper(letter);
                    }
                    bufferArray[i] = letter;
                }
                else
                {
                    Console.WriteLine("The data is unvalid. You should enter only letters.");
                }
            }
            return new string(bufferArray);
        }
        static void Main(string[] args)
        {
            string example = "abc";
            int a = 1;
            Console.WriteLine(caeser_encrypt(example, a));
            string secondExample = "ABC";
            int b = 1;
            Console.WriteLine(caeser_encrypt(secondExample, b));
            int c = 2;
            Console.WriteLine(caeser_encrypt(example, c));
            string thirdExample = "aaa";
            int d = 7;
            Console.WriteLine(caeser_encrypt(thirdExample, d));
            string forthExample = "xyz";
            Console.WriteLine(caeser_encrypt(forthExample, a));
        }
    }
}
