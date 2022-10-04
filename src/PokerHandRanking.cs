namespace Csharp.Assignment1
{
    public class PokerHandRanking
    {
        private string CardName(bool flush,bool straight,int[] ranks,int[] groups)
        {
            if (straight && flush)
                return ranks[0] == 12 ? "Royal Flush" : "Straight Flush";
            if (straight)
                return "Straight";
            if (flush)
                return "Flush";
            if (groups.Length == 2)
            {
                if (groups[0] == 4)
                    return "Four of a Kind";
                else if (groups[0] == 3)
                    return "Full House";
            }
            else if (groups.Length == 3)
            {
                if (groups[0] == 3)
                    return "Three of a Kind";
                else if (groups[0] == 2)
                    return "Two Pair";
            }
            else if (groups.Length == 4)
                return "Pair";

            return "High Card";
        }
        public string PokerHand(string[] cards)
        {
            string[] order = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            int[] ranks = new int[5];


            HashSet<string> suits = new HashSet<string>();
            HashSet<int> set_ranks = new HashSet<int>();

            for (int i = 0; i < 5; i++)
            {
                ranks[i] = Array.IndexOf(order, cards[i].Substring(0, cards[i].Length - 1));
                suits.Add(cards[i].Substring(cards[i].Length - 1));
                set_ranks.Add(ranks[i]);
            }
            Array.Sort(ranks);
            Array.Reverse(ranks);


            List<int> li = new List<int>();
            foreach (int i in set_ranks)
            {
                int el_count = 0;
                for (int j = 0; j < 5; j++)
                    if (ranks[j] == i)
                        el_count++;
                li.Add(el_count);
            }


            int[] groups = li.ToArray();

            Array.Sort(groups);
            Array.Reverse(groups);

            bool flush = (suits.Count == 1);
            bool straight = (set_ranks.Count == 5) && (ranks[0] - ranks[4] == 4);

            string result = CardName(flush, straight,ranks,groups);
            return result;
        }
    }
}

