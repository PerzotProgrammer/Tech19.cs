namespace Kolekcje;

class Program
{
    static void Main()
    {
        // 1. Stwórzcie tablicę 115 pierwszych liczb, 
        // które w repreznetacji binarnej kończą się na 11
        // 11, 111, 1011, 1111, .....
        //
        // 2. Stwórzcie plik o nazwie osoby z zawartością 5 osob:
        //
        // imie; nazwisko ; wiek
        // Bartosz;Nowak;43
        // Paweł;Kowal;19
        // Krystyna;Zrybnika;21
        //
        // i wstawcie do tablicy obiekty (struktury) typu osoba 
        // z właściwościami / polami z pliku, czyli imie, nazwisko, wiek
        //
        //
        // 3. Stwórz listę 6 losowych słów składających się z 3 różnych samogłsek (List, ArrayList)
        //
        // 4. Stwórz kolejkę (queue) 4 losowych liczb fibonacciego < 100 (mogą się powtarzać). 
        //     Wyświetl kolejkę, usuń z niej 2 elementy i wyświetl pozostałe 2
        //
        // 5. Stwórz stos (stack) 5 kolejnych dwucyfrowych liczb pierwszych.
        //     Wyświetl stos, usuń 3 wyrazy i zwów wyświetl stos.

        Zad2();
        Console.WriteLine();
        Zad3();
        Console.WriteLine();
        Zad4();
        Console.WriteLine();
        Zad5();
    }

    static void Zad2()
    {
        StreamReader streamReader = new("../../../Persons.txt");

        Person[] persons = new Person[5];
        int licznik = 0;

        while (!streamReader.EndOfStream)
        {
            Person person = new();
            string[] data = streamReader.ReadLine()!.Split(";");

            person.name = data[0];
            person.surname = data[1];
            person.age = Convert.ToInt32(data[2]);

            persons[licznik++] = person;
        }

        foreach (Person person in persons) Console.WriteLine(person.GetInfo());
        streamReader.Close();
    }

    static void Zad3()
    {
        Random random = new();
        List<char> samogloski = ['a', 'e', 'i', 'o', 'u', 'y', 'ó'];
        string[] outputs = new string[6];

        for (int i = 0; i < 6; i++)
        {
            List<char> used = new();
            string buffer = "";
            for (int j = 0; j < 3; j++)
            {
                bool flag = true;
                char now = samogloski[random.Next(0, samogloski.Count)];
                while (flag)
                {
                    if (!used.Contains(now))
                    {
                        flag = false;
                        used.Add(now);
                    }
                    else now = samogloski[random.Next(0, samogloski.Count)];
                }

                buffer += now;
                used.Add(now);
            }

            if (outputs.Contains(buffer)) i--;
            else outputs[i] = buffer;
        }

        foreach (string output in outputs) Console.WriteLine(output);
    }

    static void Zad4()
    {
        Random random = new();
        Queue<int> queue = new();
        List<int> fibos = new();

        for (int i = 0;; i++)
        {
            int curr = Fibonacci(i);
            if (curr > 100) break;
            fibos.Add(curr);
        }

        // foreach (int fibo in fibos) Console.WriteLine(fibo);

        for (int i = 0; i < 4; i++) queue.Enqueue(fibos[random.Next(0, fibos.Count)]);

        foreach (int fibo in queue) Console.WriteLine(fibo);
        Console.WriteLine();
        queue.Dequeue();
        queue.Dequeue();
        foreach (int fibo in queue) Console.WriteLine(fibo);
    }

    static void Zad5()
    {
        Stack<int> stack = new();
        int[] primes = [11, 13, 17, 19, 23];

        for (int i = 0; i < 5; i++) stack.Push(primes[i]);

        foreach (int prime in stack) Console.WriteLine(prime);
        Console.WriteLine();
        stack.Pop();
        stack.Pop();
        stack.Pop();
        foreach (int prime in stack) Console.WriteLine(prime);
    }

    static int Fibonacci(int n)
    {
        switch (n)
        {
            case < 1:
                return 0;
            case < 3:
                return 1;
            default:
                return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}

struct Person
{
    public string name;
    public string surname;
    public int age;

    public string GetInfo()
    {
        return $"Imie i nazwisko: {name} {surname} - wiek: {age}";
    }
}