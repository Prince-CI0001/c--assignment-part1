
namespace Assignment1
{
    public class AlphabeticalOrder
    {
        Dictionary<char, int> map = new Dictionary<char, int>();
           
        public string SequenceOrder(string str)
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
