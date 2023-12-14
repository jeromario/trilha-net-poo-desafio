using DesafioPOO.Models;

Smartphone nokia = new Nokia(numero: "123", modelo: "S2", imei: "k1k2", memoria: 64);
Smartphone iphone =  new Iphone(numero: "333", modelo: "14 PRO", imei: "1v2v", memoria: 128);
Console.WriteLine("Smartphone Nokia:");
nokia.Ligar();
nokia.InstalarAplicativo("Youtube");
Console.WriteLine();
Console.WriteLine("Smartphone Iphone:");
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Deezer");
