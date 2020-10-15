namespace VendingMachineInterface
{
    public interface IProduct
    {
        public string ProductName { get; }
        public string ProductCode { get; }
        public int Price { get; }
        public string Action { get; }

        //interface empty methods

        public string Examine();

        public bool PurchaseComplete(int moneyPoolPot, int price);

        public string Use();

    }
}
