using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPIs.Hospital.CleanCrud.DAL;

namespace WebAPIs.Hospital.CleanCrud.DAL
{
    public class Patient
    {
        public int ID { get; set; }
        public string? Name { get; set; }

        public int DoctorID { get; set; }

        public Doctor Doctor { get; set; } = null!;
        public List<Disease> Diseases { get; set; } = new ();
    }
}
