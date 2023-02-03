namespace GenericCommand;

public interface ICommand
{
    void Execute(object? parameter);
}