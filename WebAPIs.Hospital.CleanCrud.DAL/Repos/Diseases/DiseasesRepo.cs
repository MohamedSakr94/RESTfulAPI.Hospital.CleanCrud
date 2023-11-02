using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPIs.Hospital.CleanCrud.DAL
{
    public class DiseasesRepo: GenericRepo<Disease>, IDiseasesRepo
    {
        private readonly HospitalContext context;

        public DiseasesRepo(HospitalContext context): base(context)
        {
            this.context = context;
        }
    }
}
