using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
namespace Assignment1
{
    class Program
    {
         
            static void AlphabeticalOrder()
            {
            Alphabetical_Order obj = new Alphabetical_Order();
            Console.WriteLine("Enter the input string");
            string str = Console.ReadLine();
            Console.WriteLine(obj.OutputString(str));
            }
            static void AreaCalculator()
            {
            AreaCalculator obj = new AreaCalculator();  
            Console.WriteLine("Enter the radius value");
            Console.WriteLine(obj.Area_Calculator(int.Parse(Console.ReadLine())));
            }
            static void BinaryClock()
            {
            BinaryClock obj = new BinaryClock();
            Console.WriteLine("Enter the Input time");
            string time = Console.ReadLine();
            obj.Binary_Clock(time);
            }
            static void CardRanking()
            {
            PokerHandRanking obj = new PokerHandRanking();
            Console.WriteLine("Enter the cards String");
            string[] cards = new string[5];
            for(int i = 0; i < cards.Length; i++)
                cards[i] = Console.ReadLine();
            Console.WriteLine(obj.Poker_Hand_Ranking(cards));
            }
            static void CentrifugeProblem()
            {
            Centrifuge_Problem obj = new Centrifuge_Problem();
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