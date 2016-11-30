using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wimbledon
{
    public class Program
    {
        private int jugador1 { get; set; }
        private int jugador2 { get; set; }
        private string nombreJugador1 { get; set; }
        private string nombreJugador2 { get; set; }
        private Dictionary<int, string> puntaje;
        public Program(int a, int b)
        {
            this.jugador1 = a;
            this.jugador2 = b;
            this.puntaje = new Dictionary<int, string>();
            puntaje.Add(0, "Love");
            puntaje.Add(15, "Fifteen");
            puntaje.Add(30, "Thirty");
            puntaje.Add(40, "Fourthy");
            this.nombreJugador1 = "a";
            this.nombreJugador2 = "b";
        }
        public string getScore()
        {
            return puntaje[jugador1] + " - " + puntaje[jugador2];
        }
        public void scorePoint(string name)
        {
            if(jugador1 == jugador2)
            {

            }
            if (name.Equals(nombreJugador1))
            {
                jugador1++;
                puntaje.Add(jugador1,jugador1 - jugador2 == 2 ? "Win" : "Advantage");
            }
            else {
                jugador2++;
                puntaje.Add(jugador2, jugador2 - jugador1 == 2 ? "Win" : "Advantage");
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
