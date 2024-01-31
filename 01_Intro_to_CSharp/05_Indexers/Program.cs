using System.Security.Cryptography.X509Certificates;

namespace _05_Indexers
{
    class Laptop
    {
        public string Model { get; set; }
        public double Price { get; set; }
        public override string ToString()
        {
            return $"Model: {Model}, Price: {Price}";
        }

    }
    class Shop
    {
        Laptop[] laptops = null;
        public Shop(int size)
        {
            laptops = new Laptop[size];
        }
        public int Length
        {
            get { return laptops.Length;}
        }
        //public Laptop GetLaptop(int index)
        //{
        //    if (index >=0 && index < laptops.Length) return laptops[index];
        //    else throw new IndexOutOfRangeException();

        //}
        //public void SetLaptop(int index, Laptop value) {
        //    if (index >= 0 && index < laptops.Length)  laptops[index] = value;
        //    else throw new IndexOutOfRangeException();
        //}
        public Laptop this[int index]
        {
            get {
                if (index >= 0 && index < laptops.Length) return laptops[index];
                else throw new IndexOutOfRangeException();
            }
            set {
                if (index >= 0 && index < laptops.Length) laptops[index] = value;
                else throw new IndexOutOfRangeException();
            }
        }
        public Laptop this[string name]
        {
            get {
            foreach(var item in laptops)
                {
                    if (item.Model == name) return item;
                    
                }
                return null;
            }
            set
            {
                for(int i = 0; i < laptops.Length; i++) {
                    if (laptops[i].Model == name) {
                        laptops[i] = value;
                        break;
                    }
                }
            }
            
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop (3);
            shop[0] = new Laptop { Model = "HP", Price = 39000 };
            shop[1] = new Laptop { Model = "Asus", Price= 33999 };
            shop[2] = new Laptop { Model = "Delphi", Price= 13000 };
            try { 
            for (int i = 0; i < shop.Length; i++)
                {
                    Console.WriteLine(shop[i]);
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }


        }
    }
}