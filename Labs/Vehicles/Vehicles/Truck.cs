using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class Truck : Vehicle
    {
        public void Accelerate()
        {
            Console.WriteLine("Hauling");
        }
        public void Brake()
        {
            Console.WriteLine("Towing");
        }
        public override void Drive()
        {
            Console.WriteLine("Trucking");
        }
    }
}
