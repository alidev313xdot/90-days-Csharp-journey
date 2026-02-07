Console.WriteLine("== Guessing Game ==");
Console.WriteLine("In this game, you have to guess a number between 1 and 100. You have 6 chances to guess the correct number. Good luck!");    
Console.WriteLine("Let's see in how many guesses you can find the correct number!");

int numberToGuess = new Random().Next(1, 101);

Console.Write("Enter your guess: ");
int userGuess = Convert.ToInt32(Console.ReadLine());

int totalGuess = 6; 
int currentGuess = 0;  

while (currentGuess <= totalGuess && userGuess != numberToGuess)
{
    currentGuess++;
    if (userGuess < numberToGuess)
    {
        Console.WriteLine("Too loo, try again!"); 
        Console.WriteLine($"Guess left: {totalGuess - currentGuess}");  
    }
    else if (userGuess > numberToGuess)
    {
        Console.WriteLine("Too high, try again!"); 
        Console.WriteLine($"Guess left: {totalGuess - currentGuess}");
    }
    else
    {
        break;  
    }
    Console.Write("Enter your guess again: ");
    userGuess = Convert.ToInt32(Console.ReadLine()); 
}

if (currentGuess > totalGuess && userGuess != numberToGuess)
{
    Console.WriteLine("Game over! You've used all your guesses.");
    Console.WriteLine($"The correct number was: {numberToGuess}");
}
else
{
    Console.WriteLine("You won! You guessed correct!"); 
    Console.WriteLine($"Took guesses: {++currentGuess}");
}
