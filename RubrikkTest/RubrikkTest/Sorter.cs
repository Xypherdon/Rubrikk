using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubrikkTest
{
    class Sorter
    {
        private List<int> numbers = new List<int>();
        private List<string> stringNumbers = new List<string>();
 
        public void ReadFromFile(string file)
        {
            string text;

            try
            {
                text = System.IO.File.ReadAllText(@file);
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }

            string[] splitText = text.Split(new string[] { ", " },StringSplitOptions.None);
            
            foreach(string number in splitText)
            {
                this.numbers.Add(Int32.Parse(number));
                this.stringNumbers.Add(number);
            }
           
        }

        public List<int> NumberSort(bool order)
        {
            List<int> sortedList = this.numbers;
            sortedList.Sort();
            if (order)
            {
                return sortedList;
            }
            else
            {
                sortedList.Reverse();
                return sortedList;
            }
        }

        public List<string> StringSort(bool order)
        {
            List<string> sortedList = this.stringNumbers;
            sortedList.Sort();
            if (order)
            {
                return sortedList;
            }
            else
            {
                sortedList.Reverse();
                return sortedList;
            }
        }

        public List<int> HybridSort(bool order)
        {
            List<int> even = new List<int>();
            List<int> odd = new List<int>();

            foreach(int number in this.numbers)
            {
                if (number % 2 == 0)
                {
                    even.Add(number);
                }
                else
                {
                    odd.Add(number);
                }
            }

            even.Sort();
            odd.Sort();

            if (order)
            {
                even.Reverse();
                even.AddRange(odd);
                return even;
            }
            else
            {
                odd.Reverse();
                odd.AddRange(even);
                return odd;
            }
        }
    }
}
