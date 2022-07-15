﻿using System;

public class Craps
{
    //create random-number generator for use in method RollDice
    private static Random randomNumbers = new Random();

    //enumeration with constants that represent the game status
    private enum Status {CONTINUE, WON, LOST}

    //enumeration with constants that represent common rolls of the dice
    private enum DiceNames
    {
        SNAKE_EYES = 2,
        TREY = 3,
        SEVEN = 7,
        YO_LEVEN = 11,
        BOX_CARS = 12
    }

    //plays one game of craps
    public static void Main(string[] args)
    {
        //gameStatus can contain CONTINUE, WON or LOST
        Status gameStatus = Status.CONTINUE;
        int myPoint = 0;

        int sumOfDice = RollDice(); //first roll of the dice

        //determine game status and point based on first roll
        switch ((DiceNames) sumOfDice)
        {
            case DiceNames.SEVEN: // win with 7 on first roll
            case DiceNames.YO_LEVEN: // win with 11 on the first roll
                gameStatus = Status.WON;
                break;

            case DiceNames.SNAKE_EYES: // loose with 2 on first roll 
            case DiceNames.TREY: // loose with 3 on first roll
            case DiceNames.BOX_CARS: // loose with 12 on first roll
                gameStatus = Status.LOST;
                break;

            default: //did not win or loose, so remember point
                gameStatus = Status.CONTINUE; //game is not over
                myPoint = sumOfDice; //remember the point
                Console.WriteLine("Point is {0}", myPoint);
                break;
        }// end switch statement

        //while game is not over yet
        while (gameStatus == Status.CONTINUE) // game not won or lost
        {
            sumOfDice = RollDice(); //roll dice again

            //determine game status
            if (sumOfDice == myPoint) //win by making point
            {
                gameStatus = Status.WON;
            }
            else
            // loose by rolling 7 before point
                if (sumOfDice == (int)DiceNames.SEVEN)
                {
                    gameStatus = Status.LOST;
                }
        }//end while

        //display won or lost message
        if (gameStatus == Status.WON)
            Console.WriteLine("Player wins");
        else
            Console.WriteLine("Player looses");
    } //end Main method

    //roll dice, calculate sum and display results
    public static int RollDice()
    {
        //pick random die values
        int die1 = randomNumbers.Next(1,7); //first die roll
        int die2 = randomNumbers.Next(1,7); //second die roll

        int sum = die1 + die2; //sume of die values

        //display results of this roll
        Console.WriteLine("Player rolled {0} + {1} = {2}", die1, die2, sum);
        return sum; //return sum of dice
    }// end method RollDice
}//end class Craps