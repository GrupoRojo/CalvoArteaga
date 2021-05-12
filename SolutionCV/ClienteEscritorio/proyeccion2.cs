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
    public partial class proyeccion2 : Form
    {
        public proyeccion2()
        {
            InitializeComponent();
        }
        EscritorioDataContext escritorio = new EscritorioDataContext();

        private void btndatos_Click(object sender, EventArgs e)
        {
            var consulta = from p in escritorio.TEstudio
                          select new
                          {
                              p.Institucion,
                              p.Facultad,
                              p.Carrera,

                          };
            gvConsulta.DataSource = consulta.ToList();
        }
    }
}
