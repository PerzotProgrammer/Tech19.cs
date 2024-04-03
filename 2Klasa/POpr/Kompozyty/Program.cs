using Kompozyty.Classes;

namespace Kompozyty;

class Program
{
    static void Main()
    {
        // Zakoduj osoby w firmie.
        // Jest szef, który ma pod sobą dyrektora finansów i kierownika logistyki.
        // Pod dyrektorem finansów jest księgowa a pod logistykiem spedytor, magazynier i kierowca.
        // Stwórz to na bazie kompozytu

        Worker shipper = new("Bogusław", "Polański", "Spedytor");
        Worker warehouseman = new("Zdzisław", "Mogilski", "Magazynier");
        Worker driver = new("Ryan", "Gosling", "Kierowca");
        Chief headOfLogistic = new("Mariusz", "Mariacki", "Kierownik logistyki");
        headOfLogistic.AddPersons(shipper, warehouseman, driver);

        Worker accountant = new("Marianna", "Ulańska", "Księgowa");
        Chief headOfFinances = new("Maniek", "Szalony", "Kierownik finansów");
        headOfFinances.AddPersons(accountant);
        
        Chief headChief = new("Adam", "Nowak", "Szef wszystkich szefów");
        headChief.AddPersons(headOfLogistic, headOfFinances);
    }
}