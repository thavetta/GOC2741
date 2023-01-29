namespace MeteoStanice;

//Tento soubor obsahuje zakladni rozhrani pro observer pattern
//Vsechny tridy, ktere budou pouzivat observer pattern budou muset implementovat
//tyto rozhrani
public interface IObserver
{
    void Update(int teplota, int tlak, int vlhkost);
}

public interface ISubject
{
    void PridejObserver(IObserver o);
    void OdeberObserver(IObserver o);
    //Tato metoda je zde kvuli popisu v knizce. 
    //Bezne je informovani observeru interni veci Subjectu.
    void InformujObservery();
}

//Toto rozhrani definuje metodu pro zobrazeni dat z libovolne obrazovky meteostanice
public interface IDisplayElement
{
    void DisplayData();
}