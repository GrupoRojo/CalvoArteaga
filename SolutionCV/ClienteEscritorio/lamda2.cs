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
    public partial class lamda2 : Form
    {
        public lamda2()
        {
            InitializeComponent();
        }
        EscritorioDataContext escritorio = new EscritorioDataContext();
        private void btndatos_Click(object sender, EventArgs e)
        {
            var consulta = escritorio.TCorreo.Where(p => p.CodCorreo >= 1 && p.CodCorreo <= 5);
            gvConsulta.DataSource = consulta.ToList();
        }
    }
}
