using System;
using System.Collections.Generic;
using System.Text;

namespace Access_Modifiers
{
    class ListUsage
    {
        public List<string> stringList;
        public List<Cat> catsList;
        public Dictionary<int, string> keyValueList;
        public List<KeyValuePair<int, string>> keyValuePairList;

        public ListUsage()
        {
            stringList = new List<string>();
            catsList = new List<Cat>();
            keyValueList = new Dictionary<int, string>();
            keyValuePairList = new List<KeyValuePair<int, string>>();
        }
    }
}
