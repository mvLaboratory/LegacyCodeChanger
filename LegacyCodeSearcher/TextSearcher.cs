using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegacyCodeSearcher
{
    class TextSearcher
    {
        public List<String> doSearch(String folder, String serchedText) 
        {
            List<String> result = new List<string>();
            List<String> files = new List<string>();

            FileSearcher fileSearcher = new FileSearcher();
            fileSearcher.DirectoryPath = folder;
            files = fileSearcher.GetFilesList();


            return result;
        }
    }
}
