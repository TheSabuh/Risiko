using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Risiko
{
    public class Stato
    {
        private Image _image;
        public string Continente;
        public int Ncarri;
        public NomiStati nome;
        public List<NomiStati> PaesiVicini;

        public Stato(NomiStati N)
        {
            nome = N;
            switch (nome)
            {
                case NomiStati.Argentina:
                    PaesiVicini = new List<NomiStati> {NomiStati.Brasile, NomiStati.Usa};
                    break;
                case NomiStati.Brasile:
                    PaesiVicini = new List<NomiStati> { NomiStati.AfricaDelNord, NomiStati.Argentina};
                    break;
                case NomiStati.Usa:
                    PaesiVicini = new List<NomiStati> { NomiStati.Argentina, NomiStati.Canada, NomiStati.Alaska, NomiStati.Groenlandia};
                    break;
                case NomiStati.Canada:
                    PaesiVicini = new List<NomiStati> { NomiStati.Usa, NomiStati.Alaska, NomiStati.Groenlandia};
                    break;
                case NomiStati.Alaska:
                    PaesiVicini = new List<NomiStati> { NomiStati.Giappone, NomiStati.Groenlandia, NomiStati.Canada, NomiStati.Usa};
                    break;
                case NomiStati.Groenlandia:
                    PaesiVicini = new List<NomiStati> { NomiStati.Alaska, NomiStati.Canada, NomiStati.Islanda};
                    break;
                case NomiStati.Islanda:
                    PaesiVicini = new List<NomiStati> { NomiStati.Groenlandia, NomiStati.GranBretagna};
                    break;
                case NomiStati.GranBretagna:
                    PaesiVicini = new List<NomiStati> { NomiStati.Francia, NomiStati.Italia, NomiStati.NeoNazisti};
                    break;
                case NomiStati.Francia:
                    PaesiVicini = new List<NomiStati> { NomiStati.GranBretagna, NomiStati.NeoNazisti, NomiStati.Italia};
                    break;
                case NomiStati.Italia:
                    PaesiVicini = new List<NomiStati> { NomiStati.AfricaDelNord, NomiStati.Urrs, NomiStati.NeoNazisti, NomiStati.Francia, NomiStati.GranBretagna};
                    break;
                case NomiStati.NeoNazisti:
                    PaesiVicini = new List<NomiStati> { NomiStati.Urrs, NomiStati.Italia, NomiStati.Francia, NomiStati.GranBretagna};
                    break;
                case NomiStati.Urrs:
                    PaesiVicini = new List<NomiStati> { NomiStati.Giappone, NomiStati.Cina, NomiStati.India, NomiStati.NeoNazisti, NomiStati.AfricaDelNord, NomiStati.Italia};
                    break;
                case NomiStati.Giappone:
                    PaesiVicini = new List<NomiStati> { NomiStati.Alaska, NomiStati.Urrs};
                    break;
                case NomiStati.Cina:
                    PaesiVicini = new List<NomiStati> { NomiStati.Urrs, NomiStati.India, NomiStati.NuovaZelanda};
                    break;
                case NomiStati.India:
                    PaesiVicini = new List<NomiStati> { NomiStati.Cina, NomiStati.Urrs };
                    break;
                case NomiStati.NuovaZelanda:
                    PaesiVicini = new List<NomiStati> { NomiStati.Cina, NomiStati.Australia };
                    break;
                case NomiStati.Australia:
                    PaesiVicini = new List<NomiStati> { NomiStati.NuovaZelanda, NomiStati.ArmataPinguini };
                    break;
                case NomiStati.ArmataPinguini:
                    PaesiVicini = new List<NomiStati> { NomiStati.Australia, NomiStati.AfricaDelSud };
                    break;
                case NomiStati.AfricaDelSud:
                    PaesiVicini = new List<NomiStati> { NomiStati.ArmataPinguini, NomiStati.Madagascar, NomiStati.AfricaDelNord};
                    break;
                case NomiStati.Madagascar:
                    PaesiVicini = new List<NomiStati> { NomiStati.AfricaDelSud, NomiStati.AfricaDelNord};
                    break;
                case NomiStati.AfricaDelNord:
                    PaesiVicini = new List<NomiStati> { NomiStati.Madagascar, NomiStati.AfricaDelSud, NomiStati.Urrs, NomiStati.Brasile, NomiStati.Italia};
                    break;
            }
            
        }
    }
}
