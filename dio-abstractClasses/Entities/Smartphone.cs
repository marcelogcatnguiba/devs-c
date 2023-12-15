using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioDio.Entities
{
    public abstract class Smartphone
    {
        public string Numero { get; set; } = "";
        public string Modelo { get; set; } = "";
        public string IMEI { get; set; } = "";
        public int Memoria { get; set; }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }
        public virtual void Ligar()
        {
            System.Console.WriteLine("Ligando ...");
        }

        public virtual void ReceberLigacao()
        {
            System.Console.WriteLine("Recebendo ligação ...");
        }

        public abstract void InstalarAplicativo(string nome);
    }
}