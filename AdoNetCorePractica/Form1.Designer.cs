namespace AdoNetCorePractica
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cmbHospitales = new ComboBox();
            txtSuma = new TextBox();
            txtMedia = new TextBox();
            txtPersonas = new TextBox();
            lstEmpleados = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 20);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "Hospitales";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 151);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 1;
            label2.Text = "Suma salarial";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 211);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 2;
            label3.Text = "Media salarial";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 277);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 3;
            label4.Text = "Personas";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(277, 20);
            label5.Name = "label5";
            label5.Size = new Size(112, 15);
            label5.TabIndex = 4;
            label5.Text = "Empleados Hospital";
            // 
            // cmbHospitales
            // 
            cmbHospitales.FormattingEnabled = true;
            cmbHospitales.Location = new Point(41, 38);
            cmbHospitales.Name = "cmbHospitales";
            cmbHospitales.Size = new Size(121, 23);
            cmbHospitales.TabIndex = 5;
            cmbHospitales.SelectedIndexChanged += cmbHospitales_SelectedIndexChanged;
            // 
            // txtSuma
            // 
            txtSuma.Location = new Point(41, 169);
            txtSuma.Name = "txtSuma";
            txtSuma.Size = new Size(100, 23);
            txtSuma.TabIndex = 6;
            // 
            // txtMedia
            // 
            txtMedia.Location = new Point(41, 229);
            txtMedia.Name = "txtMedia";
            txtMedia.Size = new Size(100, 23);
            txtMedia.TabIndex = 7;
            // 
            // txtPersonas
            // 
            txtPersonas.Location = new Point(41, 295);
            txtPersonas.Name = "txtPersonas";
            txtPersonas.Size = new Size(100, 23);
            txtPersonas.TabIndex = 8;
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.Location = new Point(277, 38);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(276, 289);
            lstEmpleados.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(597, 370);
            Controls.Add(lstEmpleados);
            Controls.Add(txtPersonas);
            Controls.Add(txtMedia);
            Controls.Add(txtSuma);
            Controls.Add(cmbHospitales);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cmbHospitales;
        private TextBox txtSuma;
        private TextBox txtMedia;
        private TextBox txtPersonas;
        private ListBox lstEmpleados;
    }
}
