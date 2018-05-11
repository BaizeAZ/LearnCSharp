using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            string dicValue;
            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(2, "hejingjun");
            dic.Add(5, "huangyangyang");
            dic.Add(7, "caidasen");
            dic.Add(6, "liaojingyu");
            List<int> dicInfo = dic.Keys.ToList();
            foreach (int item in dicInfo)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            for (int i = 0; i < dicInfo.Count; i++)
            {
                Console.WriteLine(dicInfo[i]);
                dicValue = dic.GetValue(dicInfo[i]);
                Console.WriteLine(dicValue);
            }
            
            Console.ReadLine();
        }
    }
}
