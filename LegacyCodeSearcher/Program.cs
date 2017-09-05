using System;
using System.Linq;

namespace LegacyCodeSearcher
{
    public class Program
    {
        static void Main(string[] args)
        {
            var result = SearchFactory.TextSearcher.doSearch("E:\\PH\\PHApplication-master\\Source\\PHDevelopment", "font-family");
            result.ForEach(searchResult => Console.WriteLine(searchResult));

            Console.WriteLine("Press eny keu to continue...");
            Console.ReadKey();
        }
    }
}
