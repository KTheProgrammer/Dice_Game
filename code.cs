using System;

namespace Dice_Game
{
    class Program
    {
        public static void Main(string[] args)
        {
            Random dice_pick = new Random();
            string[] Dice = {"⚀", "⚁", "⚂", "⚃", "⚄", "⚅"};
            int player1_score = 0;
            int player2_score = 0;
            string player1 = "kevio";
            string player2 = "AI";
            foreach(string i in Dice)
            {
                Console.WriteLine(i);
            }
            for(int i = 0; i < 11; i++)
            {
                int num1 = dice_pick.Next(0, 6);
                int num2 = dice_pick.Next(0, 6);
                int num3 = dice_pick.Next(0, 6);
                int num4 = dice_pick.Next(0, 6);
                int player1_sum = (num1 + num2 + 2);
                int player2_sum = (num3 + num4 + 2);
                Console.WriteLine("Welcome to Dice Game.🎲🎲");
                Console.ReadKey();
                Console.WriteLine(player1 + " score: " + player1_score + " and " + player2 + " score: " + player2_score);
                Console.WriteLine(player1 + " dice roll was: " + Dice[num1] + " " + Dice[num2]);
                Console.WriteLine(player1_sum);
                Console.WriteLine(player2 + " dice roll was: " + Dice[num3] + " " + Dice[num4]);
                Console.WriteLine(player2_sum);

                if(player1_sum > player2_sum)
                {
                    player1_score++;
                    Console.WriteLine("You Win");
                }
                else if(player2_sum > player1_sum)
                {
                    player2_score++;
                    Console.WriteLine("AI Win");
                }
                else
                {
                    Console.WriteLine("Draw no point");
                }
            }
            if(player1_score > player2_score)
            {
                Console.WriteLine("🎲 " + player1 + " wins the game with a total score of " + player1_score + ".🎲");
            }
            else if(player2_score > player1_score)
            {
                Console.WriteLine("🎲 " + player2 + " wins the game with a total score of " + player2_score + ".🎲");
            }
        }
    }
}
