using PA4;
using PA4.models;
using PA4.interfaces;

MainGame();



static void MainGame()
{
    string player1, player2;
    Rules();

    System.Console.WriteLine("Player 1, please select a character:\n");
    player1 = Console.ReadLine();

    System.Console.WriteLine("Player 2, please select a character:\n");
    player2 = Console.ReadLine();
    System.Console.WriteLine("Player 1 selected {0}, and Player 2 selected {1}.\n", player1, player2);
        

    Attack1(player1);
    Attack2(player2);
}

static void Rules()
{
    System.Console.WriteLine("Welcome to Pirates of the Carribean World's End Game");
    System.Console.WriteLine("*****************************************************");
    System.Console.WriteLine("The rules of the game are as follows:\n 1. This is a 2 player game.\n 2. Each player picks their character.\n 3. The characters will go back and forth attacking and defending until one player's health is zero. ");
    System.Console.WriteLine("*****************************************************\n");
}


static void Attack1(string player1)
{
    
    if(player1 == "Will Turner")
    {
        Character will = new WillTurner();
        System.Console.WriteLine("*** Player One: Stats for Will Turner ***\n");
        will.Stats();
        will.attackBehavior.Attack();
        will.SetMaxPower();
    }
    else if(player1 == "Jack Sparrow")
    {
        Character jack = new JackSparrow();
        System.Console.WriteLine("*** Player One: Stats for Jack Sparrow ***\n");
        jack.Stats();
        jack.attackBehavior.Attack();
        jack.SetMaxPower();
    }
    else if(player1 == "Davy Jones")
    {
        Character davy = new DavyJones();
        System.Console.WriteLine("*** Player One: Stats for Davy Jones ***\n");
        davy.Stats();
        davy.attackBehavior.Attack();
        davy.SetMaxPower();
    }
    else
    {
        System.Console.WriteLine("You picked a character that does not exist. Try again");   
    }
}

static void Attack2(string player2)
{
    if(player2 == "Will Turner")
    {
        Character will = new WillTurner();
        System.Console.WriteLine("*** Player Two: Stats for Will Turner ***");
        will.Stats();
        will.attackBehavior.Attack();
        will.SetMaxPower();
    }
    else if(player2 == "Jack Sparrow")
    {
        Character jack = new JackSparrow();
        System.Console.WriteLine("*** Player Two: Stats for Jack Sparrow ***");
        jack.Stats();
        jack.attackBehavior.Attack();
        jack.SetMaxPower();
    }
    else if(player2 == "Davy Jones")
    {
        Character davy = new DavyJones();
        System.Console.WriteLine("*** Player Two: Stats for Davy Jones ***");
        davy.Stats();
        davy.attackBehavior.Attack();
        davy.SetMaxPower();
    }
    else
    {
        System.Console.WriteLine("You picked a character that does not exist. Try again");   
    }
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




        

 
