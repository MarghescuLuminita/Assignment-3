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

namespace DoctorClient
{
    public partial class Doctor : Form
    {
        private User doctor;

        private string name;

        public Doctor()
        {
            InitializeComponent();
        }

        private void btnAddConsultation_Click(object sender, EventArgs e)
        {
            Consultation c = new Consultation();
            c.idPatient = getPacientByName(txtName.Text);
            c.date = dtDate.Value;
            c.treatment = txtTreatment.Text;
            c.idDoctor = doctor.IdUser;

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

        public int getPacientByName(string name)
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
                    if (patient.Name == name)
                    {
                        return patient.IdPatient;
                    }
                    else
                    {
                        MessageBox.Show("Wrong name!");
                    }
                }
            }
            return 0;
        }

        private void btnViewConsultations_Click(object sender, EventArgs e)
        {
            int patientId = getPacientByName(txtName.Text);

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:60897/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync("api/Consultation").Result;

            if (response.IsSuccessStatusCode)
            {
                var consultations = response.Content.ReadAsAsync<IList<Consultation>>().Result;
                IList<Consultation> consultationsById = new List<Consultation>();

                foreach (var consultation in consultations)
                {
                    if (consultation.idPatient == patientId)
                    {
                        consultationsById.Add(consultation);
                    }
                }

                gridConsultations.DataSource = consultationsById;
            }
        }

    }
}
