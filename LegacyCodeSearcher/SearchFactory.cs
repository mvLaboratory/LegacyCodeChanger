
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
