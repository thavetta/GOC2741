namespace Kachny;
/// <summary>
/// Příklad na DP Strategy
/// Abstraktní třída Kachna umožňuje změnu schopnosti létání a kvákaní 
/// přiřazením požadovaného typu do property SchopnostLetat a SchopnostKvakat
/// </summary>
public abstract class Kachna
{

    public IKvakani? SchopnostKvakat { get; set; }
    
    public ILetani? SchopnostLetat    { get; set; }
        

    public void Let()
	{
            if (SchopnostLetat == null)
                throw new InvalidOperationException("Neni nastavena SchopnostLetat");

            SchopnostLetat.Letim();
	}

	public void Kvakej()
	{
            if (SchopnostKvakat == null)
                throw new InvalidOperationException("Neni nastavena SchopnostKvakat");

            SchopnostKvakat.Kvakam();
	}

	public void Plavej()
	{
		Console.WriteLine("Plavu");
	}
}
