using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubrikkTest
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                System.Console.WriteLine("Please enter a command-line argument.");
            }

            string file = args[0];

            bool order;
            if (args[1] == "asc")
            {
                order = true;
            } else if (args[1] == "desc")
            {
                order = false;
            }
            else
            {
                System.Console.WriteLine("Please enter a valid order");
                return;
            }

            string type = args[2];

            Sorter sorter = new Sorter();
            sorter.ReadFromFile(file);

            string finalString="";

            if (type == "number")
            {
                List<int> sortedNumbers = sorter.NumberSort(order);
                foreach(int number in sortedNumbers)
                {
                    finalString = finalString + number.ToString() + " ";
                }
            }else if (type == "string")
            {
                List<string> sortedNumbers = sorter.StringSort(order);
                foreach(string number in sortedNumbers)
                {
                    finalString = finalString + number + " ";
                }
            }else if (type == "hybrid")
            {
                List<int> sortedNumbers = sorter.HybridSort(order);
                foreach(int number in sortedNumbers)
                {
                    finalString = finalString + number.ToString() + " ";
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid type");
                return;
            }


            Console.WriteLine(finalString);

        }
    }
}
