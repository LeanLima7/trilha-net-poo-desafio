using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "11940409898", modelo: "Lumia 640XL", imei: "0101", memoria: 8);
nokia.Ligar();
nokia.Desligar();
nokia.ReceberLigacao();
nokia.RecusarLigação();
nokia.InstalarAplicativo("SHEIN");

Console.WriteLine("---------------------------------");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "11998984040", modelo: "12 mini", imei: "1010", memoria: 256);
iphone.Ligar();
iphone.Desligar();
iphone.ReceberLigacao();
iphone.RecusarLigação();
iphone.InstalarAplicativo("Spotfy");

Console.WriteLine("---------------------------------");

Console.WriteLine("Smartphone Motorola");
Smartphone motorola = new Motorola(numero: "11998984040", modelo: "Edge", imei: "1110", memoria: 512);
motorola.Ligar();
motorola.Desligar();
motorola.ReceberLigacao();
motorola.RecusarLigação();
motorola.InstalarAplicativo("Lol Mobile");

