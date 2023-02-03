using Ovladac;

RemoteControl rc = new();

HiFiVez hiFiVez = new();
var vypniVezCommand = new HiFiOffCommand(hiFiVez);

Svetlo obyvak = new() { Nazev = "Obyvak" };
Svetlo kuchyn = new() { Nazev = "Kuchyn" };

rc.SetCommand(0, new ZapniSvetloCommand(obyvak), new VypniSvetloCommand(obyvak));
rc.SetCommand(1, new ZapniSvetloCommand(kuchyn), new VypniSvetloCommand(kuchyn));
rc.SetCommand(2, new CdOnCommand(hiFiVez), vypniVezCommand);
rc.SetCommand(3, new RadioOnCommand(hiFiVez), vypniVezCommand);

Console.WriteLine(rc.ToString());

rc.StiskOnButton(1);
rc.StiskOnButton(3);
rc.StiskUndoButton();
rc.StiskOnButton(5);

rc.StiskOffButton(2);
rc.StiskOffButton(5);
rc.StiskOffButton(1);

Console.ReadKey();
