PasswordValidator validator = new PasswordValidator("asd");


while (true)
{
    Console.Write("Please enter password");
    string? password = Console.ReadLine();

    if (password == null) break; // If the user enters a null password (Ctrl+Z) then let's be done.
                                 // An alternative could be to make `IsValid` handle null or to fall
                                 // back to some default string like the empty string ("") instead.
                                 // This challenge doesn't specifically call out dealing with null,
                                 // and it isn't easy to get a null in there in the first place. If
                                 // you ignored this possibility, that's fine too.

    if (validator.IsValid(password)) Console.WriteLine("That password is valid.");
    else Console.WriteLine("That password is not valid.");
}
public class PasswordValidator
{
    private string _password { get; set; }

    public bool IsValid(string password)
    {
        if (passwordLength(password)) return true;
        if (!HasUppercase(password)) return false;
        if (!HasLowercase(password)) return false;
        return false;


       
    }

    public PasswordValidator(string password)
    {
        _password = password;
    }

    public Boolean passwordLength(string password)
    {
        if (password.Length > 6 && password.Length < 13)
            return true;
        else return false;



    }

    private bool HasUppercase(string password)
    {
        foreach (char letter in password)
            if (char.IsUpper(letter)) return true;

        return false;
    }

    private bool HasLowercase(string password)
    {
        foreach (char letter in password)
            if (char.IsLower(letter)) return true;

        return false;

    }


}