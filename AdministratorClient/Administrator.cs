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

namespace AdministratorClient
{
    public partial class Administrator : Form
    {
        public Administrator()
        {
            InitializeComponent();
        }

        private void btnAddDoctor_Click(object sender, EventArgs e)
        {
            UserForm form = new UserForm();
            form.Show();

            Doctor d = new Doctor();
            d.Name = txtDoctorName.Text;
            d.Specialization = txtSpecialization.Text;

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:60897/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.PostAsJsonAsync("api/Doctor", d).Result;

            if (response.IsSuccessStatusCode)
            {
                //MessageBox.Show("Adding succeded!");
            }
            else
            {
                //MessageBox.Show("Adding failed!");
            }
        }

        private void btnViewDoctors_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:60897/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync("api/Doctor").Result;

            if (response.IsSuccessStatusCode)
            {
                var doctors = response.Content.ReadAsAsync<IList<Doctor>>().Result;
                gridDoctors.DataSource = doctors;
            }
        }

        private void btnUpdateDoctor_Click(object sender, EventArgs e)
        {
            Doctor d = new Doctor();
            d.Name = txtDoctorName.Text;
            d.Specialization = txtSpecialization.Text;

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:60897/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.PutAsJsonAsync("api/Doctor", d).Result;

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Update succeded!");
            }
            else
            {
                MessageBox.Show("Update failed!");
            }
        }

        private void btnDeleteDoctor_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtDeleteDoctor.Text);

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:60897/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.DeleteAsync("api/Doctor/" + id).Result;

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Delete succeded!");
            }
            else
            {
                MessageBox.Show("Delete failed!");
            }
        }

        private void btnAddSecretary_Click(object sender, EventArgs e)
        {
            UserForm form = new UserForm();
            form.Show();

            Secretary s = new Secretary();
            s.Name = txtSecretaryName.Text;
            s.Address = txtAddress.Text;

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:60897/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.PostAsJsonAsync("api/Secretary", s).Result;

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Adding succeded!");
            }
            else
            {
                MessageBox.Show("Adding failed!");
            }
        }

        private void btnViewSecretary_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:60897/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync("api/Secretary").Result;

            if (response.IsSuccessStatusCode)
            {
                var secretaries = response.Content.ReadAsAsync<IList<Secretary>>().Result;
                gridSecretaries.DataSource = secretaries;
            }
        }

        private void btnUpdateSecretary_Click(object sender, EventArgs e)
        {
            Secretary s = new Secretary();
            s.Name = txtSecretaryName.Text;
            s.Address = txtAddress.Text;

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:60897/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.PutAsJsonAsync("api/Secretary", s).Result;

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Update succeded!");
            }
            else
            {
                MessageBox.Show("Update failed!");
            }
        }

        private void btnDeleteSecretary_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtDeleteSecretary.Text);

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:60897/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.DeleteAsync("api/Secretary/" + id).Result;

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
