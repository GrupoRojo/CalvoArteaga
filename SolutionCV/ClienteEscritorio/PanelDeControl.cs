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
    public partial class panelDeControl : Form
    {
        public panelDeControl()
        {
            InitializeComponent();
            
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\fondo.jpg");
            this.BackgroundImage = img;
           this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void AbrirformHija(object formhija)
        {
            if (this.panel.Controls.Count > 0)
                this.panel.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel.Controls.Add(fh);
            this.panel.Tag = fh;
            fh.Show(); 


        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnInformacion_Click(object sender, EventArgs e)
        {
            AbrirformHija(new  informacion());
        }

        private void btnEstudios_Click(object sender, EventArgs e)
        {
            AbrirformHija(new estudios());
        }

        private void btnHabilidades_Click(object sender, EventArgs e)
        {
            AbrirformHija(new habilidades());
        }

        private void btnTelefonos_Click(object sender, EventArgs e)
        {
            AbrirformHija(new Telefonos());
        }

        private void btnCorreos_Click(object sender, EventArgs e)
        {
            AbrirformHija(new correos());
        }

        private void btnRedes_Click(object sender, EventArgs e)
        {
            AbrirformHija(new redesSociales());
        }

        private void btnCuenta_Click(object sender, EventArgs e)
        {
            AbrirformHija(new Cuenta());
        }

        private void btnTrabajo_Click(object sender, EventArgs e)
        {
            AbrirformHija(new trabajo());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirformHija(new consultaProyeccion());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirformHija(new consultalamba());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirformHija(new consultaparcial());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirformHija(new pan());
        }
    }
}
