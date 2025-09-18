namespace HermetyzacjaDziedziczenie;

public class VacuumCleaner : Device
{
    private bool _isActive;

    public VacuumCleaner()
    {
        _isActive = false;
    }

    public void TurnOn()
    {
        if (_isActive) return;
        _isActive = true;
        Report("Włączono odkurzacz");
    }

    public override void GetStatus()
    {
        Report(_isActive ? "Odkurzacz jest aktywny" : "Odkurzacz jest nieaktywny");
    }
}