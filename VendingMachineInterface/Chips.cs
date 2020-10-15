using System;

namespace VendingMachineInterface
{
    public class Chips  : IProduct
    {
        
        string productName = "Pringles";
        string productCode = "B1";
        readonly int price = 23;
        string action = "Once you pop, you can't stop!";

        public string ProductName { get { return productName; } }
        public string ProductCode { get { return productCode; } }
        public int Price { get { return price; } }
        public string Action { get { return action; } }

        public string Examine ()
        {
            return $"Product Information: \nProductName: {ProductName} \nPrice: {Price} \n\n";
        }

        public bool PurchaseComplete (int moneyPoolPot, int price)
        {
            bool purchaseComplete = false;

            if (moneyPoolPot >= price)
            {
                purchaseComplete = true;
            }
            else
            {
                Console.WriteLine("Insufficient funds");
            }

            return purchaseComplete;
        }

        public string Use()
        {
            return $"Product Instructions: {Action}";
        }

    }
}
