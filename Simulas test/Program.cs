ChestState currentState = ChestState.Closed;

do
{
    Console.WriteLine($"The current chest state is {currentState}");
    Console.WriteLine($"Enter chest state you want?");
    string state = Console.ReadLine();

    switch (state)
    {
        case "closed":
            if (currentState == ChestState.Closed) { 
               currentState = ChestState.Open;
            }
                

            break;
        case "open":
            currentState = ChestState.Open;
            break;

            
    }

} while (true);






enum ChestState { Open,Closed,Locked}