using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Risiko
{
    public partial class Form1 : Form
    {
        public Game game;
        FasiGioco fase;
        bool primo;
        public Form1()
        {
            InitializeComponent();
            fase = FasiGioco.primoTurno;
            primo = true;
            game = new Game(new List<Stato>(), new List<Stato>(), new List<Stato>(), this);
            for (int i = 0; i < 7; i++)
            {
                for (int l = 0; l < game.mondo.Mappa[i].Paesi.Count; l++)
                {
                    int j = game.r.Next(1, 4);
                    switch (j)
                    {
                        case 1:
                            if (game.player1.PaesiConquistati.Count < 7)
                                game.player1.PaesiConquistati.Add(game.mondo.Mappa[i].Paesi[l]);
                            else
                                l--;
                            break;
                        case 2:
                            if (game.player2.PaesiConquistati.Count < 7)
                                game.player2.PaesiConquistati.Add(game.mondo.Mappa[i].Paesi[l]);
                            else
                                l--;
                            break;
                        case 3:
                            if (game.player3.PaesiConquistati.Count < 7)
                                game.player3.PaesiConquistati.Add(game.mondo.Mappa[i].Paesi[l]);
                            else
                                l--;
                            break;
                    }
                }
            }
            
        }

        private void CambiaFase_Click(object sender, EventArgs e)
        {
            
        }
        private void fasi()
        {
            
        }
    }
}
