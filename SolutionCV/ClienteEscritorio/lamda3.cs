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
    public partial class lamda3 : Form
    {
        public lamda3()
        {
            InitializeComponent();
        }
        EscritorioDataContext escritorio = new EscritorioDataContext();
        private void btndatos_Click(object sender, EventArgs e)
        {
            var consulta = escritorio.TEstudio.Where(p => p.CodEstudio >= 3 && p.CodEstudio <= 6);
            gvConsulta.DataSource = consulta.ToList();
        }
    }
}
