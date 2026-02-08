int GetValidatedIntegerInput(string prompt, int min, int max)
{
    // The function ensures that the input is a valid integer and falls within the specified minimum and maximum range
    //  It will repeatedly prompt the user until valid input is provided.
    
    int input; 
    bool isValid; 

    do
    {
        Console.Write(prompt); 
        isValid = int.TryParse(Console.ReadLine(), out input); 

        if (!isValid)
        {
            Console.WriteLine("Invalid input. Please enter a number."); 
        }
        else if (input < min || input > max) 
        {
            Console.WriteLine($"Number must be between {min} and {max}"); 
            isValid = false; 
        }

    } while(!isValid);

    return input; 
}

Console.WriteLine("= GUESS THE NUMBER =");
Console.WriteLine("Guess a number (1-10). You get 4 tries. Good luck!");    
Console.WriteLine("Find the secret number!");

string continuePlaying = "y"; 

do
{
    int numberToGuess = new Random().Next(1, 11);

    int maxAttempts = 4; 
    int attemptsMade = 1;  

 
    int userGuess = GetValidatedIntegerInput($"Attemp ({attemptsMade}/{maxAttempts}): ", 1, 10); 

    while (attemptsMade <= maxAttempts && userGuess != numberToGuess)
    {
        if (userGuess < numberToGuess)
        {
            Console.WriteLine("Too low"); 
        }
        else if (userGuess > numberToGuess)
        {
        Console.WriteLine("Too high"); 
        }
        else
        {
            break;  
        }
        attemptsMade++;
        if (attemptsMade > maxAttempts) break; 
        userGuess = GetValidatedIntegerInput($"Attemp ({attemptsMade}/{maxAttempts}): ", 1, 10);  
    }

    if (attemptsMade > maxAttempts && userGuess != numberToGuess)
    {
        Console.WriteLine("GAME OVER! Out of attempts.");
        Console.WriteLine($"The number was: {numberToGuess}");
    }
    else
    {
        Console.WriteLine("YOU WON! Correct guess!"); 
        Console.WriteLine($"Attempts: {attemptsMade}");
    }

    Console.WriteLine("Do you want to play again: (y/n)"); 
    continuePlaying = Console.ReadLine() ?? ""; 
}while(continuePlaying == "y"); 
