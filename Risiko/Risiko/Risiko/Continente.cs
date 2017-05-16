using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Risiko
{
    public class Continente
    {
        bool Completato;
        public nomiContinenti nome;
        public List<Stato> Paesi;
        public int carriBonus;
        public Continente(nomiContinenti N)
        {
            nome = N;
            switch (nome)
            {
                case nomiContinenti.SudAmerica:
                    Paesi = new List<Stato> { new Stato(NomiStati.Brasile), new Stato(NomiStati.Argentina) };
                    carriBonus = 1;
                    break;
                case nomiContinenti.NordAmerica:
                    Paesi = new List<Stato> { new Stato(NomiStati.Usa), new Stato(NomiStati.Canada), new Stato(NomiStati.Alaska), new Stato(NomiStati.Groenlandia) };
                    carriBonus = 2;
                    break;
                case nomiContinenti.Europa:
                    Paesi = new List<Stato> { new Stato(NomiStati.Italia), new Stato(NomiStati.Francia), new Stato(NomiStati.NeoNazisti), new Stato(NomiStati.GranBretagna), new Stato(NomiStati.Islanda) };
                    carriBonus = 3;
                    break;
                case nomiContinenti.Africa:
                    Paesi = new List<Stato> { new Stato(NomiStati.AfricaDelNord), new Stato(NomiStati.AfricaDelSud), new Stato(NomiStati.Madagascar) };
                    carriBonus = 2;
                    break;
                case nomiContinenti.Antartide:
                    Paesi = new List<Stato> { new Stato(NomiStati.ArmataPinguini) };
                    carriBonus = 1;
                    break;
                case nomiContinenti.Asia:
                    Paesi = new List<Stato> { new Stato(NomiStati.Giappone), new Stato(NomiStati.Urrs), new Stato(NomiStati.Cina), new Stato(NomiStati.India) };
                    carriBonus = 3;
                    break;
                case nomiContinenti.Oceania:
                    Paesi = new List<Stato> { new Stato(NomiStati.Australia), new Stato(NomiStati.NuovaZelanda)};
                    carriBonus = 1;
                    break;
            }
        }
       public int completato(List<Stato> player)
        {
            int time = 0;
            foreach(var stato in Paesi)
            {
                int i = 0;
                foreach (var statoplayer in player)
                {
                    if (stato.nome == statoplayer.nome)
                        time++;
                    i++;
                }
            }
            if (time == Paesi.Count)
                return carriBonus;
            else
                return -1;
        }
    }
}
