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
    public partial class trabajo : Form
    {
        public trabajo()
        {
            InitializeComponent();
           // Bitmap img = new Bitmap(Application.StartupPath + @"\img\fondo.jpg");
           // this.BackgroundImage = img;
           // this.BackgroundImageLayout = ImageLayout.Stretch;
        }
        EscritorioDataContext escritorio = new EscritorioDataContext();
        private void btndatos_Click(object sender, EventArgs e)
        {
            
        }

        private void btndatos_Click_1(object sender, EventArgs e)
        {
            var consulta = from C in escritorio.TTrabajo
                           select C;
            gvConsulta.DataSource = consulta.ToList();
        }
    }
}
