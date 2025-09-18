namespace HermetyzacjaDziedziczenie;

public class Television : Device
{
    private List<string> _channels;
    private int _currentChannelIdx;
    private int _volumeLevel;

    public Television()
    {
        _channels = new List<string>()
        {
            "AnimalPlanet",
            "Discovery",
            "History",
            "BBC"
        };

        _currentChannelIdx = 0;
        _volumeLevel = 25;
    }


    public override void GetStatus()
    {
        Report($"Telewizor jest na kanale {_channels[_currentChannelIdx]} i ma poziom głośności {_volumeLevel}");
    }
}