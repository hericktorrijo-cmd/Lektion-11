


UserProfile p1 = new UserProfile();

p1.UpdateStatus("Spelar spel");





class UserProfile
{
    public string userName;
    public string email;

    public string statusText;

    public void UpdateStatus(string newStatus)
    {
        this.statusText = newStatus;
        Console.WriteLine($"Användarnamn: {userName}");
        Console.WriteLine($"Mail-adress: {email}");
        Console.WriteLine($"Status: {statusText}");

        Console.WriteLine("Status uppdaterad");
    }
}