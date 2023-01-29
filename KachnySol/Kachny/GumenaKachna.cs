namespace Kachny;

public class GumenaKachna : Kachna
{
	public GumenaKachna()
	{
		this.SchopnostKvakat = new PiskaveKvakani();
		this.SchopnostLetat = new NeLetani();
	}
}
