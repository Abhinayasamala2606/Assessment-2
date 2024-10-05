namespace Product1
{
    public class Product
    {
        public int Stock { get; set; }
        public string Name { get; set; }
    }
    public class DeliveryService
    {
        
        public bool PlaceOrder(Product product)
        {
            if (product.Stock > 0)
            {
                Console.WriteLine("Order placed successfully");
                return true;
            }
            else
            {
                throw new ProductOutofStockException("Product is out of stock");
                
            }

        }
    }
    public class ProductOutofStockException : Exception
    {
        public ProductOutofStockException(string Message)
        {
            
        }
        public override string Message => "Not found";


    }
    public class ProductProgram
    {
        static void Main(string[] args)
        {
            try
            {
                
                Console.WriteLine("Enter the Product Name ");
                string Name = Console.ReadLine();
                Console.WriteLine("Enter the Number of Stocks");
                int Stock = int.Parse(Console.ReadLine());
                Product product = new Product { Name=Name,Stock=Stock};
                DeliveryService deliveryService = new DeliveryService();
                deliveryService.PlaceOrder(product);
            }
            catch (ProductOutofStockException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Thank You for Visiting");
            }
            
        }
    }
}
