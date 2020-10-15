using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 

namespace VendingMachineInterface
{
    public class Vending_Machine
    {

        private List<IProduct> products = new List<IProduct>(); 


        int[] denonominations = { 1, 5, 10, 20, 50, 100, 500, 1000 };

        int moneyPoolPot = 0;
        public int MoneyPoolPot { get; set; }


        public bool DepositCoin(int coin)
        {
            bool coinDeposited = false;

            for (int i = 0; i < denonominations.Length; i++)
            {
                if (denonominations[i] == coin)
                {
                    MoneyPoolPot += coin;
                    coinDeposited = true;
                }
            }
            if (!coinDeposited)
            {
                Console.WriteLine("That coin is not accepted by this machine");
            }
            return coinDeposited;
        }


        public void DepositACoin(int coin)
        {
            MoneyPoolPot += coin;
        }

        //Reduce money by amount used
        public bool PurchaseItem(string productCode, string enteredCode)
        {
            bool success = true;

            if (productCode == enteredCode)
            {
                --moneyPoolPot;
            }
            return success;
        }

        //Least Amount of Change:
        public static IEnumerable<int> ReturnChange(int[] denominations, int moneyPoolPot) //https://stackoverflow.com/questions/54708466/how-to-get-the-least-possible-combination-for-a-coin-change-problem-in-c-sharp-u
        {
            while (moneyPoolPot >= denominations.Min())
            {
                var denomination = denominations.Where(i => i <= moneyPoolPot).Max();
                moneyPoolPot -= denomination;
                yield return denomination;
            }
        }
    }
}
