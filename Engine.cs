using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
   
        internal class Engine
        {
            public int Efficiency { get; set; }
            public int Speed { get; set; }
            public int Age { get; set; }

            public Engine(int efficiency, int speed, int age)
            {
                Efficiency = efficiency;
                Speed = speed;
                Age = age;
            }

            public void Display()
            {
                Console.WriteLine($"Engine Details - Efficiency: {Efficiency}, Speed: {Speed} km/h, Age: {Age} years");

            }
        }
    }
}

