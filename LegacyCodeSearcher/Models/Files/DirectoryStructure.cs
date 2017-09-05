using System;
using System.Linq;
using System.Collections.Generic;

namespace LegacyCodeSearcher
{
    class DirectoryStructure
    {
        public String InitialPath { get; set; }
        public DirectoryItem Item { get; private set; }

        public DirectoryStructure(String initialPath)
        {
            InitialPath = initialPath;

            if (InitialPath == null)
            {
                throw new ArgumentException("initialPath");
            }

            buildStructure();
        }

        private void buildStructure()
        {
            DirectoryItem initialItem = FileSearcher.CreateDirectoryItem(InitialPath);
            Item = initialItem;
        }

        public override String ToString() {
            return InitialPath;
        }
    }
}
