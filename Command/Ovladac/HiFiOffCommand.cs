namespace Ovladac;

public class HiFiOffCommand : ICommand
{
    private HiFiVez hifi;

    public HiFiOffCommand(HiFiVez hifi)
    {
        this.hifi = hifi;
    }
    public void Execute()
    {
        hifi.Vypni();
            
    }
}