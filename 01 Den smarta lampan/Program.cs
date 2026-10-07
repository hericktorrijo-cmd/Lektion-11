SmartLamp minLampa = new SmartLamp();

Console.WriteLine(minLampa.isOn);
Console.WriteLine(minLampa.brightness);

Console.WriteLine("\nEfter metod tillämpning");
Console.WriteLine();

minLampa.isOn = true;
minLampa.SetBrightness(0);

Console.WriteLine(minLampa.isOn);
Console.WriteLine(minLampa.brightness);



class SmartLamp 
{
    public bool isOn = false;
    public int brightness;


    public void Toggle()
    {
        isOn = !isOn;
    }

    public void SetBrightness(int bright)
    {
        if(bright < 0 || bright > 100)
        {
            Console.WriteLine("Fungerar inte, måste vara mellan 0 - 100");
        }
        else
        {
            brightness = bright;
        }
    }
}