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
    public partial class parcial2 : Form
    {
        public parcial2()
        {
            InitializeComponent();
        }
        EscritorioDataContext escritorio = new EscritorioDataContext();
        private void btndatos_Click(object sender, EventArgs e)
        {
            var consulta = from C in escritorio.TInfo
                           select new
                           {
                               C.CodInfo,
                               DatosCompletos = C.DatosCompletos(),
                               C.Direccion
                           };
            gvConsulta.DataSource = consulta.ToList();
        }
    }
}
