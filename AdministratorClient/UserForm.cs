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
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (chkDoctor.Checked)
            {
                bool isDoctor = chkDoctor.Checked;
                User u = new User();
                u.Username = username;
                u.Password = password;
                u.IsDoctor = isDoctor;
                u.IsAdmin = false;
                u.IsSecretary = false;

                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:60897/");

                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = client.PostAsJsonAsync("api/User", u).Result;
            }

            if (chkSecretary.Checked)
            {
                bool isSecretary = chkSecretary.Checked;
                User u = new User();
                u.Username = username;
                u.Password = password;
                u.IsDoctor = false;
                u.IsAdmin = false;
                u.IsSecretary = isSecretary;

                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:60897/");

                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = client.PostAsJsonAsync("api/User", u).Result;
            }

            if (chkAdministrator.Checked)
            {
                bool isAdmin = chkAdministrator.Checked;
                User u = new User();
                u.Username = username;
                u.Password = password;
                u.IsDoctor = false;
                u.IsAdmin = isAdmin;
                u.IsSecretary = false;

                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:60897/");

                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = client.PostAsJsonAsync("api/User", u).Result;
            }
        }

    }
}
