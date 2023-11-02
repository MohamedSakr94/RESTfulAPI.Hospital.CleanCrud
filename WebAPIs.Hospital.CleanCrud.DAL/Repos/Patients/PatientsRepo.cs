using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPIs.Hospital.CleanCrud.DAL
{
    public class PatientsRepo: GenericRepo<Patient>, IPatientsRepo
    {
        private readonly HospitalContext context;

        public PatientsRepo(HospitalContext context): base(context)
        {
            this.context = context;
        }
    }
}
