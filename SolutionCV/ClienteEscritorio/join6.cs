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
    public partial class join6 : Form
    {
        public join6()
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
                           join E in escritorio.TInfo
                           on D.CodCuenta equals E.CodCuenta
                           select new
                           {
                               C.Usuario,
                               B.Carrera,
                               D.Empresa,
                               D.Puesto,
                               E.Nombres,
                               E.Apellidos
                           };
            gvConsulta.DataSource = consulta.ToList();
        }
    }
}
