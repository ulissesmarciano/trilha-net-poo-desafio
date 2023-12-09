using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
// IMPLEMENTADO

Nokia nokia = new Nokia("(12)34567890", "Nokia 007", "fadacaba10", 1024);
Iphone iphone = new Iphone("(09)87654321", "iPhone 17", "abacadapra11", 4096);

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Facebook");

Console.WriteLine("----------------------------");

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Spotify");