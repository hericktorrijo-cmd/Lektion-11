/* Skapa en klass StepCounter med ett privat fält för antal steg. Skapa metoder för AddStep(), Reset()
och en publik egenskap Steps för att läsa av värdet. */

StepCounter one = new StepCounter();


one.AddStep();
Console.WriteLine($"Antal steg: {one.Steps}");
one.AddStep();
Console.WriteLine($"Antal steg: {one.Steps}");
one.Reset();
Console.WriteLine($"Antal steg efter Reset: {one.Steps}");




class StepCounter
{
    private int amountSteps;
    public int Steps
    {
        get { return amountSteps; }
    }

    public void AddStep()
    {
        Console.Write("Antal steg du vill addera: ");
        bool worked = int.TryParse(Console.ReadLine(), out int steps);
        if(worked)
        {
            this.amountSteps += steps;
        }
        else
        {
            Console.WriteLine("Ogiltig inmatning!");
        }
    }
    public void Reset()
    {
       this.amountSteps = 0;
        
    }
}