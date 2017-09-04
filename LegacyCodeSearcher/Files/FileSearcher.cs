using System;
using System.Collections.Generic;
using System.IO;

namespace LegacyCodeSearcher
{
    class FileSearcher
    {
        public String DirectoryPath { get; set; }

        public List<String> GetFilesList()
        {
            String[] dirs = new String[] { };
            List<String> result = new List<String>();

            try
            {
                dirs = Directory .GetDirectories(DirectoryPath);
            }
            catch (Exception ex)
            { 
                dirs = new String[] { };
            }

            var files = Directory.GetFiles(DirectoryPath);


            result.AddRange(dirs);
            return result;
        }
    }
}
