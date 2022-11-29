using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop
{
    public class Prodotto
    {
        private int codice;
        public string nome = "";
        public string descrizione = "";
        public double prezzo;
        public double iva;


        public Prodotto()
        {

        }

        public Prodotto(string nome, string descrizione, double prezzo, double iva)
        {
            this.codice = this.GeneratoreCodice();
            this.nome = nome;
            this.descrizione = descrizione;
            this.prezzo = prezzo;
            this.iva = iva;
        }

        public int GetCodice()
        {
            return this.codice;
        }

        public string GetNome()
        {
            return this.nome;
        }

        public string GetDescrizione()
        {
            return this.descrizione;
        }

        public double GetPrezzo()
        {
            return this.prezzo;
        }

        public double GetIVA()
        {
            return this.iva;
        }


        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public void SetDescrizione(string descrizione)
        {
            this.descrizione = descrizione;
        }

        public void SetPrezzo(double prezzo)
        {
            this.prezzo = prezzo;
        }

        public void SetIva(double iva)
        {
            this.iva = iva;
        }

        public void StampaProdotto()
        {
            Console.WriteLine(this.codice);
            Console.WriteLine("Nome: " + this.nome);
            Console.WriteLine("Descrizione: " + this.descrizione);
            Console.WriteLine("Prezzo: " + PrezzoBase() + " euro");
            Console.WriteLine("Iva:" + this.iva + " %");
            Console.WriteLine("Prezzo con Iva: " + PrezzoTasse() + "");
            Console.WriteLine("Nome completo: " + this.nome + codice);
        }

        public int GeneratoreCodice()
        {
            Random numCode = new Random();
            int codiceNuovo = numCode.Next(100000000);
            return codiceNuovo;
        }


        public double PrezzoBase()
        {
            return this.prezzo;
        }

        public double PrezzoTasse()
        {
            double tassa = this.prezzo * this.iva / 100;
            return this.prezzo + tassa;
        }

    }
}
