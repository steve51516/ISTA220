using System;

namespace EX03
{
    class Program
    {
        static void Main(string[] args)
        {
            int onSwitch = selectItem();

            bool boop = true;

            while (boop)
            {
                switch (onSwitch)
                {
                    case (1):
                        {
                            try
                            {
                                double result = cirArea();

                                Console.WriteLine($"The area is: {result}");

                                boop = false;
                            }
                            catch (FormatException mes)
                            {
                                Console.WriteLine(mes.Message);
                            }
                            catch (System.OverflowException e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            finally
                            {
                                Console.WriteLine("Message from the finally block.");
                            }
                            break;
                        }
                    case (2):
                        {
                            try
                            {
                                double result = hemiVol();
                                Console.WriteLine($"The hemisphere volume is: {result} ");

                                boop = false;
                            }
                            catch (FormatException ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            catch (System.OverflowException e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            finally
                            {
                                Console.WriteLine("Message from the finally block.");
                            }
                            break;
                        }
                    case (3):
                        {
                            try
                            {
                                double result = triVol();
                                Console.WriteLine($"The area of your triangle is: {result}");

                                boop = false;
                            }
                            catch (FormatException ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            catch (System.OverflowException e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            finally
                            {
                                Console.WriteLine("Message from the finally block.");
                            }
                            break;
                        }
                    case (4):
                        {
                            try
                            {
                                quadraticEquation();

                                boop = false;
                            }
                            catch (FormatException ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            catch (System.OverflowException e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            finally
                            {
                                Console.WriteLine("Message from the finally block.");
                            }
                            break;
                        }
                    default:
                        Console.WriteLine("Enter Number between 1 and 4");
                        onSwitch = selectItem();
                        break;

                }
                
            }

        }

        private static int selectItem()
        {
            Console.WriteLine("Please make a menu selection");
            Console.WriteLine("Enter 1 for Circle Area Calculator");
            Console.WriteLine("Enter 2 for Hemisphere Volume Calculator");
            Console.WriteLine("Enter 3 for Triangle Volume Calculator");
            Console.WriteLine("Enter 4 for Quadratic Equation Calculator");
            Console.Write("Enter Selection: ");
            int x = int.Parse(Console.ReadLine());
            return x;
        }

        private static void quadraticEquation()
        {
            Console.WriteLine("Please enter three large integers");
            Console.Write("Enter A: ");
            int intA = checked(int.Parse(Console.ReadLine()));
            if (intA < 0)
            {
                throw new FormatException("Enter a number greater than zero.");
            }
            Console.Write("Enter B: ");
            int intB = checked(int.Parse(Console.ReadLine()));
            if (intB < 0)
            {
                throw new FormatException("Enter a number greater than zero.");
            }
            Console.Write("Enter C: ");
            int intC = checked(int.Parse(Console.ReadLine()));
            if (intC < 0)
            {
                throw new FormatException("Enter a number greater than zero.");
            }
            double preRoot = (intB * intB) - (4 * intA * intC);
            double postRoot = Math.Sqrt(preRoot);
            double topNumSub = -intB - postRoot;
            double topNumAdd = -intB + postRoot;
            double posA = topNumAdd / (2 * intA);
            double negA = topNumSub / (2 * intA);
            Console.WriteLine($"Postive answer is {posA}");
            Console.WriteLine($"Negative answer is {negA}");
            Console.ReadLine();
        }

        private static double triVol()
        {
            Console.WriteLine("Part 3, The volume of a traingle is");
            Console.WriteLine("Please enter side 1 length: ");

            int intLineA = checked(int.Parse(Console.ReadLine()));
            if (intLineA < 0)
            {
                throw new FormatException("Enter a number greater than zero.");
            }

            Console.WriteLine("Please enter side 2 length: ");
            int intLineB = checked(int.Parse(Console.ReadLine()));
            if (intLineB < 0)
            {
                throw new FormatException("Enter a number greater than zero.");
            }
            
            Console.WriteLine("Please enter side 3 length: ");
            int intLineC = checked(int.Parse(Console.ReadLine()));
            if (intLineC < 0)
            {
                throw new FormatException("Enter a number greater than zero.");
            }

            int halfCir = (intLineA + intLineB + intLineC) / 2;
            double areaRoot = halfCir * (halfCir - intLineA) * (halfCir - intLineB) * (halfCir - intLineC);
            double areaTriangle = Math.Sqrt(areaRoot);
            return areaTriangle;
            
        }

        private static double hemiVol()
        {
            Console.WriteLine("Part 2,The volume of a hemisphere is");
            Console.Write("Enter an integer for the radius of the hemisphere: ");

            int intRadius = checked(int.Parse(Console.ReadLine()));

            if (intRadius < 0)
            {
                throw new FormatException("Enter a number greater than zero.");
            }
                double hemiVol1 = (4.0 / 3.0) * Math.PI * (intRadius * intRadius * intRadius);

                double hemiVol2 = hemiVol1 / 2;
                return hemiVol2;
            
        }

        private static double cirArea()
        {
            Console.WriteLine("Part 1, circumference and area of a circle.");
            Console.Write("Enter an integer for the radius of the circle: ");

            int intRadius = checked(int.Parse(Console.ReadLine()));


            if (intRadius < 0)
            {
                throw new FormatException("Enter a number greater than zero.");
            }
                double circumference = 2 * intRadius * Math.PI;
                Console.WriteLine($"The circumference is: { circumference}");
                double areaCircle = Math.PI * (intRadius * intRadius);
                return areaCircle;
        }
    }
}
