using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCP
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnServer_Click(object sender, EventArgs e)
        {
            serverTCP serverTCP = new serverTCP();
            serverTCP.Show();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            clientTCP clientTCP = new clientTCP();
            clientTCP.Show();
        }
    }
}
