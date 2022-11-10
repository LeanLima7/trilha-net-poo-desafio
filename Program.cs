using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "11940409898", modelo: "Lumia 640XL", imei: "0101", memoria: 8);
nokia.Ligar();
nokia.InstalarAplicativo("SHEIN");

Console.WriteLine("---------------------------------");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "11998984040", modelo: "12 mini", imei: "1010", memoria: 256);
iphone.Ligar();
iphone.InstalarAplicativo("Spotfy");

Console.WriteLine("---------------------------------");

Console.WriteLine("Smartphone Motorola");
Smartphone motorola = new Motorola(numero: "11998984040", modelo: "12 mini", imei: "1010", memoria: 256);
iphone.Ligar();
iphone.InstalarAplicativo("Spotfy");

