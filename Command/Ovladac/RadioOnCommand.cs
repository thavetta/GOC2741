namespace Ovladac;

public class RadioOnCommand : ICommand
{
    private HiFiVez hifi;

    public RadioOnCommand(HiFiVez hifi)
    {
        this.hifi = hifi;
    }
    public void Execute()
    {
        hifi.Zapni();
        hifi.SetRadio();
        hifi.SetHlasitost(9);
    }
}