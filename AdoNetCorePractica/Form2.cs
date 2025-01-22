using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdoNetCorePractica.Repositories;

namespace AdoNetCorePractica
{
    public partial class Form2 : Form
    {

        RepositoryDepartamentosEmpleados repository;
        public Form2()
        {
            InitializeComponent();

            this.repository = new RepositoryDepartamentosEmpleados();

            this.getDepartamentos();
        }

        private void cmbDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void getDepartamentos()
        {
            List<string> departamentos = await this.repository.GetDepartamentos();
            this.cmbDepartamentos.DataSource = departamentos;
        }

        private async void btnInsertar_Click(object sender, EventArgs e)
        {
            await this.repository.InsertDepartamento(int.Parse(this.txtDeptno.Text), this.txtDnombre.Text, this.txtLoc.Text);
            this.getDepartamentos();
        }
    }
}
