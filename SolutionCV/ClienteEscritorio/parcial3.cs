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
    public partial class parcial3 : Form
    {
        public parcial3()
        {
            InitializeComponent();
        }
        EscritorioDataContext escritorio = new EscritorioDataContext();
        private void btndatos_Click(object sender, EventArgs e)
        {
            var consulta = from C in escritorio.TRedSocial
                           select new
                           {
                               C.CodRedSocial,
                               DatosCompletos = C.DatosCompletos(),
                           };
            gvConsulta.DataSource = consulta.ToList();
        }
    }
}
