using DesafioPOO.Models;

Smartphone sp = new Iphone("15991003882", "13", "001970-01-010000-0", 32);
sp.InstalarAplicativo("WhatsApp");
sp.Ligar();
Console.WriteLine(sp.Memoria);

Smartphone sp2 = new Nokia("15991003885", "1", "001810-01-020000-0", 8);
sp2.InstalarAplicativo("Instagram");
sp2.Ligar();
sp2.ReceberLigacao();

