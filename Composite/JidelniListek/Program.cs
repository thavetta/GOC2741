using Listek;

namespace Restaurace;

class Program
{
    static void Main(string[] args)
    {
        IMenuItem Snidane = NaplnSnidani();
        IMenuItem Obed = NaplnObed();
        IMenuItem Vecere = NaplnVeceri();
        IMenuItem All = new Menu() {Nazev = "Komplet menu"};
        All.Add(Snidane);
        All.Add(Obed);
        All.Add(Vecere);

        VypisJidelniListek(All);
        Console.WriteLine("Vegetarian only");
        VypisVegetarian(All);

        Console.ReadKey();
    }

    private static void VypisVegetarian(IMenuItem menu)
    {
        if (menu.HasChild)
        {
            Console.WriteLine(menu);

            foreach (var item in menu)
            {
                VypisVegetarian(item);
            }
        }
        else
        {
            if (menu.JeVegetarianske)
                Console.WriteLine(menu);
        }
    }

    private static void VypisJidelniListek(IMenuItem menu)
    {
        Console.WriteLine(menu.Print());
    }

    private static IMenuItem NaplnVeceri()
    {
        var menu = new Menu() { Nazev = "Večera" };
        menu.Add(new MenuItem() { Nazev = "Palacinky so špenátom", Popis = "Domáce palacinky z múky so špenátom", JeVegetarianske = true, Cena = 9 });
        menu.Add(new MenuItem() { Nazev = "Medailonky", Popis = "Bravčové medailonky s opečenými zemiakmi", JeVegetarianske = false, Cena = 12 });
        return menu;
    }

    private static IMenuItem NaplnObed()
    {
        var menu = new Menu() { Nazev = "Obed" };
        menu.Add(new MenuItem() { Nazev = "Sviečková s knedľou", Popis = "Klasická sviečková s hov. mäsom a knedľou", JeVegetarianske = false, Cena = 10 });
        menu.Add(new MenuItem() { Nazev = "Vyprážaný syr s hranolkami", Popis = "Vyprážaný Eidam 40% v klasickom trojobale, nemrazený, domáce hranolky, tatarka", JeVegetarianske = true, Cena = 8 });
        var deserty = new Menu() { Nazev = "Dezerty"};
        deserty.Add(new MenuItem() {Nazev = "Gaštanové pyré", Popis = "Klasické pyré z gaštanov, so skutočnou šľahačkou",JeVegetarianske = true, Cena = 4});
        deserty.Add(new MenuItem() { Nazev = "Veterník čokoládový", Popis = "Čokoládový veternik veľký", JeVegetarianske = true, Cena = 3 });
        menu.Add(deserty);
        return menu;
    }

    private static IMenuItem NaplnSnidani()
    {
        var menu = new Menu() {Nazev = "Raňajky"};
        menu.Add(new MenuItem() {Nazev = "Praženica", Popis = "Praženica z domácich vajec na másle s cibuľkou", JeVegetarianske = true, Cena = 5});
        menu.Add(new MenuItem() { Nazev = "Párky", Popis = "Viedenske párky 80% mäsa s horčicou", JeVegetarianske = false, Cena = 6 });
        return menu;
    }
}