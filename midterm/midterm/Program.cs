using System;

namespace midterm
{
    class Program
    {
        static void Main(string[] args)
        {
            // loops - loops will repeat a portion of code undill the termination requirements are met. 
            // if statments - both if and if-else when proven ture or false chose the propper code to output
            //switch statments - a switch statments can replace a if-else statment. 

            /*{
                int i = 20;
                Boolean keepLooping = true;
                while(keepLooping)
                {
                    if (i <= 19)
                        keepLooping = false;
                    i++;
                    Console.WriteLine(i);
                }
            }*/
            /*  int i = 2;
              while (i <=128)
              {
                  {
                      if ((i % 2) == 0)
                      {
                          Console.WriteLine("[{0}]", i);
                      }
                      else if ((i % 2) != 0)
                          {
                              Console.Write("");
                          }
                  i *= 2;
                  }
              }*/

            /*    string j = ",";
                int i;
                for (i = 49; i >= 1; --i)
                {
                    Console.Write(i);
                    if (i >= 2)
                    {
                        Console.Write(j);
                    }

                }*/

            /*  int i = 1;
              while (i <= 21)
              {
                  {
                      if ((i % 2) == 0)
                      {
                          Console.Write(" ");
                      }
                      else if ((i % 2) != 0)
                      {
                          Console.Write(i);
                      }
                      i++;
                  }
              }*/

            /* int n = 8;
             int i = 10; // initialize
             do
             {
                 Console.Write("*");
                 i++; // update!
             } while (i < n); // test condition
             // the output is *
             */

            /* int n = 2;
             int i = 1;
             while (i < n)
             {
                 Console.Write("*");
                 i++;   
             }*/


            //we combine multiple boolean values by nested if else or if statments.
            /*{
                bool icyrain = false, tornadowarning = false;
                if (icyrain == false && tornadowarning == false)
                {
                    Console.WriteLine("Lets go outside");
                }

              }*/

            int numberoflayer = 5, Space, Number;
            for (int i = 1; i <= numberoflayer; i++)
            {
                for (Space = 1; Space <= (numberoflayer - i); Space++)
                    Console.Write("");
                for (Number = 1; Number <= i; Number++)
                    Console.Write(Number);
                for (Number = (i - 1); Number >= 1; Number--)
                    Console.Write(Number);
                Console.WriteLine();
                //it writes upside down and on half a pyramid, what did i do wrong. i feel like is something easy but i can not figure it out.


            }
        }
    }
}
