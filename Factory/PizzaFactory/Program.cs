using PizzaFactory;

PizzaProdej prodejna = new PizzaProdejPraha();

prodejna.ResObjednavku("Hawai");
prodejna.ResObjednavku("Klasik");

prodejna = new PizzaProdejBrno();
prodejna.ResObjednavku("Hawai");

