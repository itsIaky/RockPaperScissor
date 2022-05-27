using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaAsyncServer
{
    public class Gioco
    {
        public int NumVittorie { get; set; }
        public int NumSconfitte { get; set; }
        public GeneraGiocate Genera { get; set; }
        

         
        public Gioco()
        {
            Genera = new GeneraGiocate();
            NumSconfitte = 0;
            NumVittorie = 0;
        }
        public string Turno(char utente)
        {
            
            string output = "";
            
            char c = Genera.GiocaRandom();
            if ((utente == 's' && c == 'f') || (utente == 'f' && c == 'c') || (utente == 'c' && c == 's'))
            {
                NumVittorie++;
                output += "v";
            }
            else if (utente == c)
            {
                output += "p";
            }
            else
            {
                output += "s";
                NumSconfitte++;
            }

            output += c;
            return output;
        }
        public void Reset()
        {
            NumVittorie = 0;
            NumSconfitte = 0;
            Genera.Reset();
        }
    }
}
