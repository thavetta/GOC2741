using System.Text;

namespace GenericCommand;

public class RemoteControl
{
    private const int POCET_SLOTU = 7;

    private List<ICommand> onCommands;
    private List<ICommand> offCommands;

    public RemoteControl()
    {
        ICommand noCommand = new GenericCommand(x => {} );

        onCommands = new List<ICommand>();
        offCommands = new List<ICommand>();
        for (int i = 0; i < POCET_SLOTU; i++)
        {
            onCommands.Add(noCommand);
            offCommands.Add(noCommand);
        }
    }

    public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
    {
        CheckSlot(slot);

        this.onCommands[slot] = onCommand;
        this.offCommands[slot] = offCommand;
    }

    private static void CheckSlot(int slot)
    {
        if (slot < 0 || slot >= POCET_SLOTU)
            throw new IndexOutOfRangeException("Slot je mimo rozsah 0 - 6");
    }

    public void StiskOnButton(int slot)
    {
        CheckSlot(slot);

        onCommands[slot].Execute(null);
    }

    public void StiskOffButton(int slot)
    {
        CheckSlot(slot);

        offCommands[slot].Execute(null);
    }

    public override string ToString()
    {
        StringBuilder sb = new();
        sb.Append("--------------------- Remote Control ---------------------" + Environment.NewLine);
        for (int i = 0; i < POCET_SLOTU; i++)
        {
            sb.Append("Slot[" + i + "] " + onCommands[i].GetType().Name + "\t\t" + offCommands[i].GetType().Name + Environment.NewLine);
        }

        return sb.ToString();
    }
}