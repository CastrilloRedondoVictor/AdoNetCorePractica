namespace AdoNetCorePractica
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstEmpleados = new ListBox();
            txtLoc = new TextBox();
            txtDnombre = new TextBox();
            txtDeptno = new TextBox();
            cmbDepartamentos = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnInsertar = new Button();
            txtSalario = new TextBox();
            txtOficio = new TextBox();
            txtApellido = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            btnUpdate = new Button();
            SuspendLayout();
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.Location = new Point(251, 30);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(276, 289);
            lstEmpleados.TabIndex = 19;
            // 
            // txtLoc
            // 
            txtLoc.Location = new Point(15, 233);
            txtLoc.Name = "txtLoc";
            txtLoc.Size = new Size(100, 23);
            txtLoc.TabIndex = 18;
            // 
            // txtDnombre
            // 
            txtDnombre.Location = new Point(15, 167);
            txtDnombre.Name = "txtDnombre";
            txtDnombre.Size = new Size(100, 23);
            txtDnombre.TabIndex = 17;
            // 
            // txtDeptno
            // 
            txtDeptno.Location = new Point(15, 107);
            txtDeptno.Name = "txtDeptno";
            txtDeptno.Size = new Size(100, 23);
            txtDeptno.TabIndex = 16;
            // 
            // cmbDepartamentos
            // 
            cmbDepartamentos.FormattingEnabled = true;
            cmbDepartamentos.Location = new Point(15, 30);
            cmbDepartamentos.Name = "cmbDepartamentos";
            cmbDepartamentos.Size = new Size(121, 23);
            cmbDepartamentos.TabIndex = 15;
            cmbDepartamentos.SelectedIndexChanged += cmbDepartamentos_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(251, 12);
            label5.Name = "label5";
            label5.Size = new Size(112, 15);
            label5.TabIndex = 14;
            label5.Text = "Empleados Hospital";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 215);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 13;
            label4.Text = "Localidad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 149);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 12;
            label3.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 89);
            label2.Name = "label2";
            label2.Size = new Size(17, 15);
            label2.TabIndex = 11;
            label2.Text = "Id";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 12);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 10;
            label1.Text = "Departamentos";
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(15, 296);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(100, 59);
            btnInsertar.TabIndex = 20;
            btnInsertar.Text = "Insertar departamento";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(606, 233);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(100, 23);
            txtSalario.TabIndex = 26;
            // 
            // txtOficio
            // 
            txtOficio.Location = new Point(606, 167);
            txtOficio.Name = "txtOficio";
            txtOficio.Size = new Size(100, 23);
            txtOficio.TabIndex = 25;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(606, 107);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(606, 215);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 23;
            label6.Text = "Salario";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(606, 149);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 22;
            label7.Text = "Oficio";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(606, 89);
            label8.Name = "label8";
            label8.Size = new Size(51, 15);
            label8.TabIndex = 21;
            label8.Text = "Apellido";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(606, 296);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 59);
            btnUpdate.TabIndex = 27;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUpdate);
            Controls.Add(txtSalario);
            Controls.Add(txtOficio);
            Controls.Add(txtApellido);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(btnInsertar);
            Controls.Add(lstEmpleados);
            Controls.Add(txtLoc);
            Controls.Add(txtDnombre);
            Controls.Add(txtDeptno);
            Controls.Add(cmbDepartamentos);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstEmpleados;
        private TextBox txtLoc;
        private TextBox txtDnombre;
        private TextBox txtDeptno;
        private ComboBox cmbDepartamentos;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnInsertar;
        private TextBox txtSalario;
        private TextBox txtOficio;
        private TextBox txtApellido;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button btnUpdate;
    }
}