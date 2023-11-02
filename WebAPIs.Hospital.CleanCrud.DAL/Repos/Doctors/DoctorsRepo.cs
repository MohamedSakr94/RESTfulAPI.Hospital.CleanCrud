using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPIs.Hospital.CleanCrud.DAL
{
    public class DoctorsRepo : GenericRepo<Doctor>, IDoctorsRepo
    {
        private readonly HospitalContext context;

        public DoctorsRepo(HospitalContext context):base(context)
        {
            this.context = context;
        }

        public List<Doctor> GetAllByPerformance(int rate)
        {
            return context.Set<Doctor>()
                .AsNoTracking()
                .Where(d=>d.PerformanceRate >= rate )
                .ToList();
        }

        public Doctor? GetDetailsById(int id)
        {
            return context.Set<Doctor>()
                .Include(p => p.Patients)
                .ThenInclude(i => i.Diseases)
                .FirstOrDefault(d => d.ID == id);
        }

    }
}
