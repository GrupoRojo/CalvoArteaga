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
    public partial class ReactivaPeru : Form
    {
        public ReactivaPeru()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\fondo.jpg");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formulario = new login();
            formulario.Show();
        }

        private void btnContrata_Click(object sender, EventArgs e)
        {
            Form formulario = new Contrata();
            formulario.Show();
        }

        private void btnRegistrate_Click(object sender, EventArgs e)
        {
            Form formulario = new Registrarse();
            formulario.Show();
        }

        private void btnRegistrate_Click_1(object sender, EventArgs e)
        {
            Form formulario = new Registrarse();
            formulario.Show();
        }

        private void btnContrata_Click_1(object sender, EventArgs e)
        {
            Form formulario = new Contrata();
            formulario.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form formulario = new panelDeControl();
            formulario.Show();
        }
    }
}
