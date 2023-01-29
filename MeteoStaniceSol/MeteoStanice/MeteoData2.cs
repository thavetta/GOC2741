namespace MeteoStanice;

//Implementuje Observer pattern
class MeteoData2 : ISubject
{
    private int tlak;
    private int teplota;
    private int vlhkost;

    private readonly List<IObserver> observers = new();
	
    public void PridejObserver(IObserver? o)
    {
        //Zde je na rozhodnuti architekta, zda se bude pridavat null, nebo se vrati vyjimka, nebo se to ignoruje
        //Povolit pridani null je jednodussi, ale je to nebezpecne
        if (o is null)
            return;
        //Nic nepridame 2x (rozhodnuti architekta, neni vyzadovano patternem)
        if (observers.Contains(o))
            return;

        observers.Add(o);
    }

    public void OdeberObserver(IObserver o)
    {
        //Pri odebirani neni duvod nic testovat
        observers.Remove(o);
    }

    //Tato metoda je public jen kvuli knizce, v praxi by byla private
    public void InformujObservery()
    {
        foreach (var o in observers)
        {
            //je predani dat touto cestou (tri parametry) idealni?
            o.Update(teplota, tlak, vlhkost);
        }
    }

    public void ZmenaStavu(int teplota,int tlak, int vlhkost)
    {
        this.teplota = teplota;
        this.tlak = tlak;
        this.vlhkost = vlhkost;
        InformujObservery();
    }
}