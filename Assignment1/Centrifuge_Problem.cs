using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Centrifuge_Problem
    {
        public bool BalancingConfiguration(int n, int k)
        {
            bool compare_factors = (MatchFactors(n, k));

            return (n !=1 && (n == k || compare_factors));
        }

        private bool MatchFactors(int n, int k)
        {
            List<int> factors = findFactors(n);
            int remainingPores = n - k;
            int sum = 0;
            foreach (int factor in factors)
            {
                sum += factor;
                if (sum == k || sum == remainingPores)
                    return true;
                else
                    continue;
            }
            return false;
        }
        public List<int> findFactors(int n)
        {
            List<int> result = new List<int>();
            while (n % 2 == 0)
            {
                result.Add(2);
                n /= 2;
            }
            for (int i = 3; i <= Math.Sqrt(n); i += 2)
            {

                while (n % i == 0)
                {
                    result.Add(i);
                    n /= i;
                }
            }
            if (n > 2)
                result.Add(n);
        return result;
        }
 
    }
    }
        
    







