using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webscraper
{
    class Program
    {
        static void Main(string[] args)
        {
            var myList = new List<List<string>>();
            for (int i = 1; i < 4; i++)
            {
                myList.Add(HistoryScraper.GetFiguresList("https://www.thefamouspeople.com/historical-personalities.php?page=" + i.ToString()).Result);
            }

            foreach(List<string> list in myList)
            {
                foreach(string s in list)
                {
                    Console.WriteLine(s);
                }
            }
        }
    }
}
