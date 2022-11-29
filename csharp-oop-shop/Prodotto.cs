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

        public Prodotto(int codice, string nome, string descrizione, double prezzo, double iva)
        {
            this.codice = codice;
            this.nome = nome;
            this.descrizione = descrizione;
            this.prezzo = prezzo;
            this.iva = iva;
        }

        private int GetCodice()
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


        private void SetCodice(int codice)
        {
            if (this.codice != 0)
            {
                this.codice = codice;
            }
            else
            {
                Console.WriteLine("errore");
            }
        }

        private void SetCodice()
        {

        }

















        private int GeneratoreCodice()
        {
            Random numCode = new Random();
            int codiceNuovo = numCode.Next(100000000);
            return codiceNuovo;
        }


        public double Tasse()
        {
            double tassa = prezzo * iva / 100;
            double prezzoTassato = prezzo + tassa;
            return prezzoTassato;
        }

    }
}
