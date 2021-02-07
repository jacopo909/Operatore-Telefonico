using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatore_telefonico
{
    public class SIM
    {
        uint numerotelefonico;
        double credito;
        int seriale;
        List<int> telefonate_effettuate = new  List<int>();

        public SIM(uint numerotelefonico, double credito)
        {
            this.numerotelefonico = numerotelefonico;
            this.credito = credito; 
        }
        private int GeneraSeriale()
        {
            Random r = new Random();
            this.seriale = r.Next();
            return this.seriale;
        }
        public void CalcolaMinuti()
        {
            int secondi;
            int minuti = 0;
            for (secondi = 0; secondi <= 60; secondi++)
            {
                Console.WriteLine($"Sono passati: {secondi} secondi");
                if (secondi == 60)
                {
                    minuti++;
                    Console.WriteLine("Minuti aggiornati!");
                    continue;
                }
            }
        }
        public void Telefonata(int newnumerotelefonico, int credito)
        {
            if(this.numerotelefonico != newnumerotelefonico)
            {

            }
            else
            {
                Console.WriteLine("Numero Errato");
            }
        }
    }
}
