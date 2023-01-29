namespace Kachny;

public class DomaciKachna : Kachna 
{ 
    public DomaciKachna()
    {
        this.SchopnostKvakat = new KlasickeKvak();
        this.SchopnostLetat = new LetaniPomalu(); 
    }
}
