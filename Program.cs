using PA4;
using PA4.models;
using PA4.interfaces;

MainGame();

static void Rules()
{
    System.Console.WriteLine("Welcome to Pirates of the Carribean World's End Game");
    System.Console.WriteLine("*****************************************************");
    System.Console.WriteLine("The rules of the game are as follows:\n 1. This is a 2 player game.\n 2. Each player picks their character.\n 3. The characters will go back and forth attacking and defending until one player's health is zero. ");
    System.Console.WriteLine("*****************************************************\n");
}


static void MainGame()
{
    string player1, player2;
    Character p1Char, p2Char; // declare variables to store each player's selected character

    Rules();

    System.Console.WriteLine("Player 1, please select a character:\n");
    player1 = Console.ReadLine();

    System.Console.WriteLine("Player 2, please select a character:\n");
    player2 = Console.ReadLine();
    
    p1Char = SelectCharacter(player1);
    p2Char = SelectCharacter(player2); 

    System.Console.WriteLine("Press Enter to Begin Attack Sequence");
    Console.ReadKey(); //stops to see stats
    

    if(p1Char == null || p2Char == null)
    {
        System.Console.WriteLine("One or both players selected an invalid character. Game cannot continue.");
        return;
    }
    // alternate attacks until one player's health is zero
    bool p1Turn = true;
    while(p1Char.health > 0 && p2Char.health > 0)
    {
        if(p1Turn)
        {
            System.Console.WriteLine(p2Char.attackStrength); 
            System.Console.WriteLine("*** Player One's Turn ***");
            p1Char.attackBehavior.Attack(); // player 1 attacks player 2
            double damageDealt = (p1Char.attackStrength - p2Char.defensivePower);
            if (damageDealt < 0) 
            {
                damageDealt = 0;
            }
            p2Char.health -= damageDealt;
            Console.ForegroundColor = ConsoleColor.Blue;
            System.Console.WriteLine("\n{0}'s New Stats:", p2Char.name);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            System.Console.WriteLine("Damage Dealt: {0}", damageDealt);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine("Health: {0}\n", p2Char.health);
            Console.ResetColor();
            Console.ReadKey();
        }
        else
        {
            System.Console.WriteLine("*** Player Two's Turn ***");
            p2Char.attackBehavior.Attack(); // player 2 attacks player 1
            double damageDealt = (p2Char.attackStrength - p1Char.defensivePower);
            if (damageDealt < 0) 
            {
                damageDealt = 0;
            }
            p1Char.health -= damageDealt;
            Console.ForegroundColor = ConsoleColor.Blue;
            System.Console.WriteLine("\n{0}'s New Stats:", p1Char.name);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            System.Console.WriteLine("Damage Dealt: {0}", damageDealt);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine("Health: {0}\n", p1Char.health);
            Console.ResetColor();
            Console.ReadKey();
        }

        p1Turn = !p1Turn; // switch turns
    }

    // declare the winner
    if(p1Char.health > 0)
    {
        System.Console.WriteLine("*** Player One Wins! ***");
    }
    else
    {
        System.Console.WriteLine("*** Player Two Wins! ***");
    }
}

static Character SelectCharacter(string playerName)
{
    Character selectedCharacter = null;

    if(playerName == "Will Turner")
    {
        selectedCharacter = new WillTurner();
        selectedCharacter.Stats();
    }
    else if(playerName == "Jack Sparrow")
    {
        selectedCharacter = new JackSparrow();
        selectedCharacter.Stats();
    }
    else if(playerName == "Davy Jones")
    {
        selectedCharacter = new DavyJones();
        selectedCharacter.Stats();
    }
    else
    {
        System.Console.WriteLine("You picked a character that does not exist. Try again");   
    }

    return selectedCharacter;
    
}


    


    // static void MainGame()
// {
//     string player1, player2;
//     Character characterp1, characterp2;
//     Rules();


//     System.Console.WriteLine("Player 1, please select a character:\n");
//     player1 = Console.ReadLine();
//     Stats(player1);

//     System.Console.WriteLine("Player 2, please select a character:\n");
//     player2 = Console.ReadLine();
//     Stats2(player2);

//     System.Console.WriteLine("Player 1 selected {0}, and Player 2 selected {1}.\n", player1, player2);

//     AttackSequence();
// }

// static void AttackSequence()
// {
    
// }


// static void Stats(string player1)
// {
    
//     if(player1 == "Will Turner")
//     {
//         Character will = new WillTurner();
//         System.Console.WriteLine("*** Player One: Stats for Will Turner ***\n");
//         will.Stats();
//     }
//     else if(player1 == "Jack Sparrow")
//     {
//         Character jack = new JackSparrow();
//         System.Console.WriteLine("*** Player One: Stats for Jack Sparrow ***\n");
//         jack.Stats();
        
//     }
//     else if(player1 == "Davy Jones")
//     {
//         Character davy = new DavyJones();
//         System.Console.WriteLine("*** Player One: Stats for Davy Jones ***\n");
//         davy.Stats();
//     }
//     else
//     {
//         System.Console.WriteLine("You picked a character that does not exist. Try again"); 

//     }
// }

// static void Stats2(string player2)
// {
//     if(player2 == "Will Turner")
//     {
//         Character will = new WillTurner();
//         System.Console.WriteLine("*** Player Two: Stats for Will Turner ***");
//         will.Stats();
//     }
//     else if(player2 == "Jack Sparrow")
//     {
//         Character jack = new JackSparrow();
//         System.Console.WriteLine("*** Player Two: Stats for Jack Sparrow ***");
//         jack.Stats();
//     }
//     else if(player2 == "Davy Jones")
//     {
//         Character davy = new DavyJones();
//         System.Console.WriteLine("*** Player Two: Stats for Davy Jones ***");
//         davy.Stats();
//     }
//     else
//     {
//         System.Console.WriteLine("You picked a character that does not exist. Try again");   
//     }
// }







        

 
