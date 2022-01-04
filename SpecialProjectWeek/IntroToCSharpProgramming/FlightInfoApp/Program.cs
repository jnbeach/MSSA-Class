Console.Clear();
Console.WriteLine("Flight Info App");
Console.WriteLine("------------------------------------");

Console.WriteLine($"Where is this flight coming from?");
string origin = Console.ReadLine();
Console.WriteLine($"Where is this flight going?");
string destination = Console.ReadLine();
Console.WriteLine($"This is a Boeing 737 flight going from {origin} to {destination}");
Console.WriteLine($"Populating flight info now:");
Plane Boeing737number1 = new Plane(188, origin, destination);

string userInput = "notZero";

while (userInput != "0")
{
    Console.WriteLine($"This is a Boeing 737 flight going from {origin} to {destination}");
    Console.WriteLine($"Please select one of the following options:");
    Console.WriteLine($"1: Add a passenger");
    Console.WriteLine($"2: Remove a passenger");
    Console.WriteLine($"3: Print seat status");
    Console.WriteLine($"4: Edit a passenger");
    Console.WriteLine($"0: Exit");
    userInput = Console.ReadLine();
    switch (userInput)
    {
        case "1":
            Console.WriteLine($"Please enter a first name:");
            string firstName = Console.ReadLine();
            Console.WriteLine($"Please enter a last name:");
            string lastName = Console.ReadLine();
            Passenger newPassenger = new Passenger(firstName, lastName, ref Boeing737number1);
            Boeing737number1.PassengerList.Add(newPassenger);
            Console.Clear();
            Console.WriteLine($"{firstName} {lastName} has been added to the flight.");
            break;
        case "2":
            Console.WriteLine($"Please input the seat number of the passenger you would like to remove: (Input 0 to cancel)");
            int seatNumberToRemove = Convert.ToInt32(Console.ReadLine());
            if (seatNumberToRemove != 0)
            {
                string tempFirst = Boeing737number1.PassengerList[seatNumberToRemove + 1].FirstName;
                string tempLast = Boeing737number1.PassengerList[seatNumberToRemove + 1].LastName;
                Boeing737number1.PassengerList.RemoveAt(seatNumberToRemove + 1);
                Console.Clear();
                Console.WriteLine($"{tempFirst} {tempLast} has been removed.");
            }
            break;
        case "3":
            Console.Clear();
            Console.WriteLine($"Passenger List");
            Console.WriteLine($"----------------------------");
            foreach (Passenger passenger in Boeing737number1.PassengerList)
            {
                Console.WriteLine($"{passenger.SeatNumber}: {passenger.FirstName} {passenger.LastName}");
            }
            Console.WriteLine($"----------------------------");
            Boeing737number1.GetOccupiedSeats();
            Boeing737number1.GetEmptySeats();
            Console.WriteLine($"----------------------------");
            break;
        case "4":
            Console.Clear();
            Console.WriteLine($"Please input the seat number of the passenger you would like to edit: (Input 0 to cancel)");
            int seatNumberToEdit = Convert.ToInt32(Console.ReadLine());
            if (seatNumberToEdit != 0)
            {
                Passenger editedPassenger = Boeing737number1.PassengerList[seatNumberToEdit - 1];
                Console.WriteLine($"Please enter a first name:");
                string editFirstName = Console.ReadLine();
                Console.WriteLine($"Please enter a last name:");
                string editLastName = Console.ReadLine();
                editedPassenger.FirstName = editFirstName;
                editedPassenger.LastName = editLastName;
                Console.Clear();
                Console.WriteLine($"{editFirstName} {editLastName} has been removed.");
            }
            break;
        case "0":
            break;
        default:
            break;
    }

}

public class Plane
{
    public int TotalSeats;
    public int OccupiedSeats;
    public string Origin;
    public string Destination;

    public List<Passenger> PassengerList;

    public Plane(int SeatCapacity, string origin, string destination)
    {
        this.TotalSeats = SeatCapacity;
        this.OccupiedSeats = 0;
        this.Origin = origin;
        this.Destination = destination;
        this.PassengerList = new List<Passenger>();
    }
    public void GetOccupiedSeats()
    {
        Console.WriteLine($"There are {this.OccupiedSeats} occupied seats.");
    }
    public void GetEmptySeats()
    {
        int emptySeats = this.TotalSeats - this.OccupiedSeats;
        Console.WriteLine($"There are {emptySeats} empty seats remaining on this plane.");
    }
}

public class Passenger
{
    public string FirstName;
    public string LastName;
    public int SeatNumber;

    public Passenger(string firstName, string lastName, ref Plane currentPlane)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        currentPlane.OccupiedSeats++;
        this.SeatNumber = currentPlane.OccupiedSeats;
    }
}