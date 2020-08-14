using System;
using System.Media;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;


namespace EX06___Framework
{

    class Program
    {
        static void Main(string[] args)
        {
            ShowWindow(ThisConsole, MAXIMIZE);
            Thread.Sleep(200);

            //AntiPersonnelWeapons smallarms = new AntiPersonnelWeapons();
            //smallarms.Shoot(2);
            //smallarms.Reload();

            //indirectFireWeapons howitzer = new indirectFireWeapons();
            //howitzer.Shoot();
            //howitzer.Reload();

            directFireWeapons BMG = new directFireWeapons();
            BMG.Shoot(3);
        }
        [DllImport("kernel32.dll", ExactSpelling = true)]

        private static extern IntPtr GetConsoleWindow();
        private static IntPtr ThisConsole = GetConsoleWindow();

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]

        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        private const int HIDE = 0;
        private const int MAXIMIZE = 3;
        private const int MINIMIZE = 6;
        private const int RESTORE = 9;
    }
    public class Weapons
    {
        public int magAmmo;
        public int totalAmmo;
        public int Magazines;
        public Weapons()
        {
            magAmmo = 0;
            totalAmmo = 0;
            Magazines = 0;
        }
        public virtual void Shoot(int x)
        {
            if (x > 0)
            {
                for (int i = 0; i <= x; i++)
                {
                    Console.WriteLine("Shooting");
                    magAmmo--;
                }
            }
        }
        public virtual void Reload()
        {
            Console.WriteLine("Default reloading method");
        }

        public virtual void Aim()
        {
            Console.WriteLine("Default Aiming method");
        }
    }
    class AntiPersonnelWeapons : Weapons
    {
        public AntiPersonnelWeapons()
        {
            magAmmo = 30;
            Magazines = 6;
            totalAmmo = 180;
        }
        public override void Shoot(int x)
        {
            if (magAmmo == 0)
                Console.WriteLine("Must reload magazine is empty.");
            if (x < 30)
                Console.WriteLine("Cannot fire more than 30 rounds at a time.");
            if (x > 0 & x <= 30)
            {
                SoundPlayer soundPlayer = new SoundPlayer(@"E:\steve\Documents\Quantico06\ISTA220\Exercises\EX06\Sound\M1GarandGun.wav");
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine(@"                              .-----------------TTTT_-----_______                     ");
                Console.WriteLine(@"                       /''''''''''(______O] ----------____  \______/]_                ");
                Console.WriteLine("    __...---\'\"\"\"\\_--\'\'   Q                               ___________O           ");
                Console.WriteLine(@"|'''                   ._   _______________=---------'''''''                          ");
                Console.WriteLine(@" | ..--'' | l L | _l |                                                                ");
                Console.WriteLine(@"|          ..--''      .  /-___j '   '                                                ");
                Console.WriteLine(@"|    ..--''           /  ,       '   '                                                ");
                Console.WriteLine(@"|--''                /           `    \                                               ");
                Console.WriteLine(@"                     L__'         \    -                                              ");
                Console.WriteLine(@"                                   -    '-.                                           ");
                Console.WriteLine(@"                                    '.    /                                           ");
                Console.WriteLine(@"                                      '-./                                            ");

                for (int i = 0; i < x; i += 2) // Due to sound file firing 2 shots the iteration variable updates by 2
                {
                    Console.WriteLine("\nShooting 7.62x39!");
                    soundPlayer.Play(); // plays two gunshot sounds 2 seconds total
                    Thread.Sleep(2000);
                    magAmmo -= 2;
                    if (magAmmo == 0)
                        Console.WriteLine("Magazine is empty, must reload!");
                }
                totalAmmo -= x;
                Console.ResetColor();
            }
            else
                Console.WriteLine("Cannot fire more than magazine can hold");
        }
        public override void Reload()
        {
            if (totalAmmo == 0)
                Console.WriteLine("Cannot reload, no ammo left.");
            if (magAmmo == 0 & totalAmmo >= 30)
            {
                Console.WriteLine("Dropping magazine in dump pouch, inserting fresh magazine...");
                Console.WriteLine($"{Magazines} Magazines left, {totalAmmo} total ammo left.");
                System.Threading.Thread.Sleep(2000);
                Magazines--;
                totalAmmo -= 30;
            }
            if (magAmmo != 0)
            {
                Console.WriteLine("Performing tactical reload.");
                System.Threading.Thread.Sleep(1000);
                totalAmmo -= magAmmo;
                magAmmo = 30;
                Console.WriteLine($"Total rounds left: {totalAmmo}");
            }
            if (totalAmmo < 30)
            {
                Console.WriteLine($"Performing reload with magazine of {totalAmmo}");
                System.Threading.Thread.Sleep(1000);
                magAmmo = totalAmmo;
                totalAmmo = 0;
            }
        }
    }
    class indirectFireWeapons : Weapons
    {
        public indirectFireWeapons()
        {
            magAmmo = 1;
            totalAmmo = 30;
        }
        public override void Shoot(int x = 1)
        {
            if (magAmmo == 1)
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine(@"             ,______                                                                  ");
                Console.WriteLine(@"          _./       \_                                                                ");
                Console.WriteLine(@"        /'     -=X=-  \                                                               ");
                Console.WriteLine(@"       /        <_>___\___/---_H_                                                     ");
                Console.WriteLine(@"      Z---|     |-------   --/_O_)                                                    ");
                Console.WriteLine(@"       __ |__   L___^|^^^^^\--\__/                                                    ");
                Console.WriteLine(@"      /     \\ __T__ |                                                                ");
                Console.WriteLine(@"     / __|__ \\__^  _|   \_                                                           ");
                Console.WriteLine(@"S-v|-  __^\   _|__| _/ _ __\                                                          ");
                Console.WriteLine(@" ----| O  ))==|___ _|==-) ||                                                          ");
                Console.WriteLine(@"     \ _//            \__//                                                           ");

                Console.WriteLine("\nShooting 155MM High Explosive Round!");
                SoundPlayer soundPlayer = new SoundPlayer(@"E:\steve\Documents\Quantico06\ISTA220\Exercises\EX06\Sound\HowitzerGunBlast.wav");
                soundPlayer.Play();
                System.Threading.Thread.Sleep(2000);
                Console.ResetColor();
            }
            else
                Console.WriteLine("Must reload!");
        }
        public override void Reload()
        {
            if (totalAmmo != 0)
            {
                totalAmmo--;
                Console.WriteLine($"Reloading Howitzer now... total ammo left: {totalAmmo}");
                System.Threading.Thread.Sleep(1000);
            }    

        }
    }
    public class directFireWeapons : Weapons
    {
        public directFireWeapons()
        {
            totalAmmo = 350;
        }
        public override void Shoot(int x)
        {
            if (x < 3)
                x = 3;
            if (x > 350)
                x = 350;
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
            SoundPlayer soundPlayer = new SoundPlayer(@"E:\steve\Documents\Quantico06\ISTA220\Exercises\EX06\Sound\50CalMachineGun.wav");
            Console.WriteLine(@"         /'        /|                                                                 ");
            Console.WriteLine(@"        /         / |_                                                                ");
            Console.WriteLine(@"       /         /  //|                                                               ");
            Console.WriteLine(@"      /_________/  ////|                                                              ");
            Console.WriteLine(@"     |   _ _    | 8o////|                                                             ");
            Console.WriteLine(@"     | /'// )_  |   8///|                                                             ");
            Console.WriteLine(@"     |/ // // ) |   8o///                                                             ");
            Console.WriteLine(@"     / // // //,|  /  8//|                                                            ");
            Console.WriteLine(@"   / // // /// | /   8//|                                                             ");
            Console.WriteLine(@"   / // // ///__|/    8//|                                                            ");
            Console.WriteLine(@"  /.(_)// /// |       8///|                                                           ");
            Console.WriteLine(@" (_)' `(_)//| |       8////|___________                                               ");
            Console.WriteLine(@"(_) /_\ (_)'| |        8///////////////                                               ");
            Console.WriteLine("(_) \"/ (_)'|_|         8/////////////                                                 ");
            Console.WriteLine(@" (_)._.(_) d' Hb         8oooooooopb'                                                 ");
            Console.WriteLine(@"   `(_)'  d'  H`b                                                                     ");
            Console.WriteLine(@"         d'   `b`b                                                                    ");
            Console.WriteLine(@"        d'     H `b                                                                   ");
            Console.WriteLine(@"       d'      `b `b                                                                  ");
            Console.WriteLine(@"      d'           `b                                                                 ");
            Console.WriteLine(@"     d'             `b                                                                ");
            Console.WriteLine(@"             ,______                                                                  ");

            for (int i = 0; i < x; i += 3) // Due to sound file firing 3 shots the iteration variable updates by 3
            {
                Console.WriteLine("\nShooting .50 Caliber!");
                soundPlayer.Play(); // Sound file 3 shots browning .50 cal
                Thread.Sleep(2000);
                totalAmmo -=3;
                if (totalAmmo == 0)
                    Console.WriteLine("Belt is empty, must reload!");
            }
        }
    }
    class Vehicles
    {

    }
    class Personnel
    {

    }
    class Mission
    {

    }
    class Supply
    {

    }
}
