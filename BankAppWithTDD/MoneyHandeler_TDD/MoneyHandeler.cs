using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyHandeler_TDD
{

    public class MoneyHandeler
    {
        public int Balance { get; set; } = 500;
        public int Debit(int balanceToRemove)
        {
            if (balanceToRemove > Balance) return Balance;

            return Balance - balanceToRemove;


        }

        public int Credit(int balanceToAdd)
        {
            //if (balanceToAdd < 100) return Balance;
            //if (balanceToAdd <= 0) return Balance;
            //if (balanceToAdd + Balance > 50000) return Balance;
            //if (balanceToAdd >= 30000) return Balance;
            if (balanceToAdd < 100 || balanceToAdd <= 0 || balanceToAdd + Balance > 50000 || balanceToAdd >= 30000)
            return balanceToAdd + Balance;
        }

        public int PrintBalance(int balanceToPrint)
        {
            return balanceToPrint;
        }
    }
}
