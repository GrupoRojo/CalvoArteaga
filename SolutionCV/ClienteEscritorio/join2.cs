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
    public partial class join2 : Form
    {
        public join2()
        {
            InitializeComponent();
        }
        EscritorioDataContext escritorio = new EscritorioDataContext();
        private void btndatos_Click(object sender, EventArgs e)
        {
            var consulta = from C in escritorio.TCuenta
                           join B in escritorio.THabilidad
                           on C.CodCuenta equals B.CodCuenta
                           join D in escritorio.TInfo
                           on B.CodCuenta equals D.CodCuenta
                           select new
                           {
                               C.Usuario,
                               B.Nombre,
                               B.Nivel,
                               D.DNI
                           };
            gvConsulta.DataSource = consulta.ToList();
        }
    }
}
