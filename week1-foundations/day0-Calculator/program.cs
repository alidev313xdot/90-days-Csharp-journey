Console.WriteLine("== CALCULATOR =="); 
Console.WriteLine("Let's build this!");

string continueCalculating = "y"; 

while (continueCalculating == "y")
{
    Console.Write("Enter the first number: "); 
    int firstNumber = Convert.ToInt32(Console.ReadLine()); 

    Console.Write("Enter the second number: "); 
    int secondNumber = Convert.ToInt32(Console.ReadLine()); 

    Console.WriteLine("Enter the operation (+, -, *, /): ");
    string? operationInput = Console.ReadLine();
    string operation = operationInput ?? "";
    
    decimal result = 0; 


    if (operation != "+" && operation != "-" && operation != "*" && operation != "/")
    {
        Console.WriteLine("Invalid operator. Please enter one of the following: +, -, *, /");
        continue; 
    }

    if (operation == "+")
    {
        result = firstNumber + secondNumber; 
    }
    else if (operation == "-")
    {
        result = firstNumber - secondNumber; 
    }
    else if (operation == "*")
    {
        result = firstNumber * secondNumber; 
    }
    else if (operation == "/")
    {
        if (secondNumber == 0)
        {
            Console.WriteLine("Cannot divide by 0."); 
            continue; 
        }
        else
        {
            result = (decimal) firstNumber / secondNumber; 
        }
    }
    else
    {
        Console.WriteLine("Please! Input the mentioned operator"); 
    }
    Console.WriteLine($"Result: {firstNumber} {operation} {secondNumber} = {result}"); 
    Console.WriteLine("Do you want to perform another calculation? (y/n): ");
    continueCalculating = Console.ReadLine() ?? "n";
}
