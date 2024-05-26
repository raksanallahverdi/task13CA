namespace Task4
{
    public static class Program
    {
        public static void Main()
        {
            Inventory shop = new Inventory();
            shop.AddProduct("milk", 5);
            shop.AddProduct("tea", 8);
            shop.RemoveProduct("tea");
            shop.AddProduct("milk", 1);
            shop.GetQuantityByProduct("milk");
            shop.UpdateQuantity("milk", 2);
            shop.GetQuantityByProduct("milk");
            shop.GetQuantityByProduct("tea");

            Console.ReadLine();




        }
    }
}
