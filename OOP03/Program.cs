
//Q1 : Identify the type of relationship in each scenario below (Inheritance, Association, Aggregation, Composition, or Dependency):
//1) Inheritance: IS a relationship where one class (child) inherits properties and behaviors from another class (parent).
//For example, a Dog class can inherit from an Animal class, meaning that a Dog IS an Animal.

//2) Association: HAS a relationship where one class uses or interacts with another class, but they can exist independently.
//For example, a Teacher class can have an association with a Student class, meaning that a Teacher HAS Students, but the Teacher and Students can exist independently of each other.

//3) Aggregation: HAS a relationship where one class contains another class, but the contained class can exist independently of the container class.
//For example, a Library class can have an aggregation relationship with a Book class, meaning that a Library HAS Books, but the Books can exist independently of the Library.

//4) Composition: HAS a relationship where one class contains another class, and the contained class cannot exist independently of the container class.
//For example, a Car class can have a composition relationship with an Engine class, meaning that a Car HAS an Engine, and the Engine cannot exist independently of the Car.

//5) Dependency: USES a relationship where one class depends on another class to function, but they do not have a strong relationship.
//For example, a ReportGenerator class can have a dependency on a DataSource class, meaning that the ReportGenerator USES the DataSource to generate reports, but they do not have a strong relationship and can exist independently of each other.



//a) A University has Departments. If the university is closed, the departments no longer exist. => composition 
//b) A Driver uses a Car. The driver does not own the car. => association
//c) A Dog is an Animal.=> inheritance
//d) A Team has Players. If the team is deleted, the players still exist. => aggregation
//e) A method receives a Logger as a parameter and calls it inside the method only. => dependency


//Q2: Answer the following questions about access modifiers and sealed:


//a) A parent class has a protected field. Can a child class in a different assembly access it? What about through an object instance from outside?
// No, a child class in a different assembly cannot access a protected field directly.
// However, if the child class is in a different assembly but inherits from the parent class, it can access the protected field through inheritance.


//b) What is the difference between protected internal and private protected?
// Protected internal means that the member is accessible from any class in the same assembly and from derived classes in any assembly.
// Private protected means that the member is accessible only within its own class and by derived classes in the same assembly.

//c) What does the sealed keyword do when applied to a class? What about when applied to a method?
// When applied to a class, the sealed keyword prevents other classes from inheriting from it. This means that no class can derive from a sealed class.
// When applied to a method, the sealed keyword prevents derived classes from overriding that method. This means that the implementation of the method in the base class will be used, and derived classes cannot provide their own implementation.

//d) Can you create an object from a sealed class using new? Why or why not?
// Yes, you can create an object from a sealed class using new. The sealed keyword only prevents other classes from inheriting from the sealed class, but it does not prevent you from creating instances of the sealed class.
// You can still instantiate a sealed class just like any other class.

//Part 02 : Practical (Extending the Movie Ticket Booking System)

using OOP03;

var cinema = new Cinema("Cineplex", "Downtown");

Console.WriteLine("----- cinema Opened------");
cinema.OpenCinema();
Console.WriteLine("------ All Tickets ----------");
var standard = new StandardTicket("Inception", 150, "A12");
var vip = new VIPTicket("The Godfather", 200, true);
var imax = new IMAXTicket("Avatar 3", 250, true);
cinema.AddTicket(standard);
cinema.AddTicket(vip);
cinema.AddTicket(imax);
cinema.PrintAllTickets();
Console.WriteLine("---------Statistics-----------");
Console.WriteLine($"Total Tickets created:{Ticket.GetTotalTickets()}");
Console.WriteLine("Ticket Reference 1"+standard.TicketId);
Console.WriteLine("Ticket Reference 2"+vip.TicketId);





cinema.CloseCinema();

