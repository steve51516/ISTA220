using System;


namespace Q04
{
    class Program
    {
        static void Main(string[] args)
        {
            Firearm shotgun = new Firearm();
            Firearm rifle = new Firearm();
            Firearm pistol = new Firearm();

            shotgun.BoomStick("I am a shotgun and I go boom!");
            rifle.BoomStick("I am a rifle and I go crack!");
            pistol.BoomStick("I am a pistol and I go pow!");
        }
    }
    class Firearm
    {

        public void BoomStick(string x)

        {
            Console.WriteLine($"{x}");
        }    
    }
}
