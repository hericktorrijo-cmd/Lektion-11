/*Skapa en klass Safe med ett hemligt lösenord i ett privat fält som sätts via konstruktorn. Skapa en 
metod Unlock(string password) som ändrar tillståndet till upplåst om lösenordet matchar. */



Safe p1 = new Safe("Torre");

p1.UnLock("Pra");
Console.WriteLine();
p1.UnLock("Torre");







class Safe
{
    private string _passWord;
    private bool _unlocked;

    public void UnLock(string passWord)
    {
        if(passWord == _passWord)
        {
            _unlocked = true;
            Console.WriteLine($"Korrekt! Valv upplåst! Upplåst: {_unlocked}");
            
        }
        else
        {
            _unlocked = false;
            Console.WriteLine($"Fel lösenord! Upplåst: {_unlocked}");
        }
    }




    public Safe(string passWord)
    {
        _passWord = passWord;        
    }


}