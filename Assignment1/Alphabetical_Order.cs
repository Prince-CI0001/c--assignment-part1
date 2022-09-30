using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Alphabetical_Order
    {
        Dictionary<char, int> map = new Dictionary<char, int>();
           
        public string OutputString(string str)
        {
            str = str.ToLower();
            string newstr = "";
 
            foreach (char c in str)
            {
                if (map.ContainsKey(c))
                    map[c]++;
                else
                {
                    map.Add(c, 1);
                }
            }
                var keys_sorted = map.Keys.ToList();
                keys_sorted.Sort();
                foreach (var k in keys_sorted)
                {
                if (k != ' ')
                {
                    while (map[k] > 0)
                    {
                        newstr += k;
                        map[k]--;
                    }
                }
                }
                
                for(int i=0;i<str.Length;i++)
                {
                if (str[i]==' ')
                {
                    newstr = newstr.Insert(i, " ");
                }
                }
            str = newstr;
            return str;
        }
        

    }
}
