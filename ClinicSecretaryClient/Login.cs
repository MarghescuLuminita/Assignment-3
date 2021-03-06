﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;

namespace ClinicSecretaryClient
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string name = txtUser.Text;
            string password = txtPassword.Text;

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:60897/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync("api/User").Result;

            if (response.IsSuccessStatusCode)
            {
                var users = response.Content.ReadAsAsync<IList<User>>().Result;
                foreach (var user in users)
                {
                    if (user.Username == txtUser.Text)
                    {
                        if (user.IsSecretary)
                        {
                            Security secure = new Security();
                            //if (secure.VerifyHash(password, user.Password))
                            //{
                                ClinicSecretary form = new ClinicSecretary();
                                form.Show();
                            //}
                        }
                        else
                        {
                            MessageBox.Show("Acces denied!");
                            break;
                        }
                    }
                }
            }
        }


    }
}

            

