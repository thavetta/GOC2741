namespace MeteoStanice;

//Spatne, neflexibilni reseni.
//Kazda zmena vyzaduje vyznamny zasah do kodu.
//Nejde menit okna dynamicky.
class MeteoData1
{
    public ActualDisplay ObrazovkaAktualniPocasi { get; set; }
    public HistoryDisplay ObrazovkaHistoriePocasi { get; set; }
    public ForecastDisplay ObrazovkaPredpovedPocasi { get; set; }

    //Tyto tri metody simuluji zjisteni udaje od HW meteostanice
    private int GetTeplota()
    {
        return 10;
    }

    private int GetTlak()
    {
        return 1000;
    }

    private int GetVlhkost()
    {
        return 60;
    }

    public void ZmenaStavu()
    {
        int teplota = GetTeplota();
        int tlak = GetTlak();
        int vlhkost = GetVlhkost();

        ObrazovkaAktualniPocasi.Update(teplota, tlak, vlhkost);
        ObrazovkaHistoriePocasi.Update(teplota, tlak, vlhkost);
        ObrazovkaPredpovedPocasi.Update(teplota, tlak, vlhkost);

    }

}