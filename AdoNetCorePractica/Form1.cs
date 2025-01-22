using AdoNetCorePractica.Models;
using AdoNetCorePractica.Repositories;

namespace AdoNetCorePractica
{
    public partial class Form1 : Form
    {

        RepositoryHospitalesPlantillas repository;
        public Form1()
        {
            InitializeComponent();

            this.repository = new RepositoryHospitalesPlantillas();
            this.getHospitales();
        }

        private void cmbHospitales_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.getEmpleados();
        }

        public async void getHospitales() {
            List<string> hospitales = await this.repository.GetHospitalesAsync();

            this.cmbHospitales.DataSource = hospitales;
        }

        public async void getEmpleados()
        {
            List<Plantilla> empleados = await this.repository.GetPlantillaHospitalAsync(this.cmbHospitales.SelectedItem.ToString());
            List<string> datos = await this.repository.GetDatos(this.cmbHospitales.SelectedItem.ToString());

            this.lstEmpleados.DataSource = empleados;
            this.txtSuma.Text = datos[0];
            this.txtMedia.Text = datos[1];
            this.txtPersonas.Text = datos[2];
        }
    }
}
