using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPIs.Hospital.CleanCrud.DAL;

namespace WebAPIs.Hospital.CleanCrud.BLL
{
    public class DoctorsManager : IDoctorsManager
    {
        private readonly IUnitOfWork unitOfWork;

        //private readonly IDoctorsRepo doctorsRepo;

        //public DoctorsManager(IDoctorsRepo doctorsRepo)
        //{
        //    this.doctorsRepo = doctorsRepo;
        //}
        public DoctorsManager(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public List<DoctorsReadDTO> GetAllForUsers()
        {
            var doctor = unitOfWork.DoctorsRepo.GetAll();
            return doctor.Select(d => new DoctorsReadDTO
            {
                ID = d.ID,
                Name = d.Name,
                Speciality = d.Speciality,
                PerformanceRate = d.PerformanceRate
            }).ToList();
        }

        public void Add(DoctorAddDTO doctorToAdd)
        {
            Doctor doctor = new Doctor
            {
                Name = doctorToAdd.Name,
                Speciality = doctorToAdd.Speciality,
                Salary = doctorToAdd.Salary
            };
            unitOfWork.DoctorsRepo.Add(doctor);
            unitOfWork.SaveChanges();
        }
        public DoctorGetDetailByIdsDTO? GetDetailsById(int id)
        {
            Doctor? doctor = unitOfWork.DoctorsRepo.GetDetailsById(id);
            if (doctor == null)
            { return null; }
            return new DoctorGetDetailByIdsDTO
            {
                ID = doctor.ID,
                Name = doctor.Name,
                Speciality = doctor.Speciality,
                PerformanceRate = doctor.PerformanceRate,
                Patients = doctor.Patients
                .Select(p => new PatietChildDTO
                {
                    ID = p.ID,
                    Name = p.Name,
                    Diseases = p.Diseases
                    .Select(d => new DiseasesChildDTO
                    {
                        ID = d.ID,
                        Name = d.Name
                    }).ToList()
                }).ToList()

            };
        }
        public bool Update(DoctorsUpdateDTO doctorToUpdate)
        {

            Doctor? doctor = unitOfWork.DoctorsRepo.GetById(doctorToUpdate.ID);
            if(doctor == null)
            {
                return false;
            }
            doctor.Name = doctorToUpdate.Name;
            doctor.Speciality = doctorToUpdate.Speciality;
            doctor.Salary = doctorToUpdate.Salary;

            unitOfWork.DoctorsRepo.Update(doctor);
            unitOfWork.SaveChanges();
            return true;
        }
    }

}
