﻿using System;
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
    public partial class lamda4 : Form
    {
        public lamda4()
        {
            InitializeComponent();
        }
        EscritorioDataContext escritorio = new EscritorioDataContext();
        private void btndatos_Click(object sender, EventArgs e)
        {
            
            var consulta = escritorio.THabilidad.Where(P => P.Nombre == "Acces");
            gvConsulta.DataSource = consulta.ToList();
        }
    }
}
