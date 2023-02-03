namespace SimpleCommand;

public class Button
{
    public ICommand? AkceCommand { get; set; }

    public void StiskTlacitka()
    {
        AkceCommand?.Execute();
    }

}