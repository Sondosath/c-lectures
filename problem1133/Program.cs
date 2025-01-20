using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem1133
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(vowels("Prediction"));
        }
        static string vowels(string stat)
        {
            int numOfVow = 0;
            for (int i = 0; i < stat.Length; i++) {
                if (stat[i] =='a' || stat[i] == 'e' || stat[i] == 'i' || stat[i] == 'o' || stat[i] == 'u' )
                {
                    numOfVow++;
                }
            }
            return numOfVow.ToString(); 

        }
    }
}
