using System;
using System.IO;

namespace LegacyCodeSearcher
{
    class FileReader
    {
        public FileContentModel readFile(DirectoryItem fileItem)
        {
            if (fileItem == null || fileItem.IsFolder)
            {
                throw new ArgumentException("fileItem");
            }

            FileContentModel fileModel = new FileContentModel(fileItem);
            using (StreamReader sr = new StreamReader(fileItem.FullPath))
            {
                String line;
                while ((line = sr.ReadLine()) != null)
                {
                    fileModel.addLine(line);
                }
            }
            return fileModel;
        }
    }
}
