namespace Kachny;

class Program
{
	static void Main(string[] args)
	{
		OtestujKachnu(new DivokaKachna());
		OtestujKachnu(new DomaciKachna());
		OtestujKachnu(new DrevenaKachna());
		OtestujKachnu(new GumenaKachna());
	}

	private static void OtestujKachnu(Kachna kachna)
	{
		Console.WriteLine(kachna.ToString());
		kachna.Kvakej();
		kachna.Let();
		kachna.Plavej();
		Console.WriteLine();
	}
}
