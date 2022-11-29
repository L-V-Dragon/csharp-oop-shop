using Bonus;

Prodotto prodotto1 = new Prodotto("Supplì", "Palla di riso al sugo panata", 1.50, 22);
Prodotto prodotto2 = new Prodotto("Assorbenti", "Panno assorbente per perdite mestruali", 3.50, 5);
Prodotto prodotto3 = new Prodotto("Allarme anti Incendio", "Sistema di sicurezza", 50, 10);


Console.WriteLine("Ecco dei prodotti");
Console.WriteLine();

prodotto1.StampaProdotto();
Console.WriteLine();

prodotto2.StampaProdotto();
Console.WriteLine();

prodotto3.StampaProdotto();
