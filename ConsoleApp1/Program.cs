using System.Security.Cryptography.X509Certificates;

namespace PCCO104L.Encapsulation.Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car Ford = new Car(750000);
            Ford.Brand = "Ford";
            Ford.BROOOOOM();


            Suzuki suzuki = new Suzuki(989000, "SUZUKI");
            suzuki.SUUUUUZUUUUUKIIIIIIII();

            F1 mcLaren = new F1(391);
            mcLaren.Car = "McLAREN";
            mcLaren.MCLAREN();

        }
    }

    public class Car
    {
        public string Brand { get; set; }
        private double Price { get; set; }

        public Car() { }

        public Car(double price)
        {
            Price = price;
        
        }

        public Car (double price, string brand):this(price)
        {
            Brand = brand;

        }

        public void BROOOOOM()
        {
            Console.WriteLine($"{Brand} - {Price}.. BROOOOMMMM!");
        
        }

    
    }

    public class Suzuki
    {
        public string Brandd { get; set; }
        private double Price { get; set; }

        public Suzuki() { }


        public Suzuki(double price)
        {
            Price = price;
        
        }

        public Suzuki(double price, string brand) : this(price)
        {
            Brandd = brand;

        }


        public void SUUUUUZUUUUUKIIIIIIII()
        {
            Console.WriteLine($"{Brandd} - {Price}.. SUUUUUZUUUUUKIIIIII!");

        }


    }

    public class F1
    {
        public string Car { get; set; }
        private double top_spd { get; set; }

        public F1() { }

        public F1(double spd)
        {
            top_spd = spd;
        
        }

        public F1(double spd, string mclaren): this(spd) 
        {
            Car = mclaren;
        
        }

        public void MCLAREN()
        {
            Console.WriteLine($"{Car} - {top_spd}.. VOOOOMMMM!!!");
        
        }

    
    }




}
