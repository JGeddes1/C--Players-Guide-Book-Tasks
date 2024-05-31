int number ;


do
{
    Console.Write("User 1, enter a number between 0 and 100: ");
    number = Convert.ToInt32(Console.ReadLine());


} while ( number <  0 ||  number > 100);

Console.Clear();

Console.WriteLine("User 2, Guess the number");