using System;
using System.Collections.Generic;

namespace LegacyCodeSearcher
{
    class FileContentModel
    {
        public DirectoryItem FileItem { get; set; }

        public FileContentModel(DirectoryItem fileItem)
        {
            if (fileItem == null || fileItem.IsFolder)
            {
                throw new ArgumentException("fileItem");
            }

            _initialFileLines = new List<String>();
        }

        public void addLine(String fileLine)
        {
            _initialFileLines.Add(fileLine);
        }

        public List<String> _initialFileLines;
    }
}
