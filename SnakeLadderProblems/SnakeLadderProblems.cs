using System;

namespace SnakeLadderProblems
{
    class SnakeLadderGame
    {

        // create method to roll the die
         void Roll()
        {
           // create object using Random Predefined Class
            Random die = new Random();
            // using next() method to get output 1 to 6
            int getNum = die.Next(1, 7);
       
            //player roll the die and get no between 1 to 6
            Console.WriteLine("Die show the Number: " + getNum);

        }
        public static void Main(string[] args)
        {
        SnakeLadderGame snakeLadder = new SnakeLadderGame();
        snakeLadder.Roll();
        
        }
    }
}
