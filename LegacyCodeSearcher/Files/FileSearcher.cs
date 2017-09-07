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

            result.AddRange(dirs.Select(item => new DirectoryItem(Path.GetFileName(item), item)));


            result.AddRange(files.Select(item => {
                FileInfo itemInfo = new FileInfo(item);
                return new DirectoryItem(itemInfo.Name, item, false, itemInfo.Extension);
                }
            ));

            return result;
        }

        public static DirectoryItem CreateDirectoryItem(String folderPath)
        {
            FileInfo dirItemInfo = new FileInfo(folderPath);
            return new DirectoryItem(Path.GetFileName(folderPath), folderPath, dirItemInfo.Attributes.HasFlag(FileAttributes.Directory), dirItemInfo.Extension);
            
        }

        public static void FlatDirectoryItem(DirectoryItem item, List<DirectoryItem> result)
        {
            result.Add(item);
            foreach(var childItem in item.Childrens)
            {
                FlatDirectoryItem(childItem, result);
            }
        }
    }
}
