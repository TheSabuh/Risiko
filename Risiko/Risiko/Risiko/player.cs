using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Risiko
{
    public class player
    {
        // private Image _image;
        Form1 form;
        public List<Stato> PaesiConquistati;
        public List<int> Dadi;
        public int NcarriTot {
            get
            {
                int i = PaesiConquistati.Count / 3 + BonusCompletamento();
                return i;
            }
        }
        public player(List<Stato> P, Form1 _form)
        {
            Dadi = new List<int>();
            form = _form;
            PaesiConquistati = P;
        }
        private int BonusCompletamento()
        {
            return form.game.mondo.controlloCompletato(PaesiConquistati);
        }
        public void spostaCarri(int carri, Stato partenza ,Stato destinazione)
        {
            int indexP = 0;
            int indexD = 0;
            for(int i = 0; i < PaesiConquistati.Count; i++)
            {
                if (partenza.nome == PaesiConquistati[i].nome)
                    indexP = i;
                if (destinazione.nome == PaesiConquistati[i].nome)
                    indexD = i;
            }
            PaesiConquistati[indexP].Ncarri -= carri;
            PaesiConquistati[indexD].Ncarri += carri;
        }
        public void attacca(int nAtt, int nDiff, Stato bersaglio, Stato difeso, player difensore)
        {
            lanciaDadi(form.game.r);
            difensore.lanciaDadi(form.game.r);
            int volte = 3 - Math.Abs(nAtt - nDiff);
            for(int i = 0; i < volte; i++)
            {
                if (difensore.Dadi[i] >= Dadi[i])
                {
                    difeso.Ncarri += 1;
                    bersaglio.Ncarri -= 1;
                }
                else 
                {
                    difeso.Ncarri -= 1;
                    bersaglio.Ncarri += 1;
                }
            }
        }
        private void lanciaDadi(Random r)
        {
            Dadi.Remove(0);
            Dadi.Remove(1);
            Dadi.Remove(2);
            Dadi.Add(r.Next(1, 7));
            Dadi.Add(r.Next(1, 7));
            Dadi.Add(r.Next(1, 7));
            Dadi = Dadi.OrderByDescending(i => i).ToList();
        }
    }
}
