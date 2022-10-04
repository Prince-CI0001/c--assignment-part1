namespace Csharp.Assignment1
{
    public class BinaryClock
    {
        public BinaryClock() { }
        private string reverse(string str)
        {
            if (str.Length <= 1)
            return str;
            else 
            return reverse(str.Substring(1)) + str[0];
        }
        private string ConvertToBinary(int N)
        {
            string outputString;
            int B_Number = 0;
            int cnt = 0;
            while (N != 0)
            {
                int rem = N % 2;
                int c = (int)Math.Pow(10, cnt);
                B_Number += rem * c;
                N /= 2;
                cnt++;
            }
             outputString = B_Number.ToString();
            
           return  reverse(outputString);
        }
        private string[] zeroes(string[] arr)
        {
            string timeLength = "434342";
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == "0")
                    arr[i] += '0';
                if ((timeLength[i] - '0') > arr[i].Length)
                {
                    for (int j = 0; j <= ((timeLength[i] - '0') - arr[i].Length); j++)
                    {
                        arr[i] += '0';
                    }
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length != 4)
                {
                    arr[i] = arr[i].PadRight(4, '*');
                }
            }
            return arr;
        }
        private string[] fillMatrix(string[] arr)
        {
            char[ , ] filler = new char[6,4];
            for(int i=0;i<6;i++)
            {
                string str = arr[i];
                for(int j=0;j<4;j++)
                {
                    filler[i,j] = str[j];
                }

            }
            int index = 0;
            string[] result = new string[4];
            for(int col = 3; col >= 0; col--)
            {
                string finalStr = "";
                for(int row = 5; row >=0; row--)
                {
                    
                    finalStr += filler[row, col];
                    
                }
                result[index++] = finalStr.Replace('*',' ')+",";
            }    
            return result;
        }
        public void BinaryMatrix(string str)
        {
            str = str.Replace(":", "");
            string[] arr = new string[6];
            
            for(int i = str.Length-1; i >= 0; i--)
            {
               arr[str.Length-(i+1)] =  ConvertToBinary(str[i] - '0');
            }


            arr = zeroes(arr);

            string[] result = fillMatrix(arr);
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
        }
    }
}
