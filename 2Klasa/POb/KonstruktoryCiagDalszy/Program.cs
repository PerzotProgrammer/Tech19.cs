using KonstruktoryCiagDalszy.Classes;

namespace KonstruktoryCiagDalszy;

class Program
{
    static void Main()
    {
        Random random = new();
        List<Person> persons = new();
        string[] names = { "Adam", "Paweł", "Janusz", "Mateusz" };
        string[] surnames = { "Nowak", "Kowalski", "Pawłowski", "Jankowski" };


        for (int i = 0; i < 5; i++)
            persons.Add(new(names[random.Next(0, names.Length)], surnames[random.Next(0, surnames.Length)], random.Next(20, 50)));

        persons.Add(new());
        persons.Add(new("Adam", "Nowak"));
        persons.Add(new("Adam", "Nowak", 30, 176));

        foreach (Person person in persons)
        {
            Console.WriteLine(person.GetData());
        }
    }
}