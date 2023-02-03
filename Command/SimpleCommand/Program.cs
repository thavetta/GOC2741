using SimpleCommand;


var svetloKoupelna = new Svetlo() {Nazev = "Koupelna"};
var svetloObyvak = new Svetlo() { Nazev = "Obyvak"};

var command = new SvetloCommand();
command.Svetlo = svetloKoupelna;

var button = new Button();
button.AkceCommand = command;

button.StiskTlacitka();
button.StiskTlacitka();

command.Svetlo = svetloObyvak;

button.StiskTlacitka();
button.StiskTlacitka();

Console.ReadKey();
