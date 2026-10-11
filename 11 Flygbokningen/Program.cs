/*Skapa en klass FlightBooking med max antal platser och en lista/array med passagerarnamn. Lägg 
till en metod BookSeat(string name) som kollar tillgänglighet innan bokning slutförs.*/

FlightBooking p1 = new FlightBooking();
p1.BookSeat("Anders");
p1.BookSeat("Herick");
p1.ShowSeats();
p1.BookSeat("Anders");






class FlightBooking
{
    private int _maxSeats;
    private string[] _passangerName;

    public void BookSeat(string name)
    {
        for(int i = 0; i < _passangerName.Length; i++)
        {

            if (_passangerName[i] != null)
            {
                continue;
            }
            else
            {
                _passangerName[i] = name;
                break;
            }
        }
    }

    public void ShowSeats()
    {
        foreach (string s in _passangerName)
        {
            Console.WriteLine(s);
        }
    }

    public FlightBooking()
    {
        _maxSeats = 20;
        _passangerName = new string[_maxSeats]; 
    }




}