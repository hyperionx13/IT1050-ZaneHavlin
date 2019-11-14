using System;

namespace LAb4
{
    /*
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; ++i)
            {
                Console.WriteLine(i);

                if ((i % 2) == 0)
                    Console.WriteLine("{0}", "it's even");

                else if ((i % 2) != 0)
                    Console.WriteLine("{0}", "it's odd");
            }
        }
    }
    */
    /*
    class program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a temperature: "); 
            
            int temp = Convert.ToInt32(Console.ReadLine()); if (temp >= 90) { Console.WriteLine("fish"); }
            
            else if(temp >= 80) { Console.WriteLine("Lion"); }
            
            else if(temp >= 70) { Console.WriteLine("Turtle"); }
            
            else if(temp >= 60) { Console.WriteLine("Deer"); }
            
            else if(temp >= 50) { Console.WriteLine("Reindeer"); }
            
            else if(temp >= 40) { Console.WriteLine("Moose"); }
            
            else if(temp >= 20) { Console.WriteLine("Penguin"); }
            
            else if(temp >= 10) { Console.WriteLine("Polar Bear"); } else { Console.WriteLine("Bug"); }
        }
    }
    */
    /*
    class Program
    {
        static void Main (string[] args) 
        { 
            Console.WriteLine
                ("Please enter the exhibit number: "); 
            string str = Console.ReadLine(); 
            int caseSwitch = int.Parse(str);
            switch (caseSwitch)
            {
                case 1:
                    Console.WriteLine("polar bear ");
                    break;
                case 2:
                    Console.WriteLine("penquin ");
                    break;
                case 3:
                    Console.WriteLine("moose ");
                    break;
                case 4:
                    Console.WriteLine("reindeer ");
                    break;
                case 5:
                    Console.WriteLine("deer ");
                    break;
                case 6:
                    Console.WriteLine("turtle ");
                    break;
                case 7:
                    Console.Write("lion ");
                    break;
                case 8:
                    Console.WriteLine("fish ");
                    break;
                case 9:
                    Console.WriteLine("bug ");
                    break;
            }
        }
    }
    */
    /*
    class program
    {
        static void Main(string[] args)
        {//there was no command telling it tou count so i added the (i++)
            int i = 10;
            while(i<21)
            {
                Console.WriteLine(i);
                i++;
            }
        }
    }
    */
    /*
    class program
    {
        static void Main(string[] args)
        {//the code was written to put the code only at the end. i added a (if) statment to correct this
            for (int i = 0; i < 101; i++)
            {
                if (i<=101)
                    Console.WriteLine("********");
                Console.WriteLine(i);
                
            }
        }
    }
    */
}

/*  Questions 1
 *         control variable - this is the loop counter
 *         Initial Value - is the starting value of the controle variable
 *         increment/decrement - the increment/decremnt that the control variable is modified with every loop
 *         loop-continuation condition - what dicides if the loop will continue or terminate
 *   
 *  Question 2
 *            the while repetition statment uses multipul lines of code to work
 *           the for repetition statment uses only one line
 *           
 *  Question 3
 *          the do while statment would be usefull when you want ot code a menu as it would make sure the menu is shown atleast once. 