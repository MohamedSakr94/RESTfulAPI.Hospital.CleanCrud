using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPIs.Hospital.CleanCrud.BLL
{
    public class DoctorAddDTO
    {
        public string Name { get; set; } = string.Empty;
        public string Speciality { get; set; } = string.Empty;
        public float Salary { get; set; }
    }
}
