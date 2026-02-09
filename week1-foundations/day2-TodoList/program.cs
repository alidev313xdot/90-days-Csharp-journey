Console.WriteLine("== Todo List ==");
List<string> list = new();  
List<bool> isCompleted = new(); 

int GetValidatedUserInput(string prompt, int min, int max)
{
    int input; 
    bool isValid = false; 

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
    }while(!isValid);

    return input;  
}

// 1. Add Todo
// return true if item is added or false in case item already exist 
void addTodo()
{
    Console.Write("Enter your todo: "); 
    string todoItem = Console.ReadLine() ?? ""; 
    
    if (list.Contains(todoItem))
    {
        Console.WriteLine("This todo already exist!"); 
    }
    else {
        list.Add(todoItem);
        isCompleted.Add(false); 
        Console.WriteLine("Todo Added successfully!"); 
        Console.WriteLine(); 
    } 
}

// 2. View Todo 
void viewTodos()
{
    Console.WriteLine(); 
    Console.WriteLine("Your Todo List"); 
    int countItems = list.Count; 
    for (int i = 0; i < countItems; i++)
    {
        Console.Write($"{i + 1}. ");

        string done = isCompleted[i] ? "✔️" : "";
        
        Console.Write($"[{done} ] "); 
        Console.WriteLine(list[i]);   
    }
    Console.WriteLine(); 
}

// 3. Mark as done
void markasDone()
{
    // shows all todos, (done, and undone)
    viewTodos(); 
    int option = GetValidatedUserInput("Select todo to mark as done:  ", 1, list.Count); 

    if (isCompleted[option - 1])
    {
        Console.WriteLine("The todo is already marked as done!"); 
    }
    else
    {
        isCompleted[option - 1] = true;
        Console.WriteLine("Todo marked as done successfully!");    
    }
    Console.WriteLine(); 
}

// 4. Delete Todo 
void deleteTodo()
{
    // shows all todos, (done, and undone)
    viewTodos(); 
    int option = GetValidatedUserInput("Select todo to delete: ", 1, list.Count); 
    list.RemoveAt(option - 1); 
    isCompleted.RemoveAt(option - 1); 
    Console.WriteLine("Todo deleted successfully!"); 
    Console.WriteLine(); 
}

string prompt = "1.Add Todo\n2.View Todos\n3.Mark as Done\n4.Delete Todo\n5.Exit\n\nChoose option: ";
int option = GetValidatedUserInput(prompt, 1, 5); 

while (option != 5)
{
    switch (option)
    {
        case 1: 
        addTodo(); 
        break; 

        case 2: 
        viewTodos(); 
        break; 
        
        case 3: 
        markasDone(); 
        break; 
        
        case 4: 
        deleteTodo(); 
        break; 
    }
    option = GetValidatedUserInput(prompt, 1, 5); 
}
