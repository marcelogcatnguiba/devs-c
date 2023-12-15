using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioDio.Entities
{
    public sealed class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {

        }
        public override void Ligar()
        {
            base.Ligar();
            System.Console.WriteLine("Iphone");
        }

        public override void ReceberLigacao()
        {
            base.ReceberLigacao();
            System.Console.WriteLine("Iphone");
        }
        public override void InstalarAplicativo(string app)
        {
            System.Console.WriteLine($"Instalando aplicativo {app} Iphone ...");
        }
    }
}