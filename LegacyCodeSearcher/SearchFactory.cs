using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegacyCodeSearcher
{
    class SearchFactory
    {
        public static TextSearcher TextSearcher
        {
            get
            {
                if (_textSearcher == null)
                {
                    _textSearcher = new TextSearcher();
                }
                return _textSearcher;
            }
        }

        private static TextSearcher _textSearcher;
    }
}
