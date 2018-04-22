using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ChatRoom.Common
{
    public class TcpModel
    {
        private TcpClient _tcp;

        public TcpModel(string ip, int port)
        {
            _tcp = new TcpClient(ip, port);
        }
    }
}
