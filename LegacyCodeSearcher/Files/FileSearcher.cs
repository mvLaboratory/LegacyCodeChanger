using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;

namespace LegacyCodeSearcher
{
    class FileSearcher
    {
        public static List<DirectoryItem> GetFilesList(String directoryPath)
        {
            String[] dirs = new String[] { };
            String[] files = new String[] { };
            List<DirectoryItem> result = new List<DirectoryItem>();

            try
            {
                dirs = Directory.GetDirectories(directoryPath);
            }
            catch (Exception ex)
            { 
                dirs = new String[] { };
            }

            try
            {
                files = Directory.GetFiles(directoryPath);
            }
            catch (Exception ex)
            {
                files = new String[] { };
            }
            
            result.AddRange(dirs.Select(item => new DirectoryItem(Path.GetFileName(item), item, true)));
            result.AddRange(files.Select(item => new DirectoryItem(Path.GetFileName(item), item, false)));

            return result;
        }

        public static DirectoryItem CreateDirectoryItem(String folderPath)
        {
            return new DirectoryItem(Path.GetFileName(folderPath), folderPath, File.GetAttributes(folderPath).HasFlag(FileAttributes.Directory));
        }
    }
}
