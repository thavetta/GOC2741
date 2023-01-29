namespace PripravaNapoje;

public abstract class Napoj
{
    //Template metoda definuje standardni postup pripravy jakehokoliv tepleho napoje
    //Zaroven nabizi moznost pridat prilohy na zaklade dotazu
    public void Priprava()
    {
        OhrejVodu();
        PripravZaklad();
        ZalejNapoj();
        if (DotazNaPrilohu())
            PridejPrilohy();
    }

    
    private void OhrejVodu()
    {
        Console.WriteLine("Hreju vodu");
    }

    private void ZalejNapoj()
    {
        Console.WriteLine("Zalevam napoj");
    }

    //Tuto metodu potomek musi prepsat, protoze zaklad je vzdy jiny
    protected abstract void PripravZaklad();

    //Tuto metodu potomek musi prepsat, protoze nejake prilohy jsou vzdy
    protected abstract void PridejPrilohy();

    //Tuto metodu potomek muze prepsat, pokud chce, aby se dotazoval na prilohy
    protected virtual bool DotazNaPrilohu()
    {
        return true;
    }

}