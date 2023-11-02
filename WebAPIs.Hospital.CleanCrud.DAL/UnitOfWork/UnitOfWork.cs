using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPIs.Hospital.CleanCrud.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly HospitalContext context;

        public IDoctorsRepo DoctorsRepo { get; }
        public IPatientsRepo PatientsRepo { get; }
        public IDiseasesRepo DiseasesRepo { get; }
        public UnitOfWork(HospitalContext context, IDoctorsRepo DoctorsRepo, IPatientsRepo PatientsRepo, IDiseasesRepo DiseasesRepo)
        {
            this.context = context;
            this.DoctorsRepo = DoctorsRepo;
            this.PatientsRepo = PatientsRepo;
            this.DiseasesRepo = DiseasesRepo;
        }
        public int SaveChanges()
        {
            return context.SaveChanges();
        }
    }
}
