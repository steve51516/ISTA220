using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q06
{
    class Program
    {
        static void Main(string[] args)
        {
            Firearm firearm = new Firearm();
            firearm.Fire("I'm a generic firearm and I shoot things.");

            Shotgun shotgun = new Shotgun();
            shotgun.Fire("I'm a 12 guage shotgun and I got boom!");

            Pistol pistol = new Pistol();
            pistol.Fire("I'm a 9mm pistol and I got pop!");

            Rifle rifle = new Rifle();
            rifle.Fire("I'm a 30-06 rifle and I go crack!");
        }
    }
    class Firearm
    {
        public void Fire(string x)
        {
            Console.WriteLine(x);
        }
    }

    class Shotgun : Firearm
    {

    }

    class Pistol : Firearm
    {

    }

    class Rifle : Firearm
    {

    }

}
