using PA4;
using PA4.models;
using PA4.interfaces;

// plainDuck.Quack();
// plainDuck.Name = "Caroline";


MainGame();

const int MAX = 100;
const int MIN = 0;

static void MainGame()
{
        Rules();
        string player1, player2;
        
        System.Console.WriteLine(Console.WriteLine);("Player 1, please select a character:");
        player1 = Console.ReadLine();

        System.Console.WriteLine(Console.WriteLine);("Player 2, please select a character:");
        player2 = Console.ReadLine();

        System.Console.WriteLine();("Player 1 selected {0}, and Player 2 selected {1}.", player1, player2);
        System.Console.WriteLine("Here are the stats for the character you chose:\n");
        if(player1 == "Will Turner")
        {
            Character will = new WillTurner();
            will.attackBehavior.Attack();
            will.SetMaxPower();
            
        }
        else if(player1 == "Jack Sparrow")
        {
            System.Console.WriteLine("inheritance js");
        }
        else if(player1 == "Davy Jones")
        {
            System.Console.WriteLine("inheritance dj");
        }
        else
        {
            System.Console.WriteLine("You picked a character that does not exist. Try again");   
        }

        
}
    
static void Rules()
{
    System.Console.WriteLine("Welcome to Pirates of the Carribean World's End Game");
    System.Console.WriteLine("*****************************************************");
    System.Console.WriteLine("The rules of the game are as follows:\n 1. This is a 2 player game.\n 2. Each player picks their character.\n 3. The characters will go back and forth attacking and defending until one player's health is zero. ");
    System.Console.WriteLine("*****************************************************");
}






    // int startHealth = 100;
    // int amount = startHealth;
    // bool quitGame = true;  
    
    // while(amount < MAX && amount > MIN && quitGame)
    // {
        
        
    //     string userInput = MainMenu();
    //     if(userInput == "1")
    //     {
    //         System.Console.WriteLine("Player One Choose Your Player:\n 1 Jack Sparrow\n 2 Davy Jones\n 3 Will Turner");
    //         return Console.ReadLine();
    //     }
    //     else if(userInput == "2")
    //     {
    //         //second character
    //     }
    //     else if(userInput == "3")
    //     {
    //        //third character
    //     }
    //     // else if(userInput == "4")
    //     // {
    //     //     Exit();
    //     // }
    //     else
    //     {
    //         System.Console.WriteLine("Error! You will now be directed to the Main Menu.");  
    //     }
    // }




        

 
