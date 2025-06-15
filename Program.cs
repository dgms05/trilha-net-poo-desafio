using DesafioPOO.Models;

// DONE: Realizar os testes com as classes Nokia e Iphone

// Testando classe Nokia
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia("123456789", "Nokia 3310", "ABC123XYZ", 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

// Testando classe Iphone
Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone("987654321", "iPhone 14", "XYZ789ABC", 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");