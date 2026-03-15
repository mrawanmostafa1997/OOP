//Q1 : What is the difference between static binding and dynamic binding? When does each one happen?
// Static binding (also known as early binding) occurs at compile time when the method to be called is determined based on the type of the reference variable.
// Dynamic binding (also known as late binding) occurs at runtime when the method to be called is determined based on the actual type of the object being referenced.
// Static binding happens when the method being called is not overridden in a derived class(hidden function using new with the same name of method),
// while dynamic binding happens when the method is overridden in a derived class and the reference variable is of the base class type but points to an object of the derived class type.


//Q2: What is the difference between method overloading and
//method overriding?
// Method overloading is when multiple methods in the same class have the same name but different parameters (different type, number, or order of parameters).
// It is a compile-time polymorphism.
// Method overriding is when a derived class provides a specific implementation of a method that is already defined in its base class.
// It is a runtime polymorphism and requires the use of the `virtual` keyword in the base class and the `override` keyword in the derived class.


//Q3: What keywords are used for Method Overriding? What
//does each one mean ?

// The keywords used for method overriding are `virtual`, `override`, and `abstract`.
// - `virtual`: This keyword is used in the base class to indicate that a method can be overridden in a derived class.
// - `override`: This keyword is used in the derived class to indicate that a method is overriding a virtual method in the base class.
// - `abstract`: This keyword is used in an abstract class to declare a method that must be overridden in any non-abstract derived class.
// An abstract method does not have an implementation in the base class and must be implemented in the derived class.

//Part 02 : Practical (Extending the Movie Ticket Booking System)

using OOP04;

var cinema = new Cinema("Cineplex", "Downtown");

Console.WriteLine("----- cinema Opened------");

cinema.OpenCinema();
var standard = new StandardTicket("Inception", 150, "A12");
var vip = new VIPTicket("The Godfather", 200, true);
var imax = new IMAXTicket("Avatar 3", 250, true);
Console.WriteLine("------------Set Price Test------------");
Console.WriteLine($"Setting Price directoly:");
var price = double.Parse(Console.ReadLine());
standard.SetPrice(150);

var basePrice = double.Parse(Console.ReadLine());
var multiplier = double.Parse(Console.ReadLine());
Console.WriteLine($"Setting Price with multiplier:");
standard.SetPrice(basePrice, multiplier);

Console.WriteLine("------ All Tickets ----------");

cinema.AddTicket(standard);
cinema.AddTicket(vip);
cinema.AddTicket(imax);
cinema.PrintAllTickets();
Console.WriteLine("---------Process Single Ticket----------");
standard.PrintTicket();





cinema.CloseCinema();