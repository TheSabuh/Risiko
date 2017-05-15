using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Risiko
{
    public class Mondo
    {
        List<Continente> Mappa;
        public Mondo()
        {
            Mappa = new List<Continente>();
            for (int i = 0; i < 7; i++)
            {
                Mappa.Add(new Continente(nomiContinenti.SudAmerica + i));
            }
        }
        public int controlloCompletato(List<Stato> player)
        {
            int carri = 0;
            foreach (var continente in Mappa)
            {
                if(continente.completato(player) >= 0)
                    carri+= continente.completato(player);
            }
            return carri;
        }

    }
}
