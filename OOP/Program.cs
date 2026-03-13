// PART 01:
//Q1
var coordinate1 = new Coordinate(10, 20);
var coordinate2 = coordinate1;
coordinate2.X = 30; // This will change coordinate1.X as well, because Coordinate is a class (reference type)
Console.WriteLine($"Coordinate 1: X={coordinate1.X}, Y={coordinate1.Y}");
var point1 = new Point(10, 20);
var point2 = point1;
point2.X = 30;// This will NOT change point1.X, because Point is a struct (value type)
Console.WriteLine($"Point 1: X={point1.X}, Y={point1.Y}");


//Q2

var person1 = new Person("Alice", 30);
person1.Name = "Bob"; // This will change person1.Name to "Bob"
//person1.Age = 35; // This will cause a compile-time error, because Age is private and cannot be accessed outside the Person class


//Q3
//create new project (class library) and add reference to OOP project
Helpers.Utils.PrintMessage($"Person 1: Name={person1.Name}");


//Q4
// a class libarary is a dynamic link library (DLL) that contains reusable code,
// such as classes, methods, and properties, that can be shared across multiple projects.
// It allows developers to encapsulate functionality and promote code reuse. A class library can


// PART 02:

Console.WriteLine("----- Ticket System -----");
Console.WriteLine("Enter movie name:");
var movieName = Console.ReadLine().ToString();
Console.WriteLine("Enter ticket type (0 = Standard, 1 = VIP, 2 = IMAX):");
var typeInput = Console.ReadLine().ToString();
var typeVal = int.Parse(typeInput);
Console.WriteLine("Enter seat row (A-Z):");
var seatRowInput = Console.ReadLine().ToString();
var seatRow = Char.Parse(seatRowInput);
Console.WriteLine("Enter seat number:");
var seatNumberInput = Console.ReadLine().ToString();
var seatNumber = int.Parse(seatNumberInput);
Console.WriteLine("Enter Price:");
var priceInput = Console.ReadLine().ToString();
var price = double.Parse(priceInput);
Console.WriteLine("Enter Discount Amount:");
var discountAmountInput = Console.ReadLine().ToString();
var discountAmount = double.Parse(discountAmountInput);
Console.WriteLine("----- Ticket Info -----");
Console.WriteLine($"Movie: {movieName}");
Console.WriteLine($"Type: {(type)discountAmount}");
Console.WriteLine($"Seat: Row {(char)seatRow}, Number {seatNumber}");
Console.WriteLine($"Price: {price}");
var ticket = new Ticket(movieName, price, (type)typeVal, new SeatLocation((char)seatRow, seatNumber));

Console.WriteLine($"Total (14% tax): {ticket.CalcTotal(14)}");

Console.WriteLine("----After Discount----");
try
{
    Console.WriteLine($"Discounted Before: {discountAmount}");
    var discountedPrice = ticket.ApplyDiscount(discountAmount);

    Console.WriteLine($"Discounted After: {discountedPrice}");
    Console.WriteLine($"Movie :{ticket.MovieName}");
    Console.WriteLine($"Type :{ticket.TicketType}");
    Console.WriteLine($"Seat : Row {ticket.SeatLocation.Row}, Number {ticket.SeatLocation.Number}");
    Console.WriteLine($"Price : {discountedPrice}");
    Console.WriteLine($"Total (14% tax): {ticket.CalcTotal(14)}");




}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}


class Ticket
{
    public string MovieName { get; set; }
    private double Price { get; set; }
    public type TicketType { get; set; }
    public SeatLocation SeatLocation { get; set; }
    public Ticket(string movieName, double price, type type, SeatLocation seatLocation)
    {
        MovieName = movieName;
        Price = price;
        TicketType = type;
        SeatLocation = seatLocation;
    }
    public Ticket(string movieName) : this(movieName, 50.0, type.Standard, new SeatLocation('A', 1))
    {


    }
    public double CalcTotal(double taxPercent)
    {
        var TotalPrice = Price + (Price * taxPercent / 100);
        return TotalPrice;
    }
    public double ApplyDiscount(double discountAmount)
    {
        if (discountAmount < 0 || discountAmount > Price)
        {
            return 0.0;
        }
        Price = Price - (Price * discountAmount / 100);
        return discountAmount;
    }
    public void PrintTicket()
    {
        Console.WriteLine($"Movie: {MovieName}");
        Console.WriteLine($"Price: {Price}");
        Console.WriteLine($"Type: {TicketType}");
        Console.WriteLine($"Seat: Row {SeatLocation.Row}, Number {SeatLocation.Number}");
    }
}

struct SeatLocation
{
    public char Row { get; set; }
    public int Number { get; set; }
    public SeatLocation(char row, int number)
    {
        Row = row;
        Number = number;
    }
}
enum type
{
    Standard,
    VIP,
    IMAX,
};


class Coordinate
{
    public int X { get; set; }
    public int Y { get; set; }
    public Coordinate(int x, int y)
    {
        X = x;
        Y = y;
    }
}
struct Point
{
    public int X { get; set; }
    public int Y { get; set; }
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
}

class Person
{
    public string Name { get; set; }
    private int Age { get; set; }
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

}