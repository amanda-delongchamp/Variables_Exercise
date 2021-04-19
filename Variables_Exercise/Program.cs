using System;

namespace Variables_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string dogName = "Betty";
            int dogAge = 1;
            char eyeColorLetter = 'H';
            bool isPretty = true;
            double dogWeight = 35.5;
            decimal dogCost = 1300.35m;

            Console.WriteLine($"My dog's name is {dogName}, and she is {dogAge} old.  {dogName} has {eyeColorLetter} color of eyes, she weights {dogWeight} and her original cost was {dogCost}");


        }
    }
}
