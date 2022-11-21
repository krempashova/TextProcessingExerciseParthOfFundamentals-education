using System;

namespace _02._Ascii_Sumator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            char start = char.Parse(Console.ReadLine());
            char ends = char.Parse(Console.ReadLine());
            string text = Console.ReadLine();
            for (int i = 0; i < text.Length; i++)
            {

                if (text[i]>start && text[i]<ends)
                {
                    sum += text[i];
                }
            }


            Console.WriteLine(sum);
            
        }
    }
}
