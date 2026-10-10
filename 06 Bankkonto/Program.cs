/*Skapa en klass BankAccount med privata fält för kontonummer och saldo. Implementera metoder
för Deposit(double amount) och Withdraw(double amount) med logik som förhindrar negativa
uttag eller övertrassering.*/


BankAccount p1 = new BankAccount();
p1.Deposit(200);
p1.ShowSaldo();

p1.Withdraw(3000);

p1.ShowSaldo();





class BankAccount
{
    private int kontoNummer;
    private double saldo;

    public double Saldo
    {
        get { return saldo; }
    }
    public void Deposit(double amount)
    {
        saldo += amount;
    }
    public void Withdraw(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("ERROR, Du måste ta ut minst 1 kr");
        }
        else if(amount > saldo)
        {
            Console.WriteLine("ERROR, Inte tillräckligt med pengar i kontot");
        }
        else
        {
            saldo -= amount;
        }
    }
    public void ShowSaldo()
    {
        Console.WriteLine($"Saldo: {Saldo}");
    }


}