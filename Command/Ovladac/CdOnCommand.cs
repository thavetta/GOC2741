namespace Ovladac;

public class CdOnCommand : ICommand
{
    private HiFiVez hifi;

    public CdOnCommand(HiFiVez hifi)
    {
        this.hifi = hifi;
    }
    public void Execute()
    {
        hifi.Zapni();
        hifi.SetCD();
        hifi.SetHlasitost(11);
    }
}