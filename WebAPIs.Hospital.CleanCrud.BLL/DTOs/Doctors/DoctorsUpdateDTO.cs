using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPIs.Hospital.CleanCrud.BLL
{
    public class DoctorsUpdateDTO
    {
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Speciality { get; set; } = string.Empty;
        public float Salary { get; set; }
    }
}
