namespace Csharp.Assignment1
{
    internal class Program
    {
         
            static void AlphabeticalOrder()
            {
            AlphabeticalOrder obj = new AlphabeticalOrder();
            Console.WriteLine("Enter the input string");
            string str = Console.ReadLine();
            str = obj.SequenceOrder(str);
            Console.WriteLine(str);
            }


            static void AreaCalculator()
            {
            AreaCalculator obj = new AreaCalculator();  
            Console.WriteLine("Enter the radius value");
            int radius = int.Parse(Console.ReadLine());
            Console.WriteLine(obj.Area(radius));
            }


            static void BinaryClock()
            {
            BinaryClock obj = new BinaryClock();
            Console.WriteLine("Enter the Input time");
            string time = Console.ReadLine();
            obj.BinaryMatrix(time);
            }


            static void CardRanking()
            {
            PokerHandRanking obj = new PokerHandRanking();
            Console.WriteLine("Enter the cards String");
            string[] cards = new string[5];
            for(int i = 0; i < cards.Length; i++)
                cards[i] = Console.ReadLine();
            Console.WriteLine(obj.PokerHand(cards));
            }


            static void CentrifugeProblem()
            {
            CentrifugeProblem obj = new CentrifugeProblem();
            Console.WriteLine("Enter for the n test tube Configuration");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter for the k test tube Configuration");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine(obj.BalancingConfiguration(n,k));
            }





        static void Main()
        {

            Console.WriteLine("Enter the Problem statement Index");
            Console.WriteLine("1. Aplphabetical Order");
            Console.WriteLine("2. Area Calculator");
            Console.WriteLine("3. Binary Clock");
            Console.WriteLine("4. Card Ranking");
            Console.WriteLine("5. Centrifuge Problem");
            int index = int.Parse(Console.ReadLine());
            switch (index)
            {
                case 1:
                    Program.AlphabeticalOrder();
                    break;
                case 2:
                    Program.AreaCalculator();
                    break;
                case 3:
                    Program.BinaryClock();
                    break;
                case 4:
                    Program.CardRanking();
                    break;
                case 5:
                    Program.CentrifugeProblem();
                    break;
                default:
                    Console.WriteLine("Wrong Index");
                    break;
            }



        }
    }
}