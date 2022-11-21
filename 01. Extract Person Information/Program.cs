using System;
using System.Text;

namespace _01._Extract_Person_Information
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            int n=int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string text = Console.ReadLine();//Here is a name @George|
                                                 //and an age #18*


                int indexnameStart = text.IndexOf('@');
                int indexNameEnd = text.IndexOf('|');

                string name=text.Substring(indexnameStart+1, indexNameEnd-indexnameStart-1);
                int indexAgeStart = text.IndexOf('#');
                int indexAgeEnd = text.IndexOf('*');
                string age = text.Substring(indexAgeStart + 1, indexAgeEnd - indexAgeStart- 1);
                Console.WriteLine($"{name} is {age} years old.");
            }




        }
    }
}
