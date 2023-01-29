namespace MeteoStanice;

//Tato trida by resila predpoved dat v budoucnu na zaklade informaci z minulosti
//Trend teploty, tlaku, vlhkosti...
class ForecastDisplay : IObserver, IDisplayElement
{
    public void Update(int teplota, int tlak, int vlhkost)
    {
        Console.WriteLine("Predpoved dostala hodnoty");
    }

    public void DisplayData()
    {
        Console.WriteLine("Informace z ferecast view");
        Console.WriteLine("Tady by byla predpoved");
        Console.WriteLine();
    }
}