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

        }

        public async void getHospitales() {
            List<string> hospitales = await this.repository.GetHospitalesAsync();

            this.cmbHospitales.DataSource = hospitales;
        }
    }
}
