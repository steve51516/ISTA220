using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumTests
{
    class Program
    {
        static void Main(string[] args)
        {
            Marines marines = new Marines();

            marines.Titles();
        }

    }
    public class Marines
    {
        enum Ranks: byte { Private, Private_First_Class, Lance_Corporal, Corporal, Sergeant, Staff_Sergeant, Gunnery_Sergeant, Master_Sergeant, First_Sergeant, Master_Gunnery_Sergeant, Sergeant_Major };

        Ranks Steven = Ranks.Sergeant;
        Ranks Pat = Ranks.Sergeant_Major;

        public void Titles()
        {
            Console.WriteLine((int)Steven);
            Console.WriteLine((int)Pat);
        }
    }
    struct DOD
    {
        private string USMC;
        private string ARMY;
        private string NAVY;
        private string Air_Force;
    }
}
