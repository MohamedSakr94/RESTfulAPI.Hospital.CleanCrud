using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPIs.Hospital.CleanCrud.DAL;

namespace WebAPIs.Hospital.CleanCrud.DAL
{
    public class Doctor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Name { get; set; } =string.Empty;
        public string Speciality { get; set; } = string.Empty;
        public int PerformanceRate{ get; set; }
        public float Salary { get; set; }

        public List<Patient> Patients { get; set; } = new ();

    }
}
