using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegacyCodeSearcher
{
    class TextSearcher
    {
        public List<String> doSearch(String folder, String serchedText) 
        {
            DirectoryStructure dirStructure = new DirectoryStructure(folder);
            List<String> result = new List<string>();

            String[] textFilesRes = new String[] { ".asp", ".aspx", ".css", ".js", ".cs" };
            var fileList = dirStructure.ItemsList.Where(file => (!file.IsFolder && textFilesRes.Contains(file.Extension)));

            int counter = 0;
            foreach (DirectoryItem file in fileList)
            {

                if (file.FullPath.Contains("common.css"))
                {
                    Console.WriteLine("/n/n ");
                }
                try
                {   // Open the text file using a stream reader.
                    using (StreamReader sr = new StreamReader(file.FullPath))
                    {
                        String line;
                        // Read the stream to a string, and write the string to the console.
                        while ((line = sr.ReadLine()) != null) {
                            if (line.ToLower().Contains(serchedText.ToLower()))
                            {

                                Console.WriteLine("{0} - {1}", file, line.Trim());
                                ++counter;
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("The file could not be read:");
                    Console.WriteLine(e.Message);
                }

                if (counter >= 100) 
                    break;
            }


            return result;
        }
    }
}
