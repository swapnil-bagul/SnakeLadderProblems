using System;

namespace SnakeLadderProblems
{
    class SnakeLadderGame
    {
        //constant variable
        public const int WON = 100;
        public const int START_POSITION = 0;

        //static variable
        static int totalNum = 0;

        // create method to roll the die
        static void Roll()
        {
            // create object using Random Predefined Class
            Random die = new Random();
            // using next() method to get output 1 to 6
            int getNum = die.Next(1, 7);

            //player roll the die and get no between 1 to 6
             Console.WriteLine("Die show the Number: " + getNum);

            totalNum = totalNum + getNum;
            Console.WriteLine("Current Position is: " + totalNum);

            //if else if programming construct
            if (totalNum > WON)
            {
                totalNum = totalNum - getNum;
                Console.WriteLine("Current Position is: " + totalNum);
                SnakeLadderGame.Roll();
            }
            else if (totalNum == WON)
            {
                Console.WriteLine("reach 100");
            }

            else if (totalNum <= WON)
            {

                switch (totalNum)
                {
                    //ladder and Snake are added
                    case 20:
                        Console.WriteLine("Ladder");
                        totalNum += 10;
                        Console.WriteLine("Current Position is: " + totalNum);
                        break;
                    case 35:
                        Console.WriteLine("Ladder");
                        totalNum += 25;
                        Console.WriteLine("Current Position is: " + totalNum);
                        break;
                    case 64:
                        Console.WriteLine("Ladder");
                        totalNum += 24;
                        Console.WriteLine("Current Position is: " + totalNum);
                        break;
                    case 72:
                        Console.WriteLine("Ladder");
                        totalNum += 10;
                        Console.WriteLine("Current Position is: " + totalNum);
                        break;
                    case 22:
                        Console.WriteLine("Snake");
                        totalNum -= 10;
                        Console.WriteLine("Current Position is: " + totalNum);
                        break;
                    case 40:
                        Console.WriteLine("Snake");
                        totalNum -= 15;
                        Console.WriteLine("Current Position is: " + totalNum);
                        break;
                    case 62:
                        Console.WriteLine("Snake");
                        totalNum -= 24;
                        Console.WriteLine("Current Position is: " + totalNum);
                        break;
                    case 90:
                        Console.WriteLine("Snake");
                        totalNum -= 30;
                        Console.WriteLine("Current Position is: " + totalNum);
                        break;
                   
                }

            }
            else
            {
                SnakeLadderGame.Roll();
            }

        }       
  
        public static void Main(string[] args)
        {
            Console.WriteLine("Start Position is {0}",START_POSITION );

           //while loop programming construct 
            while(totalNum != WON )
            {
                //call static method
                SnakeLadderGame.Roll();
            }
           
        }
    }
}
