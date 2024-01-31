using System.Reflection;
using System.Runtime.CompilerServices;

namespace _03_IntroToOOP
{
    partial class Freezer
    {
        public static string Mark { get; set; }
        public string Model { get; set; }
        private int temperature;
        public int Temperature { 
            get
            { return temperature; } 
            set
            {
                if(value > -20|| value <20) { temperature = value; }
                else { temperature = 0; }
            }
        }
        public static string FreezingType { get; set; }
        private int capacity;
        public int Capacity { 
            get
            {
                return capacity;    
            }
            set {
                if (value > 0 || value <= 500)
                    capacity = value;
                else { capacity = 0; }
            } }
        public Freezer()
        {
            Mark = "DefMark";
            
            Temperature = 0;  
           
            Capacity = 0;
            
        }
        static Freezer() {
            FreezingType = "Dry Freeze";
            Mark = "Samsung";
        }
       
        public override string ToString()
        {
            return $"Mark: {Mark}, Model:{Model}, Temperature: {Temperature}, Freezing type: {FreezingType}, Capacity: {Capacity}";
        }
        public void Print()
        {
            Console.WriteLine(ToString());
        }

    

     

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Freezer[] freezer;
            freezer = new Freezer[10];
            freezer[0] = new Freezer("New",1,2);

            freezer[0].Print();
            freezer[0].ChangeFreezer("NoNew", 4, 4);
            freezer[0].Print();
            freezer[1] = new Freezer("New1", 4, 50);
            freezer[2] = new Freezer("New2", 1, 100);
            freezer[3] = new Freezer("New3", -3, 111);
            freezer[4] = new Freezer("New4", -2, 222);
            for(int i = 0; i < 5; i++) { freezer[i].Print(); }
        }
    }
}