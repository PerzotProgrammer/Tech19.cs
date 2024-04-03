namespace FasadyCiagDalszy.Classes;

public class Workplace
{
    private Building Building;
    private List<Worker> Workers;
    private List<Equipment> Equipments;

    public Workplace(Building building, List<Worker> workers, List<Equipment> equipments)
    {
        Building = building;
        Workers = workers;
        Equipments = equipments;
    }

    public void ChceckWorkers()
    {
        Console.WriteLine("Workers:");
        foreach (Worker worker in Workers)
        {
            worker.Work();
        }
    }

    public void CheckEquipment()
    {
        Console.WriteLine("Equipments:");
        foreach (Equipment equipment in Equipments)
        {
            Console.WriteLine(equipment.GetName());
        }
    }

    public void CheckLocation()
    {
        Console.WriteLine(Building.GetInfo());
    }
}