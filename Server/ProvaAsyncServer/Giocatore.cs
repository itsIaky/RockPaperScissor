using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace ProvaAsyncServer
{
    [Serializable]
    class Giocatore
    {
        public int punti { get; set; }
        public string nome { get; set; }
        public string password { get; set; }
        public bool online { get; set; } //per evitare che due giocatori loggino con lo stesso accout

    }
}
