
Tamagotchi ny = new Tamagotchi();
ny.Namn = "Smiley";
ny.PrintStatus();
ny.Play();
ny.PrintStatus();
ny.Feed();
ny.PrintStatus();

class Tamagotchi
{
    public string Namn { get; set; }

    public int hunger;
    public int Hunger
    {
        get { return hunger; }
        set
        {
            if (value < 0)
            {
                hunger = 0;
            }
            else if (value > 10)
            {
                hunger = 10;
            }
            else
            {
                hunger = value;
            }
        }
    }


    public Tamagotchi()
    {
        Hunger = 2;
    }

    public void Play()
    {
        Console.WriteLine($"\n{Namn} is playing, it will increase hunger");
        Hunger += 2;
    }

    public void Feed()
    {
        Console.WriteLine($"\n{Namn} is eatying, it will decrease hunger");
        Hunger -=5;
    }

    public void PrintStatus()
    {
        Console.WriteLine($"\nNamn: {Namn}");
        Console.WriteLine($"Hunger: {Hunger}");
    }
}