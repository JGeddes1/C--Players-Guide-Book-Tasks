// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, there my beauty World!");
// level 1 stuff
//string name;
//Console.WriteLine("What is your name?");
//name = Console.ReadLine();
//Console.WriteLine("Hi " + name);








//level 8 

Console.Title = "Defense of Consolas";

Console.Write("Target Row? ");
int row = Convert.ToInt32(Console.ReadLine());

Console.Write("Target Column? ");
int column = Convert.ToInt32(Console.ReadLine());

Console.ForegroundColor = ConsoleColor.Red;

Console.WriteLine($"({row}, {column - 1})");
Console.WriteLine($"({row - 1}, {column})");
Console.WriteLine($"({row}, {column + 1})");
Console.WriteLine($"({row + 1}, {column})");

Console.Beep();