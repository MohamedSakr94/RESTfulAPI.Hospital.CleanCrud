using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPIs.Hospital.CleanCrud.BLL
{
    public class PatietChildDTO
    {
        public int ID { get; set; }
        public string? Name { get; set; }

        public ICollection<DiseasesChildDTO> Diseases { get; set; } = new HashSet<DiseasesChildDTO>();
    }
}
