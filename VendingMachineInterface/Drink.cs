using System;

namespace VendingMachineInterface
{
    public class Drink : IProduct
    {
        string productCode = "C1";
        string productName = "Fanta";
        readonly int price = 18;
        string action = " Feeling thirsty? Enjoy this nice cold drink!";

        public string ProductName { get { return productName; } }
        public string ProductCode { get { return productCode; } }
        public int Price { get { return price; } }
        public string Action { get { return action; } }

        public string Examine()
        {
            return $"Product Information: \nProductName: {ProductName} \nPrice: {Price} \n\n";
        }

        public bool PurchaseComplete(int moneyPoolPot, int price)
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
