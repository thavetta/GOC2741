namespace MeteoStanice;

class Program
{
    static void Main(string[] args)
    {
        MeteoData2 meteo = new MeteoData2();

        ActualDisplay aktual = new ActualDisplay();
        meteo.PridejObserver(aktual);

        ForecastDisplay predpoved = new ForecastDisplay();
        meteo.PridejObserver(predpoved);

        HistoryDisplay statistika = new HistoryDisplay();
        meteo.PridejObserver(statistika);

        //Simulace informaci o zmene stavu na meteostanici
        meteo.ZmenaStavu(30,1000,60);
        meteo.ZmenaStavu(31,1010,61);
        meteo.ZmenaStavu(32, 1005, 59);
        meteo.ZmenaStavu(31, 1000, 58);
        meteo.ZmenaStavu(30, 995, 60);

        //Simulace uzivatele koukajiciho se na ruzna view
        aktual.DisplayData();
        statistika.DisplayData();
        predpoved.DisplayData();

        Console.ReadKey();
    }
}