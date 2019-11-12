/*both the if single-selection and the while repetition statment need to have a 
condition met for it to it to know to run or skip a code. they are differnet
becuse the ISS selects or ignores a single action whereas the WRS repetes untill
a condition has been met which alowes it to termnate. */




using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            int speedlimit = 35;
            int speed = 42;

            if (speed > speedlimit)
            {
                Console.WriteLine("SLOW DOWN NOW!");
            }
        }
    }

}

namespace Lab3
{
    class iftrue
    {
        public static void Main(string[] args)
        {
            int istrue = 12;

            if (istrue <= 60)
                Console.WriteLine("It is True");
            else
                Console.WriteLine("It is False");
        }
    }

}

namespace Lab3
{
    class temp
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Input tmeperature in Fahrenheit");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            double Celsius = (fahrenheit - 32d) * 5d / 9d;
            Console.WriteLine("temperture in Celsius s{0}");
            Console.ReadLine();

            if (fahrenheit >= 90)
                Console.WriteLine("It is Hot");
            if (fahrenheit <= 40)
                Console.WriteLine("it is cold")
        }
    }
}

namespace Lab3
{
    class loop1
    {
        public static void Main(string[] args)
        {
            int a = 1;
            while (a < 11) ;
            {
                Console.Write("value: ");
                Console.WriteLine(a); a++;
            }
        }
    }
}

namespace Lab3
{
    class loop2
    {
        public static void Main(string[] args)
        {
            int a = 60;
            while (a >= 20) ;
            {
                Console.Write("value: ");
                Console.WriteLine(a); a--;
            }
        }
    }
}

namespace Lab3
{
    class loop3
    {
        public static void Main(string[] args)
        {
            int a = 10;
            while (a <= 20) ;
            {
                Console.Write("value: ");
                Console.WriteLine(a); a++;
            }
        }
    }
}