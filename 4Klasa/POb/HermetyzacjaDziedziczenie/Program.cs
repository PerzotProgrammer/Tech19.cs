namespace HermetyzacjaDziedziczenie;

class Program
{
    static void Main(string[] args)
    {
        List<Device> devices = new List<Device>()
        {
            new VacuumCleaner(),
            new WashingMachine(),
            new WashingMachine(),
            new Television(),
            new VacuumCleaner(),
        };

        Random random = new Random();

        foreach (Device device in devices)
        {
            switch (device)
            {
                case VacuumCleaner vc:
                    vc.TurnOn();
                    break;
                case WashingMachine wm:
                    wm.SetWashingType(random.Next(1, 12));
                    break;
                case Television tv:
                    // TODO
                    break;
            }

            device.GetStatus();
        }
    }
}