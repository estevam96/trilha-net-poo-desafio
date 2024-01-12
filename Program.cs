using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Celular Nokia:");
Smartphone nokia = new Nokia(numero: "(11) 1111-1111", modelo: "C300", imei: "123456789", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("Celular iPhone:");
Smartphone iphone = new Iphone(numero: "(11) 1234-5678", modelo: "Iphone 15", imei: "987654321", memoria: 62);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Facebook");