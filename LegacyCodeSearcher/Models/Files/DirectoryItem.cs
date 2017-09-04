using System;
using System.Collections.Generic;

namespace LegacyCodeSearcher
{
    class DirectoryItem
    {
        public String Name { get; set; }
        public String FullPath { get; set; }
        public bool IsFolder { get; set; }
        public List<DirectoryItem> Childrens { get; }

        public DirectoryItem(String name, String fullPath, bool isFolder)
        {
            Name = name;
            FullPath = fullPath;
            IsFolder = isFolder;

            if (FullPath == null)
            {
                throw new ArgumentException("FullPath");
            }
            Childrens = findChildrens();
        }

        public DirectoryItem(String name, String fullPath) : this(name, fullPath, false)
        {          
        }

        public DirectoryItem() : this("", "")
        {
        }

        private List<DirectoryItem> findChildrens()
        {
            return FileSearcher.GetFilesList(FullPath);
        }
    }
}
