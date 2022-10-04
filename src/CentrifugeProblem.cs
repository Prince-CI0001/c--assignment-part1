namespace Assignment1
{
    public class CentrifugeProblem
    {
        public bool BalancingConfiguration(int n, int k)
        {
            //int nk = n - k;
            //if ((n == k) || (k >= nk && nk != 1 && k % nk == 0) || (nk > k && k != 1 && nk % k == 0))
            //    return true;
            //return false;
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
        private List<int> findFactors(int n)
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
        
    







