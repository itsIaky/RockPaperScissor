using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaAsyncServer
{
    public class GeneraGiocate
    {
        private Random generatore;
        public GeneraGiocate()
        {
            generatore = new Random();
        }
        public char GiocaRandom()
        {
            char c;
            int a = generatore.Next(0, 3);
            if (a == 0)
            {
                c = 's';
            }
            else if (a == 1)
            {
                c = 'c';
            }
            else
            {
                c = 'f';
            }
            return c;
        }
        
        public void Reset()
        {

        }
    }
}
