namespace Kachny;

public class DivokaKachna : Kachna
{
	public DivokaKachna()
	{
		this.SchopnostKvakat = new KlasickeKvak();
		this.SchopnostLetat = new LetaniRychle();
	}
}
