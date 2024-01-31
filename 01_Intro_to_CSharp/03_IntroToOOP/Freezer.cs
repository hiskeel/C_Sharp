using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_IntroToOOP
{
    partial class Freezer
    {
        public Freezer(string model, int temperature, int capacity)
        {
            Model = model;
            Temperature = temperature;
            Capacity = capacity;
        }

        //static Freezer()
        //{
        //    FreezingType = "Dry Freeze";
        //    Mark = "Samsung";
        //}
        public void ChangeFreezer(string model, int temp, int capac)
        {
            Model = model;
            Temperature = temp;
            Capacity = capac;
        }
    }
}
