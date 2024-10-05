using System.Numerics;

namespace Assessment_2
{
    public class Fish
    {
        public string Species { get; set; }
        public double PricePerFish { get; set; }
    }
    public class FishUtility:Fish
    {
       public void AddFish(string species,double pricePerFish)
        {
            Species=species;
            PricePerFish=pricePerFish;
        }
        public bool BuyFish()
        {
            if (Species == "Clownfish" || Species == "Goldfish")
            {
                return true;
            }
            else
            {
               
                return false;
                
            }
            
        }
        public double CalculatePrice(int numberofFishes)
        {
            double Additionalcharges = 0;
            
            if (Species == "Clownfish")
            {
                Additionalcharges = 100;
            }
            else if(Species =="Goldfish")
            {
                Additionalcharges = 150;
            }
            return (numberofFishes*PricePerFish)+Additionalcharges;
        }

    }
    
    public class Program
    {
        static void Main(string[] args)
        {
            FishUtility fishUtility = new FishUtility();
            Console.WriteLine("Enter the Species");
            string species = Console.ReadLine();
  
            fishUtility.BuyFish();

            if (species == "Clownfish" || species == "Goldfish")
            {
                Console.WriteLine("Enter the PricePerFish");
                double priceperfish = Convert.ToDouble(Console.ReadLine());
                fishUtility.AddFish(species,priceperfish);

                Console.WriteLine("Enter the number of fishes you need to buy");
                int numberofFishes = int.Parse(Console.ReadLine());

                double totalprice = fishUtility.CalculatePrice(numberofFishes);
                Console.WriteLine("Totalprice : " + totalprice);
            }
            else
            {
                Console.WriteLine(species + " species is not found");
            }
           
        }
    }
}
