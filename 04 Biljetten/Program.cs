/* Skapa en klass MovieTicket med fälten 'MovieTitle' (string) och 'Price' (double). Lägg till en boolesk
egenskap 'IsUsed' och en metod UseTicket() som kollar om den redan är förbrukad. */

MovieTicket t1 = new MovieTicket();
t1.isUsed = false;
Console.WriteLine(t1.isUsed);

t1.UseTicket(); //Vill se att den välkomnar in när isUsed är false

t1.UseTicket(); //Vill se att den har satt isUsed till true i förra metodanropningen











class MovieTicket
{
    public string movieTitle;
    public double price;
    public bool isUsed {  get; set; }

    public void UseTicket()
    {
        if (isUsed)
        {
            Console.WriteLine("Biljetten är förbrukad, annan biljett behövs!");
        }

        else
        {
            Console.WriteLine("Välkommen in");
            isUsed = true;
        }
    }
}