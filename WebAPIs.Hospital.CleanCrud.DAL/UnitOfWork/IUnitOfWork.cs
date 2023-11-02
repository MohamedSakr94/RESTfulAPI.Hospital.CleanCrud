using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPIs.Hospital.CleanCrud.DAL
{
    public interface IUnitOfWork
    {
        public IDoctorsRepo DoctorsRepo { get;  }
        public IPatientsRepo PatientsRepo { get;  }
        public IDiseasesRepo DiseasesRepo { get;  }
        int SaveChanges();
    }
}
