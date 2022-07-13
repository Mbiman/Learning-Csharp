using System;

internal class GuessGame
{
    public string Guess()
    {
        Console.Write("Player 1, Enter Name: ");
        string player1 = Console.ReadLine();
        Console.Write("Player 2, Enter Name: ");
        string player2 = Console.ReadLine();
        Console.WriteLine();

        Console.WriteLine(player1 + " You are Player 1");
        Console.WriteLine(player2 + " You are Player 2");
        Console.WriteLine();

        Console.Write(player1 + ", Enter a Word: ");
        string secretWord = Console.ReadLine();
        Console.WriteLine();
        string guess = "";
        int guessCounter = 0;

        while (guess != secretWord && guessCounter != 3)
        {
            Console.WriteLine(player2 + ", Enter guess: ");
            guess = Console.ReadLine();
            guessCounter++;
            Console.WriteLine();
        }
        if (secretWord == guess)
        {
            Console.WriteLine(player2 + ", you win!!!");
        }
        else
        {
            Console.WriteLine(player1 + ", you win!!!");
        }
        return "";
    }
}
