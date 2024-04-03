using FasadyCiagDalszy.Classes;

namespace FasadyCiagDalszy;

class Program
{
    static void Main()
    {
        // Stwórz fasadę salonu urody, składającej się z:
        // - Lokalu
        // - Lista osób zatrudnionych
        // - Lista wyposażenia

        List<Worker> workers = new();
        workers.Add(new Barber("Adam", "Nowak", 25, 3000));
        workers.Add(new Makeuper("Ada", "Nowakowa", 25, 3000));
        workers.Add(new Manicurist("Ala", "Nowacka", 25, 3000));

        List<Equipment> equipments = new();
        equipments.Add(new("Lakier do paznokci"));
        equipments.Add(new("Nożyczki do włosów"));
        equipments.Add(new("Puder do nosa"));

        Building building = new("Morelowa 13", "123 456 789", 5000);
        
        Workplace workplace = new(building, workers, equipments);
        workplace.ChceckWorkers();
        workplace.CheckEquipment();
        workplace.CheckLocation();
    }
}