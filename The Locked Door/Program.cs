int initialPasscode = GetInt("What is the initial passcode?");
Door door = new Door(initialPasscode);

while (true)
{
    Console.Write($"The door is {door.State}. What do you want to do? (open, close, lock, unlock, change code) ");
    string? command = Console.ReadLine();

    switch (command)
    {
        case "open":
            door.Open();
            break;
        case "close":
            door.Close();
            break;
        case "lock":
            door.Lock();
            break;
        case "unlock":
            int guess = GetInt("What is the passcode?");
            door.Unlock(guess);
            break;
        case "change code":
            int currentCode = GetInt("What is the current passcode?");
            int newCode = GetInt("What do you want to change it to?");
            door.ChangeCode(currentCode, newCode);
            break;
    }
}

int GetInt(string text)
{
    Console.Write(text + " ");
    return Convert.ToInt32(Console.ReadLine());
}


public class Door
{
    public LockedState State { get; private set; }
    private int _passcode;

    public Door(int passcode) {
        _passcode = passcode;
        State = LockedState.Locked;

    }

    public void Close()
    {
        if (State == LockedState.Open) State = LockedState.Closed;
    }

    public void Open()
    {
        if (State == LockedState.Closed) State = LockedState.Open;
    }

    public void Lock()
    {
        if (State == LockedState.Closed) State = LockedState.Locked;
    }

    public void Unlock(int passcode)
    {
        if (State == LockedState.Locked) 
            State = LockedState.Closed;
    }

    public void ChangeCode(int oldPasscode, int newPasscode)
    {
        if (oldPasscode == _passcode) 
            _passcode = newPasscode;
    }


}


public enum LockedState{

    Locked, Closed, Open
}