using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    internal class Specs:Engine
    { 


            public string BodyStyle;
            public double WheelBase;
            public string Headlights;


            public Specs(string bodyStyle, double wheelBase, string headlights)
            {

                BodyStyle = bodyStyle;
                WheelBase = wheelBase;
                Headlights = headlights;
            }


            public void DisplayExteriorSpecifications()
            {

                Console.WriteLine($"Body Style: {BodyStyle}");
                Console.WriteLine($"Wheelbase: {WheelBase} inches");
                Console.WriteLine($"Headlights: {Headlights}");
            }
        }
    }
