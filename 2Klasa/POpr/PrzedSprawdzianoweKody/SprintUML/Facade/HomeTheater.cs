namespace SprintUML.Facade;

public class HomeTheater
{
    private Projector Projector;
    private SoundSystem SoundSystem;
    private MediaPlayer MediaPlayer;

    public HomeTheater(MediaPlayer mediaPlayer)
    {
        Projector = new();
        SoundSystem = new();
        MediaPlayer = mediaPlayer;
    }

    public void WatchMovie()
    {
        Projector.On();
        SoundSystem.On();
        MediaPlayer.Play();
    }

    public void EndMovie()
    {
        Projector.Off();
        SoundSystem.Off();
        MediaPlayer.Stop();
    }
}