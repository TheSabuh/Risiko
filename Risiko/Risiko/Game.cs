using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Risiko
{
    public class Game
    {
        public Game(List<Stato> p1, List<Stato> p2, List<Stato> p3, Form1 form)
        {
            mondo = new Mondo();
            player1 = new player(p1, form);
            player2 = new player(p2, form);
            player3 = new player(p3, form);
            r = new Random();
        }
        public Mondo mondo;
        public player player1;
        public player player2;
        public player player3;
        public Random r;
    }
}
