using System;
using System.Linq;

namespace LegacyCodeSearcher
{
    public class Program
    {
        static void Main(string[] args)
        {
            var result = SearchFactory.TextSearcher.doSearch("D:\\mvLab\\edu\\test", "font-face");
            result.ForEach(searchResult => Console.WriteLine(searchResult));
            Console.ReadLine();
        }
    }
}
