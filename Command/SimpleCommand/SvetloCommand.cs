namespace SimpleCommand;

public class SvetloCommand : ICommand
{
    public Svetlo? Svetlo { get; set; }

    public void Execute()
    {
        Svetlo?.ZmenStav();
    }
}