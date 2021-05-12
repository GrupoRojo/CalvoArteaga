using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteEscritorio
{
    public partial class consultalamba : Form
    {
        public consultalamba()
        {
            InitializeComponent();
        }
        private void AbrirformHijas(object formhija)
        {
            if (this.panel3.Controls.Count > 0)
                this.panel3.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(fh);
            this.panel3.Tag = fh;
            fh.Show();


        }
        private void button3_Click(object sender, EventArgs e)
        {
            AbrirformHijas(new lamda1());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirformHijas(new lamda2());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirformHijas(new lamda3());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirformHijas(new lamda4());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AbrirformHijas(new lamda5());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AbrirformHijas(new lamda6());
        }
    }
}
