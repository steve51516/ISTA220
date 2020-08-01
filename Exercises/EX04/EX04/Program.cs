using System;

namespace EX04
{
    class Program
    {
        static void Main(string[] args)
        {
            Horse Ed = new Horse();

            Ed.Speak("Hello my name is Mr.Ed\n");
            Ed.Eat("hay");

            Horse Reckless = new Horse();

            Reckless.Speak("My name is Sergeant Reckless, and I'm the bravest horse in history!\n");
            Reckless.Eat("carrot");

            Horse Trojan = new Horse();

            Trojan.Speak("I'm a Trojan horse and certainly up to no good!\n");
            Trojan.Eat("Something");

            Horse Barrel = new Horse("I'm a barrel horse!\n");
            Barrel.Eat("apple");

            Pig Piggy = new Pig();
            
            Piggy.Speak("I'm Miss Piggy, Can you help me find Kermit?\n");
            Piggy.Eat("apple");

            Pig Wilbur = new Pig();

            Wilbur.Speak("My name is Wilbur, and I'm looking for my friend Charollet\n");
            Wilbur.Eat("hay");

            Pig Babe = new Pig();

            Babe.Speak("My name is Babe, can you guess my weight?\n");
            Babe.Eat("something");

            Pig Porky = new Pig();

            Porky.Eat("slop");
            Porky.Speak("My name is Porky, and That's all Folks!\n");

            Rooster Foghorn = new Rooster();

            Foghorn.Speak("My name is Foghorn the rooster, and I'm 74 years old this year!\n");
            Foghorn.Eat("eggs");

            Rooster Bigbird = new Rooster();

            Bigbird.Speak("I'm a gaint rooster and I'm looking for Peter Griffin! Where is he???\n");
            Bigbird.Eat("Peter Griffen");

            Rooster ChickenLittle = new Rooster();

            ChickenLittle.Speak("My name is chicken little and the sky is falling!\n");
            ChickenLittle.Eat("seed");

            Rooster Alan = new Rooster();

            Alan.Speak("My name is Alan-a-dale and I'm here to play the guitar!\n");
            Alan.Eat("bugs");

            Ox Blue = new Ox();

            Blue.Speak("I'm Babe the gaint ox.");
            Blue.Eat("hay");

            Ox Paul = new Ox();

            Paul.Speak("My name is Paul Bunyan and I'm identifying as an Ox now!\n");
            Paul.Eat("something");

            Ox ox = new Ox();

            ox.Speak("Man there aren't a lot of fictional oxen, I guess I'm a regular ox!\n");
            ox.Eat("something");

            Ox jack = new Ox();

            jack.Speak("My name is jack and I'm a show ox!\n");
            jack.Eat("grass");

        }
    }
    class Horse
    {
        string name;
        public Horse()
        {
            name = "Mr.Ed";
        }

        public Horse(string x)
        {
            name = x;
        }

        public void Speak(string x)
        {
            Console.WriteLine(x); ;
        }

        public void Eat(string x)
        {
            switch (x)
            {
                case ("hay"):
                    Console.WriteLine("Mmmm This is some great tasting hay!");
                    break;
                case ("apple"):
                    Console.WriteLine("Mmmm I love eating apples!");
                    break;
                case ("carrots"):
                    Console.WriteLine("I love eating carrots! *Crunch*");
                    break;
                default:
                    Console.WriteLine("I don't know what I'm eating but it's great!");
                    break;
            }
        }

    }

    class Pig
    {
        string name = "Pig";
        public Pig()
        {
            name = "Miss Piggy";
        }

        public Pig(string x)
        {
            name = x;
        }

        public void Speak(string x)
        {
            Console.WriteLine(x);
        }
        public void Eat(string x)
        {
            switch (x)
            {
                case ("slop"):
                    Console.WriteLine("Yum I love eating slop!");
                    break;
                case ("hay"):
                    Console.WriteLine("Hay is my favorite!");
                    break;
                case ("feed"):
                    Console.WriteLine("When in doubt, I'll always eat pig feed!");
                    break;
                default:
                    Console.WriteLine("I don't know what I'm eating but it's great!");
                    break;
            }
        }

    }

    class Ox
    {
        string name;
        public Ox()
        {
            name = "Babe"; 
        }
        public Ox(string x)
        {
            name = x;
        }
        public void Speak(string x)
        {
            Console.WriteLine(x);
        }
        public void Eat(string x)
        {
            switch (x)
            {
                case ("hay"):
                    Console.WriteLine("I think all Oxen usually eat is hay.");
                    break;
                case ("grass"):
                    Console.WriteLine("I'll some eat grass too.");
                    break;
                default:
                    Console.WriteLine("I'm either eating hay or grass.");
                    break;
            }
        }

    }

    class Rooster
    {
        string name;
        public Rooster()
        {
            name = "LegHorn";
        }

        public Rooster(string x)
        {
            name = x;
        }
        public void Speak(string x)
        {
            Console.WriteLine(x);
        }
        public void Eat(string x)
        {
            switch (x)
            {
                case ("seed"):
                    Console.WriteLine("I'm a leghorn chicken so I should love eating seed right? *peck peck*");
                    break;
                case ("bugs"):
                    Console.WriteLine("Use Roosters and chickens love eating bugs too!");
                    break;
                case ("eggs"):
                    Console.WriteLine("Chickens are known to love eating their own eggs sometimes too!");
                    break;
                default:
                    Console.WriteLine($"In fact a chicken will eat just about anything! I'm eating {x} right now!");
                    break;
            }
        }
    }
}
