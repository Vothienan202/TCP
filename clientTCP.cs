using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace TCP
{
    public partial class clientTCP : Form
    {
        public clientTCP()
        {
            InitializeComponent();
        }

        private void btnSendMsg_Click(object sender, EventArgs e)
        {
            TcpClient tcpClient = new TcpClient();
            IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
            IPEndPoint ipEndPoint = new IPEndPoint(ipAddress, 8080);
            tcpClient.Connect(ipEndPoint);
            NetworkStream ns = tcpClient.GetStream();
            Byte[] data = System.Text.Encoding.ASCII.GetBytes("Hello server\n");
            ns.Write(data, 0, data.Length);
            ns.Close();
            tcpClient.Close();
        }
    }
}
