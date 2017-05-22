using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicSecretaryClient
{
    public class Consultation
    {
        public int idConsultation { get; set; }
        public int idDoctor { get; set; }
        public int idPatient { get; set; }
        public DateTime date { get; set; }
        public string treatment { get; set; }
    }
}
