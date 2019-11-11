// step 2 multiplation program

using System;

namespace Lab2
{
    using System;

    class Multiplication
    {
        //main method begins exicution of c# application
        public static void Main(string[] args)
        {
            int number1; //declare first number to multiply
            int number2; //declare second number to multiply
            int sum;  //declare sum of number1 and number2

            Console.Write("Enter first interger: "); //prompt user
                                                     //read first number from user
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second integer: "); //Prompt user 
                                                     //read second number from user
            number2 = Convert.ToInt32(Console.ReadLine());

            int v = sum = number1 * number2; // multiply numbers

            Console.WriteLine("sum is {0}", sum); // Display sum
        }
    }
}

namespace Lab2
{
    class Welcome4
    {
        // Main methiod begins exicution of C# applications
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!\nFrom Zane Havlin");
            Console.WriteLine("Hello World!    From Zane Havlin");
        } //end main
    }//end class welcome4

}
// the only way i could get it to run why by chooseing a starting point in the settings, if there is a diffent way to do this please tell me i think i am missing something
// and intiger is a simple number without a decimal point. A floating point or double are more complex numbers that can include decimal points.
//class welcome4
// Get acessor read the value and set acessor assigns the value
//a class defines the methods and properties of a unit and can hold multiple objects. A object is the is with class and has the same properties of the class but each object has different methods.
// as many as you want, alothough creating to many would become to confusing and cause issues. 