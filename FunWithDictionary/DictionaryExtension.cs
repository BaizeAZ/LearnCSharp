using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithDictionary
{
    public static class DictionaryExtension
    {
        ///根据key得到value,得到返回value,没有返回null。
        public static TValue GetValue<Tkey,TValue>(this Dictionary<Tkey,TValue> dict,Tkey key)
        {
            TValue value;
            dict.TryGetValue(key, out value);
            return value;
        }
    }
}
