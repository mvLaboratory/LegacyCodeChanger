using System;
using System.Collections.Generic;

namespace LegacyCodeSearcher
{
    class FileContent
    {
        public DirectoryItem FileItem { get; set; }
        public IEnumerable<String> InitialFileLines { get; set; }
    }
}
