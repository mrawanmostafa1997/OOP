//Q1 : What is an interface in C#? Why do we use interfaces
//instead of depending on concrete classes directly? Mention at
//least three benefits of using interfaces.
// An interface in C# is a contract that defines a set of methods, properties, events, or indexers that a class must implement.
// It does not provide any implementation itself, but rather specifies what members a class must have to be considered as implementing the interface.
// We use interfaces instead of depending on concrete classes directly for several reasons:
// 1) Abstraction: Interfaces allow us to define a contract without worrying about the implementation details.
// This promotes abstraction and allows us to focus on what the class should do rather than how it does it.
// 2) Flexibility: By depending on interfaces, we can easily swap out different implementations without changing the code that uses the interface.
// This promotes flexibility and makes our code more adaptable to change.
// 3) Testability: Interfaces make it easier to write unit tests for our code,
// as we can create mock implementations of the interface to test different scenarios without relying on concrete classes.
// 4) Multiple Inheritance: C# does not support multiple inheritance of classes, but a class can implement multiple interfaces.
// This allows us to achieve a form of multiple inheritance and design more complex systems.

//Q2 : Look at the following code and answer the questions below:
//using OOP05;

//interface IEnglishSpeaker
//{
//    void Greet();
//}
//interface IArabicSpeaker
//{
//    void Greet();
//}
//class Translator : IEnglishSpeaker, IArabicSpeaker
//{
//    public void Greet()
//    {
//        Console.WriteLine("Hello / Ahlan");
//    }
//}

//a) What is the problem with this design? Both interfaces have a method called Greet() —how does the class handle it currently?
// The problem with this design is that both interfaces have a method called Greet(),
// and the Translator class implements both interfaces without providing a way to differentiate between the two Greet() methods.
// Currently, the Translator class has a single implementation of the Greet() method, which does not specify which interface's Greet() method it is implementing.
// This can lead to confusion and ambiguity when calling the Greet() method on an instance of the Translator class.


//b) How would you fix this so IEnglishSpeaker.Greet() says "Hello" andIArabicSpeaker.Greet() says "Ahlan"? What is this technique called?
// To fix this issue, we can use explicit interface implementation. This technique allows us to provide separate implementations for each interface's Greet() method.
// Here is how we can implement it:
// class Translator : IEnglishSpeaker, IArabicSpeaker
// {    
//     void IEnglishSpeaker.Greet() 
//     {    
//         Console.WriteLine("Hello");
//     }
//     void IArabicSpeaker.Greet()
//     {
//         Console.WriteLine("Ahlan");
//     }
// }
// With explicit interface implementation, we can call the Greet() method for each interface like this:


//c) After applying your fix, can you call Greet() directly on a Translator object (e.g.
//translator.Greet())? Why or why not? How do you call each version?
// After applying the fix with explicit interface implementation, you cannot call Greet() directly on a Translator object (e.g., translator.Greet()) because the Greet() method is not accessible through the Translator class directly.
// Instead, you need to cast the Translator object to the specific interface to call each version of the Greet() method. For example:
// Translator translator = new Translator();
// ((IEnglishSpeaker)translator).Greet(); // This will call the English Greet() method and print "Hello"
// ((IArabicSpeaker)translator).Greet(); // This will call the Arabic Greet() method and print "Ahlan"


//Q3 : Explain the difference between a shallow copy and a
//deep copy. When would you use each one? What is the risk of
//using a shallow copy when the object has reference-type fields?
//----------------------------
// A shallow copy of an object creates a new object and copies the values of the fields of the original object to the new object. However,
// if the original object has reference-type fields (e.g., objects, arrays), the shallow copy will copy the references to those fields rather than creating new instances of them.
// This means that both the original and the shallow copy will reference the same objects in memory.
//----------------------------
// A deep copy, on the other hand, creates a new object and also creates new instances of any reference-type fields,
// effectively creating a completely independent copy of the original object.


//Q4 : Look at the following code and determine the output.Explain why.
//class Department { public string Name; }
//class Employee
//{
//    public string Title;
//    public Department Dept;
//    public Employee ShallowCopy() => (Employee)this.MemberwiseClone();
//}
//var e1 = new Employee { Title = "Dev", Dept = new Department { Name = "IT" } };
//var e2 = e1.ShallowCopy();
//e2.Title = "QA";
//e2.Dept.Name = "Testing";
//Console.WriteLine($"{e1.Title} - {e1.Dept.Name}");
//Console.WriteLine($"{e2.Title} - {e2.Dept.Name}");
// Output:  
// Dev - Testing
// QA - Testing
// Explanation: In this code, we have an Employee class with a ShallowCopy method that creates a shallow copy of the Employee object using MemberwiseClone().
// When we create e1 and then create e2 as a shallow copy of e1, both e1 and e2 reference the same Department object in memory.
// When we change e2.Title to "QA", it does not affect e1.Title, so e1.Title remains "Dev".
// However, when we change e2.Dept.Name to "Testing", it affects e1.Dept.Name as well because both e1 and e2 reference the same Department object.


//Part 02 : Practical (Extending the Movie Ticket Booking System)

using OOP02;
using OOP05;

Console.WriteLine("=== Cinema Opened ===");
Cinema myCinema = new Cinema("IMAX","City Cneter Almaza");

// b. Create one of each ticket type with hardcoded data. 
// (Note: To get the final price of 200 for VIP, we pass 166.67 because it multiplies by 1.2)
// (To get the final price of 130 for IMAX, we pass 100 because it multiplies by 1.3)
StandardTicket t1 = new StandardTicket("Inception", 80, "A5");
VIPTicket t2 = new VIPTicket("Avengers", 166.67, true);
IMAXTicket t3 = new IMAXTicket("Dune", 100, true);

// Book all three and add them to the Cinema
t1.Book();
t2.Book();
t3.Book();

myCinema.AddTicket(t1);
myCinema.AddTicket(t2);
myCinema.AddTicket(t3);

// c. Print all tickets through the Cinema.
Console.WriteLine("--- All Tickets ---");
myCinema.Print();

// d. Clone a VIP ticket, change the clone's movie name, and print both to prove independence.
Console.WriteLine("--- Clone Test ---");
VIPTicket clonedVIP = (VIPTicket)t2.Clone("Interstellar");

Console.Write("Original : ");
t2.Print();
Console.Write("Clone    : ");
clonedVIP.Print();

// e. Cancel one ticket and reprint it to show the updated status.
Console.WriteLine("--- After Cancellation ---");
t1.Cancel();
t1.Print();

// f. Use the utility method to print an array of printable tickets.
Console.WriteLine("--- BookingHelper.PrintAll ---");
IPrintable[] printableTickets = new IPrintable[] { t1, t2, t3 };
foreach (var ticket in printableTickets)
{
    ticket.Print();

}
// g. Close the Cinema.
Console.WriteLine("=== Cinema Closed ===");