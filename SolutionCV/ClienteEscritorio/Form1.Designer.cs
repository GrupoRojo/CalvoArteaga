
namespace ClienteEscritorio
{
    partial class ReactivaPeru
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRegistrate = new System.Windows.Forms.Button();
            this.btnContrata = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::ClienteEscritorio.Properties.Resources.fondo;
            this.panel1.Controls.Add(this.btnRegistrate);
            this.panel1.Controls.Add(this.btnContrata);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1125, 743);
            this.panel1.TabIndex = 0;
            // 
            // btnRegistrate
            // 
            this.btnRegistrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrate.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnRegistrate.Image = global::ClienteEscritorio.Properties.Resources.ima1;
            this.btnRegistrate.Location = new System.Drawing.Point(71, 92);
            this.btnRegistrate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistrate.Name = "btnRegistrate";
            this.btnRegistrate.Size = new System.Drawing.Size(300, 559);
            this.btnRegistrate.TabIndex = 8;
            this.btnRegistrate.Text = "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\nRegistrate";
            this.btnRegistrate.UseVisualStyleBackColor = true;
            this.btnRegistrate.Click += new System.EventHandler(this.btnRegistrate_Click_1);
            // 
            // btnContrata
            // 
            this.btnContrata.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnContrata.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContrata.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnContrata.Image = global::ClienteEscritorio.Properties.Resources.ima2;
            this.btnContrata.Location = new System.Drawing.Point(400, 92);
            this.btnContrata.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnContrata.Name = "btnContrata";
            this.btnContrata.Size = new System.Drawing.Size(296, 559);
            this.btnContrata.TabIndex = 7;
            this.btnContrata.Text = "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\nContrata\r\n\r\n";
            this.btnContrata.UseVisualStyleBackColor = true;
            this.btnContrata.Click += new System.EventHandler(this.btnContrata_Click_1);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Image = global::ClienteEscritorio.Properties.Resources.ima3;
            this.button1.Location = new System.Drawing.Point(714, 92);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(339, 559);
            this.button1.TabIndex = 6;
            this.button1.Text = "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\nIngresa";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ReactivaPeru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 743);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ReactivaPeru";
            this.Text = "Reactiva peru";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRegistrate;
        private System.Windows.Forms.Button btnContrata;
        private System.Windows.Forms.Button button1;
    }
}

