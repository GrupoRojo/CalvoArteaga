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
    public partial class join5 : Form
    {
        public join5()
        {
            InitializeComponent();
        }
        EscritorioDataContext escritorio = new EscritorioDataContext();
        private void btndatos_Click(object sender, EventArgs e)
        {
            var consulta = from C in escritorio.TCuenta
                           join B in escritorio.TEstudio
                           on C.CodCuenta equals B.CodCuenta
                           join D in escritorio.TTrabajo
                           on B.CodCuenta equals D.CodCuenta
                           join E in escritorio.THabilidad
                           on D.CodCuenta equals E.CodCuenta
                           select new
                           {
                               C.Usuario,
                               B.Carrera,
                               D.Empresa,
                               E.Nivel
                           };
            gvConsulta.DataSource = consulta.ToList();
        }
    }
}
