using System;

namespace Day3_Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Choose your Exercises: ");
            int choosen = int.Parse(Console.ReadLine());
            switch (choosen)
            {
                case 1:
                    Problem1();
                    break;
                case 2:
                    Problem2();
                    break;
                case 3:
                    Problem3();
                    break;
                case 4:
                    Problem4();
                    break;
                case 5:
                    Problem5();
                    break;
                case 6:
                    Problem6();
                    break;

            }
        }

        // Problem 1
        public static void Problem1()
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            BoxPB1 box = new BoxPB1(length, width, height);

            Console.WriteLine($"Surface Area – {box.SurfaceArea():F2}");
            Console.WriteLine($"Lateral Surface Area – {box.LateralSurfaceArea():F2}");
            Console.WriteLine($"Volume - {box.Volume():F2}");



        }

        // Problem 2
        public static void Problem2()
        {

        }

        // Problem 3
        public static void Problem3()
        {

        }

        // Problem 4
        public static void Problem4()
        {

        }

        // Problem 5
        public static void Problem5()
        {

        }

        // Problem 6
        public static void Problem6()
        {

        }
    }
}
