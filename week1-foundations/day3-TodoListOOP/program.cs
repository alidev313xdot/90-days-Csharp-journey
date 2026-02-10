Console.WriteLine("== Todo App using OOP ==\n"); 

List<TodoItem> todos = new(); 

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
    Console.Write("Enter title of your todo: "); 
    string title = Console.ReadLine() ?? ""; 
    
    TodoItem myTodo = new(title); 

    if (todos.Any(t => t.Title == title))
    {
        Console.WriteLine("This todo already exist!"); 
    }
    else {
        todos.Add(myTodo); 
        Console.WriteLine("Todo Added successfully!"); 
        Console.WriteLine(); 
    } 
}

// 2. View Todo 
bool viewTodos()
{
    int countItems = todos.Count; 
    if (countItems == 0)
    {
        Console.WriteLine("\nYour Todo List is Empty for now! Choose 1 to add more items.\n"); 
        return false; 
    }

    Console.WriteLine(); 
    Console.WriteLine("-- Your Todo List --");
    Console.WriteLine("S.No\t\tTitle\t\t\tCompleted\t\tCreate Date"); 

    for (int i = 0; i < countItems; i++)
    {
        Console.Write($"{i + 1}. ");
        Console.Write($"\t\t{todos[i].Title}"); 

        string done = todos[i].IsCompleted == true ? "✔️" : "";
        Console.Write($"\t\t[{done}] "); 

        Console.WriteLine($"\t\t\t{todos[i].CreatedDate}");  
    }
    Console.WriteLine(); 
    return true; 
}

// 3. Mark as done
void markasDone()
{
    // shows all todos, (done, and undone)
    if (!viewTodos()) return; 
    int option = GetValidatedUserInput("Select todo to mark as done:  ", 1, todos.Count); 

    if (todos[option - 1].IsCompleted)
    {
        Console.WriteLine("The todo is already marked as done!"); 
    }
    else
    {
        todos[option - 1].IsCompleted = true;
        Console.WriteLine("Todo marked as done successfully!");    
    }
    Console.WriteLine(); 
}

// 4. Delete Todo 
void deleteTodo()
{
    // shows all todos, (done, and undone)
    if (!viewTodos()) return; 
    int option = GetValidatedUserInput("Select todo to delete: ", 1, todos.Count); 
    todos.RemoveAt(option - 1); 
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

class TodoItem
{
    public string Title { get; set; }
    public bool IsCompleted { get; set; } 
    public DateTime CreatedDate {get; set;}
    public TodoItem (string title) {
        Title = title; 
        IsCompleted = false; 
        CreatedDate = DateTime.Now; 
    }    
}
