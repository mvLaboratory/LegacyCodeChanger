
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

        public static FileReader FileReader
        {
            get
            {
                if (_fileReader == null)
                {
                    _fileReader = new FileReader();
                }
                return _fileReader;
            }
        }

        private static TextSearcher _textSearcher;
        private static FileReader _fileReader;
    }
}
