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
        public Form1()
        {
            InitializeComponent();
            List<Stato> prova = new List<Stato>();
            //prova.Add(new Stato( NomiStati.Argentina));
            prova.Add(new Stato(NomiStati.Brasile));
            Console.WriteLine();
            game = new Game(new List<Stato>(prova), new List<Stato>(), new List<Stato>(), this);
            Console.WriteLine(game.player1.NcarriTot);
        }
    }
}
