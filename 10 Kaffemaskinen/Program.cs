/*Skapa en klass CoffeeMachine med fält för vattenmängd och kaffebönor. Skapa en metod 
BrewCoffee() som drar av resurser och varnar om något saknas.*/

CoffeMachine p1 = new CoffeMachine();
p1.BrewCoffee();
p1.BrewCoffee();
p1.BrewCoffee();





class CoffeMachine
{
    private int _waterLiter;
    private int _coffeBeans;

    public void BrewCoffee()
    {
        _waterLiter -= 30;
        _coffeBeans -= 30;

        if(_waterLiter < 30)
        {
            Console.WriteLine($"Varning! {_waterLiter} liter vatten kvar i maskinen, fyll på!");
        }
        if (_coffeBeans < 30)
        {
            Console.WriteLine($"Varning! {_coffeBeans} bönor kvar i maskinen, fyll på!");
        }
    }

    public CoffeMachine()
    {
        _waterLiter = 100;
        _coffeBeans = 100;
    }
}