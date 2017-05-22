using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;

namespace ClinicSecretaryClient
{
    public partial class ClinicSecretary : Form
    {
        public ClinicSecretary()
        {
            InitializeComponent();
            gridPatients.AutoGenerateColumns = true;
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            Patient p = new Patient();
            p.IdentityCardNumber = Convert.ToInt32(txtIdentityCardNumber.Text);
            p.Name = txtName.Text;
            p.CNP = Convert.ToInt32(txtCNP.Text);
            p.Birthdate = dtBirthdate.Value;
            p.Address = txtAddress.Text;

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:60897/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.PutAsJsonAsync("api/Patient", p).Result;

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Adding succeded!");
            }
            else
            {
                MessageBox.Show("Adding failed!");
            }
        }

        private void btnUpdatePatient_Click(object sender, EventArgs e)
        {
            Patient p = new Patient();
            p.IdentityCardNumber = Convert.ToInt32(txtIdentityCardNumber.Text);
            p.Name = txtName.Text;
            p.CNP = Convert.ToInt32(txtCNP.Text);
            p.Birthdate = dtBirthdate.Value;
            p.Address = txtAddress.Text;

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:60897/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.PutAsJsonAsync("api/Patient", p).Result;

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Update succeded!");
            }
            else
            {
                MessageBox.Show("Update failed!");
            }
        }

        private void btnViewPatients_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:60897/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync("api/Patient").Result;

            if (response.IsSuccessStatusCode)
            {
                var patients = response.Content.ReadAsAsync<IEnumerable<Patient>>().Result;
                gridPatients.DataSource = patients;
            }
        }

        public int getPacientByNume()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:60897/"); 

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync("api/Patient").Result;

            if (response.IsSuccessStatusCode)
            {
                var patients = response.Content.ReadAsAsync<IList<Patient>>().Result;
                foreach (var patient in patients)
                {
                    if (patient.Name == txtNameConsultation.Text)
                    {
                        return patient.IdPatient;
                    }
                }
            }
            return 0;
        }

        public int getDoctorByNume()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:60897/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync("api/Doctor").Result;

            if (response.IsSuccessStatusCode)
            {
                var doctors = response.Content.ReadAsAsync<IList<Doctor>>().Result;
                foreach (var doctor in doctors)
                {
                    if (doctor.Name == txtDoctor.Text)
                    {
                        return doctor.IdDoctor;
                    }
                }
            }
            return 0;
        }

        private void btnAddConsultation_Click(object sender, EventArgs e)
        {
            Consultation c = new Consultation();
            c.idPatient = getPacientByNume();
            c.date = dtDateConsultation.Value;
            c.idDoctor = getDoctorByNume();
            c.treatment = txtTreatment.Text;

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:60897/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.PostAsJsonAsync("api/Consultation", c).Result;

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Adding succeded!");
            }
            else
            {
                MessageBox.Show("Adding failed!");
            }
        }

        private void btnViewConsultations_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:60897/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync("api/Consultation").Result;

            if (response.IsSuccessStatusCode)
            {
                var consultations = response.Content.ReadAsAsync<IList<Consultation>>().Result;
                gridConsultations.DataSource = consultations;
            }
        }

        private void btnUpdateConsultation_Click(object sender, EventArgs e)
        {
            Consultation c = new Consultation();
            c.idPatient = getPacientByNume();
            c.date = dtDateConsultation.Value;
            c.idDoctor = getDoctorByNume();
            c.treatment = txtTreatment.Text;

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:60897/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.PutAsJsonAsync("api/Consultation", c).Result;

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Update succeded!");
            }
            else
            {
                MessageBox.Show("Update failed");
            }
        }

        int cons;
        public string getPacientById(int PacientName)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:60897/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync("api/Pacient").Result;

            if (response.IsSuccessStatusCode)
            {
                var patients = response.Content.ReadAsAsync<IList<Patient>>().Result;
                foreach (var patient in patients)
                {
                    if (patient.IdPatient == PacientName)
                    {
                        return patient.Name;
                    }
                }
            }
            return null;
        }

        public string getDoctorById(int DoctorName)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:60897/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync("api/Doctor").Result;

            if (response.IsSuccessStatusCode)
            {
                var doctors = response.Content.ReadAsAsync<IList<Doctor>>().Result;
                foreach (var doctor in doctors)
                {
                    if (doctor.IdDoctor == DoctorName)
                    {
                        return doctor.Name;
                    }
                }
            }
            return null;
        }

        private void gridConsultations_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cons = Convert.ToInt32(gridConsultations.Rows[e.RowIndex].Cells[0].Value.ToString());
            int DoctorName = Convert.ToInt32(gridConsultations.Rows[e.RowIndex].Cells[1].Value.ToString());
            int PacientName = Convert.ToInt32(gridConsultations.Rows[e.RowIndex].Cells[2].Value.ToString());
            txtNameConsultation.Text = getPacientById(PacientName);
            txtDoctor.Text = getDoctorById(DoctorName);
            txtTreatment.Text = gridConsultations.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void btnDeleteConsultation_Click(object sender, EventArgs e)
        {
            int id = cons;
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:60897/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.DeleteAsync("api/Consultation/" + id).Result;

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Delete succeded!");
            }
            else
            {
                MessageBox.Show("Delete failed!");
            }
        }

    }
}
