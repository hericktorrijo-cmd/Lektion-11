/*Skapa en klass Hero med hälsa (HP) och erfarenhetspoäng (XP). Använd en konstruktor för att sätta
startvärden. Lägg till en metod TakeDamage(int damage) där karaktären dör om HP når 0.*/






Hero p1 = new Hero();
p1.TakeDamage(100);






class Hero
{
    private int _hp;
    private int _exp;

    public int HP
    {
        get { return _hp; }
    }

    public int Exp
    {
        get { return _exp; }
    }

    public void TakeDamage(int hp)
    {
        _hp -= hp;

        if (_hp <= 0)
        {
            _hp = 0;
            Console.WriteLine("YOU ARE DEAD!");
        }
    }

    public Hero()
    {
        _hp = 100;
        _exp = 1000;
    }


}