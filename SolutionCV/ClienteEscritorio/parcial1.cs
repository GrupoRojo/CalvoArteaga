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
    public partial class parcial1 : Form
    {
        public parcial1()
        {
            InitializeComponent();
        }
        EscritorioDataContext escritorio = new EscritorioDataContext();
        private void btndatos_Click(object sender, EventArgs e)
        {
            var consulta = from C in escritorio.TCuenta
                           select new
                           {
                               C.CodCuenta,
                               DatosCompletos = C.DatosCompletos(),
                           };
            gvConsulta.DataSource = consulta.ToList();
        }
    }
}
