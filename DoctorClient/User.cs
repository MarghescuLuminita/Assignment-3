using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorClient
{
    public class User
    {
        public int IdUser { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsSecretary { get; set; }
        public bool IsDoctor { get; set; }
        public bool IsAdmin { get; set; }
    }
}
