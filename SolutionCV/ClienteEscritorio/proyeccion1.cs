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
    public partial class proyeccion1 : Form
    {
        public proyeccion1()
        {
            InitializeComponent();
        }
        EscritorioDataContext escritorio = new EscritorioDataContext();
        private void btndatos_Click(object sender, EventArgs e)
        {
            var consulta = from C in escritorio.TCuenta
                           select new
                           {
                               C.CodCuenta,
                               C.Usuario,
                               C.Seudonimo,
                               C.FechaRegistro
                           };
            gvConsulta.DataSource = consulta.ToList();
        }
    }
}
