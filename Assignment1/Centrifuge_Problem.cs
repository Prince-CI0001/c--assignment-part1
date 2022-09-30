using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Centrifuge_Problem
    {
        public bool BalancingConfiguration(int pores,int user_pores)
        {
            int remaining_pores = pores - user_pores;
            if((user_pores == pores) || (user_pores >= remaining_pores && remaining_pores != 1 && user_pores % remaining_pores == 0) || (remaining_pores > user_pores && user_pores != 1 && remaining_pores % user_pores == 0))
            return true;
            return false;
        }
    }


}




