/*Skapa en klass Thermostat med en egenskap för CurrentTemperature. Om temperaturen sätts över
30 eller under 15 grader ska ett varningsmeddelande skrivas ut till konsolen via egenskaps-settern.*/


using System.Runtime.CompilerServices;

Thermostat p1 = new Thermostat();
p1.CurrentTemperature = 12;

Thermostat p2 = new Thermostat();
p2.CurrentTemperature = 18;







class Thermostat
{

    private int currentTemperature; 
    public int CurrentTemperature
    {
        get { return currentTemperature; }
        set
        {
            currentTemperature = value;
            if (value > 30 || value < 15)
            {
                Console.WriteLine("Varning!");
            }
        }
    }

}