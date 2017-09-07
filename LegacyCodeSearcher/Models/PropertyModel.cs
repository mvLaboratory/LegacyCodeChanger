using System;

namespace LegacyCodeSearcher
{
    class PropertyModel
    {
        public String FileName { get; set; }
        public String Name { get; set; }
        public String Value { get; set; }
        public String InitialString { get; set; }

        public override String ToString()
        {
            return String.Format("{0} -- {1}: {2}", FileName, Name, Value);
        }
    }
}
