namespace BabyDressShopping
{
    public class BabyDress
    {
        public int Size { get; set; }
        public string Color { get; set; }
        public string Brand { get; set; }
        public double price { get; set; }
    }
    public class BabyDressUtility
    {
        public void AddDressToCart(BabyDress dress)
        {
            BabyProgramClass.DressesCart.Add(dress);  
        }

        public bool RemoveDressFromCart(string brand)
        {
            BabyDress dress = BabyProgramClass.DressesCart.Find(dress => dress.Brand == brand);
            if (brand!= null)
            {
                BabyProgramClass.DressesCart.Remove(dress);
                return true;
            }
            return false;
        }
    }
    public class BabyProgramClass
    {
        public static List<BabyDress> DressesCart { get; set; } = new List<BabyDress>();

        static void Main(string[] args)
        {
            BabyProgramClass program = new BabyProgramClass();
            BabyDress dress = new BabyDress();
            BabyDressUtility babyDressUtility = new BabyDressUtility();
            while (true)
            {
                Console.WriteLine("1.AddDressToCar");
                Console.WriteLine("2.RemoveDressFromCart");
                Console.WriteLine("3.Exit");
                Console.WriteLine("Enter any of above given numbers");
                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    Console.WriteLine("Enter the Size");
                    int Size = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the Color");
                    string Color = Console.ReadLine();
                    Console.WriteLine("Enter the Brand");
                    string Brand = Console.ReadLine();
                    Console.WriteLine("Enter the Price");
                    double price = Convert.ToDouble(Console.ReadLine());
                    babyDressUtility.AddDressToCart(dress);
                    Console.WriteLine("Successfully added to the dress cart");
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Enter the brand of dress you want to remove");
                    string Brand = Console.ReadLine();
                    if (babyDressUtility.RemoveDressFromCart(Brand))
                    {
                        Console.WriteLine("Successfully removed from the cart");

                    }
                    else
                    {
                        Console.WriteLine("Dress not found in the cart");
                    }
                }
                else if (choice == 3)
                {
                    Console.WriteLine(" Visit Again And Thank You !!!");
                }
            }
        }
        
    }
}
