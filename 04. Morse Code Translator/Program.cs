using System;
using System.Collections.Generic;
using System.Text;

namespace _04._Morse_Code_Translator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string result = string.Empty;
            string[] morsecode = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, char> translatorMorseCode = 
                new Dictionary<string, char>();

            translatorMorseCode.Add(".-", 'A');
            translatorMorseCode.Add("-...", 'B');
            translatorMorseCode.Add("-.-.", 'C');
            translatorMorseCode.Add("-..", 'D');
            translatorMorseCode.Add(".", 'E');
            translatorMorseCode.Add("..-.", 'F');
            translatorMorseCode.Add("--.", 'G');
            translatorMorseCode.Add("....", 'H');
            translatorMorseCode.Add("..", 'I');
            translatorMorseCode.Add(".---", 'J');
            translatorMorseCode.Add("-.-", 'K');
            translatorMorseCode.Add(".-..", 'L');
            translatorMorseCode.Add("--", 'M');
            translatorMorseCode.Add("-.", 'N');
            translatorMorseCode.Add("---", 'O');
            translatorMorseCode.Add(".--.", 'P');
            translatorMorseCode.Add("--.-", 'Q');
            translatorMorseCode.Add(".-.", 'R');
            translatorMorseCode.Add("...", 'S');
            translatorMorseCode.Add("-", 'T');
            translatorMorseCode.Add("..-", 'U');
            translatorMorseCode.Add("...-", 'V');
            translatorMorseCode.Add(".--", 'W');
            translatorMorseCode.Add("-..-", 'X');
            translatorMorseCode.Add("-.--", 'Y');
            translatorMorseCode.Add("--..", 'Z');
            translatorMorseCode.Add("|", ' ');

            foreach (var item in morsecode)
            {
                result += translatorMorseCode[item];
            }
            Console.WriteLine(result);
        }
    }
}
