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
    public partial class join3 : Form
    {
        public join3()
        {
            InitializeComponent();
        }
        EscritorioDataContext escritorio = new EscritorioDataContext();
        private void btndatos_Click(object sender, EventArgs e)
        {
            var consulta = from C in escritorio.TCuenta
                           join B in escritorio.TRedSocial
                           on C.CodCuenta equals B.CodCuenta
                           join D in escritorio.TTrabajo
                           on B.CodCuenta equals D.CodCuenta
                           select new
                           {
                               C.Usuario,
                               B.Ruta,
                               D.Puesto
                           };
            gvConsulta.DataSource = consulta.ToList();
        }
    }
}
