using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCommand
{
    class Program
    {
        static void Main(string[] args)
        {
            RemoteControl rc = new RemoteControl();

            HiFiVez hiFiVez = new HiFiVez();
            var vypniVezCommand = new GenericCommand(x => hiFiVez.Vypni());

            Svetlo obyvak = new Svetlo() { Nazev = "Obyvak" };
            Svetlo kuchyn = new Svetlo() { Nazev = "Kuchyn" };

            rc.SetCommand(0, new GenericCommand( x=>obyvak.Zapni()), new GenericCommand(x => obyvak.Vypni()));
            rc.SetCommand(1, new GenericCommand(x => kuchyn.Zapni()), new GenericCommand(x =>kuchyn.Vypni()));
            rc.SetCommand(2, new GenericCommand(x => { hiFiVez.Zapni(); hiFiVez.SetCD();hiFiVez.SetHlasitost(11);}), vypniVezCommand);
            rc.SetCommand(3, new GenericCommand(x => { hiFiVez.Zapni(); hiFiVez.SetRadio(); hiFiVez.SetHlasitost(9); }), vypniVezCommand);

            Console.WriteLine(rc.ToString());

            rc.StiskOnButton(1);
            rc.StiskOnButton(3);
            rc.StiskOnButton(5);

            rc.StiskOffButton(2);
            rc.StiskOffButton(5);
            rc.StiskOffButton(1);

            Console.ReadKey();
        }
    }
}
