using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPIs.Hospital.CleanCrud.DAL
{
    public class Disease
    {
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<Patient> Patients { get; set; } = new ();
    }
}
