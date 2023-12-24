using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia("223145", "Modelo d20", "2345", 64);
nokia.Ligar();
nokia.ReceberLigacao();
Console.WriteLine($"Dados do Smatphone: Número: {nokia.Numero}");
nokia.InstalarAplicativo("Deezer");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone("123456", "Nokia Modelo X", "123WE32", 64);
iphone.Ligar();
iphone.ReceberLigacao();
Console.WriteLine($"Dados do Smartphone: Número: {iphone.Numero}");
iphone.InstalarAplicativo("Globo Play");
