using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicSecretaryClient
{
    public class Patient
    {
        public int IdPatient { get; set; }
        public string Name { get; set; }
        public int IdentityCardNumber { get; set; }
        public int CNP { get; set; }
        public DateTime Birthdate { get; set; }
        public string Address { get; set; }
    }
}