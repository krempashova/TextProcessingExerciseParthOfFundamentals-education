using System;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace _03._Treasure_Finder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            var sb = new StringBuilder();
            int[] Key = Console.ReadLine()//1 2 1 3
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            string message;
            while((message= Console.ReadLine()) != "find")
            {
                counter = 0;
                
                string cryptedmessage = message;//ikegfpjkchudbcgcj
                for (int i=0;i<cryptedmessage.Length;i++)
                {
                    int valueChar = cryptedmessage[i];   
                        int symbol = Key[counter];
                        valueChar -= symbol;
                        char encryptdmessage = Convert.ToChar(valueChar);

                        sb.Append(encryptdmessage);
                        counter++;
                        if(counter>Key.Length-1)
                        {

                        counter = 0;

                        }
                        
                    }

                int indexstartresure = sb.ToString().IndexOf('&');
                int indexendtresure = sb.ToString().LastIndexOf('&');
                int indexstartcordination = sb.ToString().IndexOf('<');
                int indexendcordination = sb.ToString().LastIndexOf('>');
                if(indexstartresure==-1|| indexendtresure==-1
                    ||indexstartcordination==-1||indexendcordination==-1)
                {
                    break;
                }
                else
                {
                    string tresure = sb.ToString().Substring(indexstartresure + 1, indexendtresure -indexstartresure-1);
                    string coordinates = sb.ToString().Substring(indexstartcordination + 1, indexendcordination-indexstartcordination - 1);
                    Console.WriteLine($"Found {tresure} at {coordinates}");
                    sb.Clear();
                }

                }
                
            }
        }
    }

