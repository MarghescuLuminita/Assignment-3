using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministratorClient
{
    public class Doctor
    {
        public int IdDoctor { get; set; }
        public int idUser { get; set; }
        public string Name { get; set; }
        public string Specialization { get; set; }
    }
}
