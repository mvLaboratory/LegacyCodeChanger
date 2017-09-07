using System;
using System.Linq;
using System.Collections.Generic;

namespace LegacyCodeSearcher
{
    class DirectoryStructure
    {
        public String InitialPath { get; set; }
        public DirectoryItem Item { get; private set; }
        public List<DirectoryItem> ItemsList {
            get {
                if (_itemsList == null)
                {
                    _itemsList = new List<DirectoryItem>();
                }
                return _itemsList;
            }
        }

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

            FileSearcher.FlatDirectoryItem(Item, ItemsList);
        }

        public override String ToString() {
            return InitialPath;
        }

        private List<DirectoryItem> _itemsList;
    }
}
