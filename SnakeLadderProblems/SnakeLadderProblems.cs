using System;

namespace SnakeLadderProblems
{
    class SnakeLadderGame
    {

        // create method to roll the die
         static void Roll()
        {
           // create object using Random Predefined Class
            Random die = new Random();
            // using next() method to get output 1 to 6
            int getNum = die.Next(1, 7);
       
            //player roll the die and get no between 1 to 6
            Console.WriteLine("Die show the Number: " + getNum);

        }
         static void Check()
        {
            Random check = new Random();
            int input = check.Next(0, 3);

            // switch case programing constructs
            switch (input)
            {
                case 0 :
                    Console.WriteLine("No play the Player Stays the same position");
                    break;

                case 1:
                    SnakeLadderGame.Roll();
                    Console.WriteLine("Ladder the player moves ahead by the position received in the die");
                    break;

                default:
                    SnakeLadderGame.Roll();
                    Console.WriteLine("Snake the player moves behind by the position received in the die");
                    break;
            }

        }
        public static void Main(string[] args)
        {
            // call static method
            SnakeLadderGame.Check();
           
        }
    }
}
