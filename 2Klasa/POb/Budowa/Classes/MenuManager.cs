using Budowa.Classes.Vehicles;

namespace Budowa.Classes;

public class MenuManager
{
    private List<ConstructionManager> ConstructionCompanies = new();
    private ConstructionManager? SelectedCompany;

    public void ShowMenu()
    {
        Console.WriteLine("Witaj w menadżerze firm budowlanych!");
        bool loop = true;
        while (loop)
        {
            Console.WriteLine();
            Console.WriteLine("Wybierz operacje:");
            Console.WriteLine("1. zarejestruj firmę");
            Console.WriteLine("2. zmień firmę");
            Console.WriteLine("3. dodaj maszyny");
            Console.WriteLine("4. zacznij pracować");
            Console.WriteLine("5. zatankuj maszyny");
            Console.WriteLine("6. zatrzymaj maszyny");
            Console.WriteLine("7. pokaż maszyny");
            Console.WriteLine("8. zamknij program");
            Console.Write("Twój wybór: ");
            string? opt = Console.ReadLine();
            Console.WriteLine();
            switch (opt)
            {
                case "1":
                    RegisterCompany();
                    break;
                case "2":
                    SwitchCompany();
                    break;
                case "3":
                    AddVehicle();
                    break;
                case "4":
                    GetToWork();
                    break;
                case "5":
                    RefuelVehicles();
                    break;
                case "6":
                    StopVehicles();
                    break;
                case "7":
                    ShowVehicles();
                    break;
                case "8":
                    loop = false;
                    break;
                default:
                    Console.WriteLine("Niepoprawna operacja!");
                    break;
            }

            Console.WriteLine();
        }

        Console.WriteLine("Dziękujemy za skorzystanie z programu!");
    }

    private void RegisterCompany()
    {
        Console.Write("Podaj nazwę firmy: ");
        string name = Console.ReadLine()!;
        SelectedCompany = new(name);
        ConstructionCompanies.Add(SelectedCompany);
        Console.WriteLine("Operacja zakończona pomyślnie!");
    }

    private void SwitchCompany()
    {
        Console.WriteLine("Zarejestrowane firmy:");
        for (int i = 0; i < ConstructionCompanies.Count; i++)
            Console.WriteLine($"{i}. {ConstructionCompanies[i].Name}");
        Console.Write("Wybierz numer firmy: ");
        int index = int.Parse(Console.ReadLine()!);
        SelectedCompany = ConstructionCompanies[index];
        Console.WriteLine("Operacja zakończona pomyślnie!");
        Console.WriteLine($"Wybrano firmę: {SelectedCompany.Name}");
    }

    private void AddVehicle()
    {
        if (IsCompanyNull())
        {
            Console.WriteLine("Nie wybrano żadnej firmy!");
            return;
        }

        Console.Write("Podaj model: ");
        string model = Console.ReadLine()!;
        Console.Write("Podaj markę: ");
        string brand = Console.ReadLine()!;
        Console.WriteLine("Wybierz typ maszyny:");
        Console.WriteLine("1. Koparka");
        Console.WriteLine("2. Wywrotka");
        Console.WriteLine("3. Dźwig");
        Console.WriteLine("4. Ciągnik siodłowy");
        Console.WriteLine("5. Betoniarka");
        Console.Write("Twój wybór:");
        string opt = Console.ReadLine()!;
        switch (opt)
        {
            case "1":
                SelectedCompany!.AddVehicle(model, brand, VehicleType.Excavator);
                break;
            case "2":
                SelectedCompany!.AddVehicle(model, brand, VehicleType.Trolley);
                break;
            case "3":
                SelectedCompany!.AddVehicle(model, brand, VehicleType.Crane);
                break;
            case "4":
                SelectedCompany!.AddVehicle(model, brand, VehicleType.Tractor);
                break;
            case "5":
                SelectedCompany!.AddVehicle(model, brand, VehicleType.ConcreteMixer);
                break;
            default:
                Console.WriteLine("Nie ma takiego typu maszyny!");
                break;
        }
    }

    private void GetToWork()
    {
        if (IsCompanyNull())
        {
            Console.WriteLine("Nie wybrano żadnej firmy!");
            return;
        }

        SelectedCompany!.GetAllVehiclesToWork();
    }

    private void RefuelVehicles()
    {
        if (IsCompanyNull())
        {
            Console.WriteLine("Nie wybrano żadnej firmy!");
            return;
        }

        Console.Write("Podaj ile jednostek paliwa chcesz zatankować (float po kropce): ");
        float fuelAmount = float.Parse(Console.ReadLine()!);

        SelectedCompany!.RefuelAllVehicles(fuelAmount);
    }

    private void StopVehicles()
    {
        if (IsCompanyNull())
        {
            Console.WriteLine("Nie wybrano żadnej firmy!");
            return;
        }

        SelectedCompany!.StopAllVehicles();
    }

    private void ShowVehicles()
    {
        if (IsCompanyNull())
        {
            Console.WriteLine("Nie wybrano żadnej firmy!");
            return;
        }

        Console.WriteLine($"Firma {SelectedCompany!.Name} posiada maszyny: ");
        foreach (Vehicle vehicle in SelectedCompany!.Vehicles)
        {
            Console.WriteLine(vehicle.GetLongName());
        }
    }

    private bool IsCompanyNull()
    {
        return SelectedCompany == null;
    }
}