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
    public partial class Cuenta : Form
    {
        public Cuenta()
        {
            InitializeComponent();
            //Bitmap img = new Bitmap(Application.StartupPath + @"\img\fondo.jpg");
            //this.BackgroundImage = img;
            //this.BackgroundImageLayout = ImageLayout.Stretch;
        }
        EscritorioDataContext escritorio = new EscritorioDataContext();
        private void btndatos_Click(object sender, EventArgs e)
        {
            var consulta = from C in escritorio.TCuenta 
                           select C;
            gvConsulta.DataSource = consulta.ToList();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btndatos_Click_1(object sender, EventArgs e)
        {
            var consulta = from C in escritorio.TCuenta
                           select C;
            gvConsulta.DataSource = consulta.ToList();
        }
    }
}
