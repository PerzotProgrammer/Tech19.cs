using Konstruktory.Classes;

namespace Konstruktory;

class Program
{
    static void Main()
    {
        Person person = new("Adam", "Nowak");
        person.SayHello();
    }
}