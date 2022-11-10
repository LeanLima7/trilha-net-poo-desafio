using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using DesafioPOO.Models;


namespace DesafioPOO.Models
{
    public class Motorola : Smartphone
    {
        public Motorola(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Instalando aplicativo " + nomeApp + " no Motorola!");
            Console.WriteLine($"O App {nomeApp} foi instalado.");
        }
    }

}