using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonlInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // these variables are for the input of someone's personal information
            string fullName = "John Smith ";
            string birthday = "8/15/1978 ";
            string workNumber = "000-111-0101 ";
            string cellNumber = "000-111-0189 ";
            // This is what we want the computer to do, write the information
            Console.WriteLine(fullName);
            Console.WriteLine(birthday);
            Console.WriteLine("work " + workNumber);
            Console.WriteLine("cell " + cellNumber);
            // This tells the computer to produce the outcome of what was written
            Console.ReadLine();
        }
    }
}
