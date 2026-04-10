//Q1 : What is abstraction in OOP? How is it different from encapsulation? Give a real-world example (not from the session) that shows the difference between the two.

// Abstraction in OOP is the concept of hiding the complex implementation details of a system and exposing only the necessary features to the user.
// It allows us to focus on what an object does rather than how it does it.
// Encapsulation, on the other hand, is the concept of bundling data and methods that operate on that data within a single unit (class) and restricting access to some of the object's components.
// It helps to protect the internal state of an object from unauthorized access and modification.
// A real-world example that shows the difference between abstraction and encapsulation is a mobile.
// Abstraction: When you use a mobile phone, you interact with its user interface (UI) to make calls, send messages, and use apps. You don't need to know how the phone's internal components work or how the software is implemented.
// The abstraction allows you to focus on using the phone's features without worrying about the underlying complexity.
// Encapsulation: The mobile phone's internal components, such as the battery, processor, and memory, are encapsulated within the phone's casing.
// You cannot access or modify these components directly; they are protected from external interference.
// This encapsulation ensures that the phone functions properly and prevents damage to its internal parts.


//What is the difference between an abstract class and an interface? Give at least four differences. When would you choose one over the other?

// An abstract class and an interface are both used to define contracts for classes, but they have some key differences:
// 1) Implementation: An abstract class can provide both abstract and concrete methods, while an interface can only declare methods without providing any implementation.
// 2) Inheritance: A class can inherit
//from only one abstract class, but it can implement multiple interfaces. This allows for more flexibility in design when using interfaces.
// 3) Access Modifiers: In an abstract class, you can have access modifiers (e.g., public, protected, private) for its members, while in an interface, all members are implicitly public and cannot have access modifiers.
// 4) Fields: An abstract class can have fields (variables), while an interface cannot have any fields. An interface can only have properties, methods, events, or indexers.
// You would choose an abstract class when you want to provide a common base class with shared implementation for related classes, and you want to enforce a certain structure for those classes.
//You would choose an interface when you want to define a contract that multiple unrelated classes can implement, and you want to allow for more flexibility in the design by allowing classes to implement multiple interfaces.

//a) Can you write: Appliance a = new Appliance("LG"); ? Why or why not?
// No, you cannot write Appliance a = new Appliance("LG"); because Appliance is an abstract class, and you cannot instantiate an abstract class directly.

//b) What is the difference between the three methods: PowerConsumption(), Status(), and Label()? Why did the designer make each one abstract, virtual, or concrete?
// The difference between the three methods is as follows:
// - PowerConsumption() is an abstract method, which means it must be implemented by any non-abstract class that inherits from Appliance.
// The designer made it abstract because the power consumption of different appliances can vary greatly, and it is essential for each specific appliance to provide its own implementation of this method.
// - Status() is a virtual method, which means it provides a default implementation that can be overridden by derived classes if needed.
// The designer made it virtual because there may be a common way to determine the status of an appliance, but some appliances might have specific conditions that require a different implementation.
// - Label() is a concrete method, which means it has a complete implementation in the Appliance class and cannot be overridden by derived classes.
// The designer made it concrete because the label of an appliance is likely to be the same for all appliances (e.g., "This is an appliance"), and there is no need for derived classes to provide their own implementation of this method.
//c) If you call Status() on a Toaster object, what will it return? Why?
// If you call Status() on a Toaster object, it will return "Stand by" because the Toaster class inherits from the Appliance class and does not override the Status() method.
// Therefore, it uses the default implementation provided by the Appliance class, which returns "Stand by"


//a) What is a partial class? Why would a developer split Calculator into two files?
// A partial class is a class that can be split into multiple files, allowing developers to organize their code more effectively.
// A developer might split the Calculator class into two files to separate different functionalities or to allow multiple developers to work on the same class simultaneously without causing merge conflicts.

//b) What is a partial method? What happens if the OnCalculated() implementation in Calculator.Logging.cs is deleted — will the code still compile? Why?
// A partial method is a method that is declared in one part of a partial class and can be implemented in another part of the same partial class.
// If the OnCalculated() implementation in Calculator.Logging.cs is deleted, the code will still compile because partial methods are optional to implement. If a partial method is declared but not implemented,
// it will be removed by the compiler, and any calls to that method will be ignored without causing a compilation error.

//c) What is an extension method? What are the three rules for writing one?
// An extension method is a static method that allows you to add new functionality to existing types without modifying their source code or creating a new derived type.
// The three rules for writing an extension method are:
// 1) The extension method must be defined in a static class.
// 2) The extension method itself must be static.
// 3) The first parameter of the extension method must specify the type it extends, and it must be preceded by the 'this' keyword. For example:
// public static class StringExtensions
// {
//     public static bool IsNullOrEmpty(this string str)
//     {
//         return string.IsNullOrEmpty(str);
//     }
// }

//d) What will the following code print?
//Calculator calc = new Calculator();
//double result = calc.Add(19.5, 0.5);
//Console.WriteLine(result.ToCurrency());
// The code will print "20.00" because the Add method will return the sum of 19.5 and 0.5, which is 20.0,Log: result =20 and then the ToCurrency() extension method will format it as a currency string with two decimal places.
using OOP06;

//var plainTicket = new Ticket("Titanic",5000);
StandardTicket t1 = new StandardTicket("Inception", 80, "A5");
VIPTicket t2 = new VIPTicket("Avengers", 166.67, true);
IMAXTicket t3 = new IMAXTicket("Dune", 100, true);
Cinema cinema = new Cinema("Fox", "Mall Arab");
cinema.AddTicket(t1);
cinema.AddTicket(t2);
cinema.AddTicket(t3);
cinema.PrintAllTickets();
foreach (var ticket in cinema.GetTickets())
{
    Ticket t = ticket as Ticket;
    var tName =  t.GetType().Name;
    Console.WriteLine(tName);
    Console.WriteLine(ticket.GenerateReceipt());
    

}
Console.WriteLine(cinema.GetTickets().ToList().GetTotalRevenue());
cinema.CloseCinema();
