// See https://aka.ms/new-console-template for more information
using OOP02;
using System.Net.Sockets;

Console.WriteLine("Hello, World!");

//a) Identify at least two problems with this design from an encapsulation perspective.
//public class BankAccount
//{
//    public string Owner;
//    public double Balance;
//    // the problems with this code is that we can set the balance to any value, we can also set the owner to any value, and there is no way to check the balance before withdrawing.

//    public void Withdraw(double amount)
//    {

//         Balance -= amount;

//    }
//    // the problems with this code is that we can withdraw more than the balance and it will go negative, we can also withdraw a negative amount which will increase the balance, and there is no way to check the balance before withdrawing.
    


//}


//b) Describe how you would fix this class to follow proper encapsulation principles. You do not need to write the full code.
// To fix this class, I would make the Owner and Balance fields private and provide public properties to access them. I would also add validation in the Withdraw method to ensure that the amount being withdrawn does not exceed the balance and is not negative.
// Additionally, I would provide a method to check the balance before allowing a withdrawal. This way, we can control how the balance is modified and ensure that it remains consistent with the rules of a bank account.
//public class EncabsolatedBankAccount
//{
//    private string _owner;

//    public string Owner
//    {
//        get { return _owner; }
//        set { _owner = value; }
//    }

//    private double _balance;

//    public double Balance
//    {
//        get { return _balance; }
//        set { _balance = value; }
//    }

    

//    public void Withdraw(double amount)
//    {
//        if (amount < 0)
//        {
//            throw new ArgumentException("Amount to withdraw cannot be negative.");
//        }
//        if (amount > _balance)
//        {
//            throw new InvalidOperationException("Insufficient funds.");
//        }
//        Balance -= amount;

//    }



//}
//c) Explain why exposing fields directly (as public) is considered a bad practice in OOP.
//this make access for data uncontrolable, and it can lead to bugs and security issues.
//It also makes it difficult to change the implementation of the class in the future,
//as any code that directly accesses the fields would need to be updated.
//Additionally, it violates the principle of encapsulation, which is a fundamental concept in OOP that promotes data hiding and abstraction.



// Q02 : What is the difference between a field and a property in C#? Can a property contain logic? Give an example of a read-only property that returns a calculated value.
// A field is a variable that is declared directly in a class or struct and can be accessed directly.
// A property, on the other hand, is a member that provides a flexible mechanism to read, write, or compute the value of a private field.
// Properties can contain logic in their getters and setters to control how values are accessed and modified.

//public class Circle
//{
//    private double _radius;
//    public Circle(double radius)
//    {
//        _radius = radius;
//    }
//    public double Radius
//    {
//        get { return _radius; }
//        set { _radius = value; }
//    }
//    public double Area
//    {
//        get { return Math.PI * _radius * _radius; }
//    }
//}


//Q3 : Look at the following code and answer the questions below:


//public class StudentRegister
//{
//    private string[] names  = new string[5];
//    public string this[int index]
//    {
//        get { return names[index]; }
//        set { names[index] = value; }
//    }

//}
//a) What is `this[int index]` called? Explain its purpose.
// `this[int index]` is called an indexer. It allows instances of the StudentRegister class to be indexed like an array.
// The purpose of the indexer is to provide a way to access the elements of the names array using an index,
// making it easier to manage and manipulate the collection of student names without exposing the underlying array directly.


//b) What happens if someone writes `register[10] = "Ali";` ? How would you make the indexer safer?
// If someone writes `register[10] = "Ali";`, it will throw an IndexOutOfRangeException because the index 10 is out of bounds for the names array, which has a length of 5.
// To make the indexer safer, I would add validation to check if the index is within the valid range before accessing or modifying the names array. If the index is out of bounds, I would throw an appropriate exception or handle it gracefully.

//c) Can a class have more than one indexer? If yes, give an example of when that would be useful.
// Yes, a class can have more than one indexer. This can be useful when you want to provide different ways to access the data in the class.
// For example, you could have one indexer that allows access by index and another that allows access by a string key.



//Q4 : Consider the following code and answer the questions below:
//public class Order
//{
//    public string Item;
//    public static int TotalOrders = 0;
//    public Order(string item)
//    {
//        Item = item;
//        TotalOrders++;
//    }

//}
//a) What does the `static` keyword mean on `TotalOrders`? How is it different from the `Item` field?
// The `static` keyword on `TotalOrders` means that it belongs to the class itself rather than to any specific instance of the class. It is shared among all instances of the Order class.
// The `Item` field, on the other hand, is an instance field, meaning that each instance of the Order class has its own copy of the `Item` field. Changes to the `Item` field in one instance do not affect other instances,
// while changes to `TotalOrders` affect all instances since it is static.


//b) Can a static method inside `Order` access the `Item` field directly? Why or why not?
// No, a static method inside the `Order` class cannot access the `Item` field directly because `Item` is an instance field, and static methods do not have access to instance members.
// Static methods can only access static members of the class. To access the `Item` field, a static method would need to create an instance of the `Order` class or receive an instance as a parameter.



//Part 02 : Practical (Extending the Movie Ticket Booking System)
Console.WriteLine("----- Ticket System -----");
var cinema = new Cinema("Cineplex", "Downtown");
for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"Enter Data for Ticket{i+1}");

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
    var ticket = new Ticket(movieName, price, (type)typeVal, new SeatLocation((char)seatRow, seatNumber));
    cinema.AddTicket(ticket);
}
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("-----All Tickets Info -----");
int ticketNumber = 1;
foreach (var ticket in cinema.Tickets)
{
    if (ticket != null)
    {
        Console.WriteLine($"Ticket #{ticketNumber}: {ticket.MovieName}");

        Console.WriteLine($"Movie: {ticket.MovieName}");
        Console.WriteLine($"Type: {ticket.TicketType}");
        Console.WriteLine($"Seat: Row {(char)ticket.SeatLocation.Row}, Number {ticket.SeatLocation.Number}");
        Console.WriteLine($"Price: {ticket.Price}");
        Console.WriteLine($"Total (14% tax): {ticket.CalcTotal(14)}");
        ticketNumber++;


    }
}
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("-----Search by Movie -----");

Console.WriteLine($"Enter Movie Name for Searching:");
var searchMovieName = Console.ReadLine().ToString();
var searchedTicket = cinema[searchMovieName];
if (searchedTicket == null)
{
    Console.WriteLine("Not Found");

}
else
{
    Console.WriteLine($"Movie: {searchedTicket.MovieName}");
    Console.WriteLine($"Type: {searchedTicket.TicketType}");
    Console.WriteLine($"Seat: Row {(char)searchedTicket.SeatLocation.Row}, Number {searchedTicket.SeatLocation.Number}");
    Console.WriteLine($"Price: {searchedTicket.Price}");


}


Console.WriteLine("-----Stastics -----");
Console.WriteLine($"Total Tickets Sold: {Ticket.GetTotalTicketsSold()}");

for (int i = 0; i < 2; i++)
{
    Console.WriteLine($"Booking Reference {i + 1}:{cinema.Tickets[i].TicketId}");
}


var groupPrice = BookingHelper.CalcGroupDiscount(5, 80);
Console.WriteLine($"Group Price for 5 tickets at 80 each 10% discount: {groupPrice}");
