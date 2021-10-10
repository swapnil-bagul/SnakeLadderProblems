using System;

namespace SnakeLadderProblems
{
    class SnakeLadderGame
    {
        static void Main(string[] args)
        {
          
     
                //Create object using Random predifined class
                Random roll = new Random();
                //using next() method to get output 1 to 6
                int getNum = roll.Next(1, 7);

                //player roll the die and get no between 1 to 6
                Console.WriteLine("Die show the Number: " + getNum);
       
        }
    }
}
