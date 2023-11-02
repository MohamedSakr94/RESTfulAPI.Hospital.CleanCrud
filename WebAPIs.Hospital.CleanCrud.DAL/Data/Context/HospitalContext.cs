using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPIs.Hospital.CleanCrud.DAL
{
    public class HospitalContext: DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Disease> Diseases { get; set; }

        public HospitalContext(DbContextOptions options): base(options)
        { }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			#region Seeding Docs

			var doctors = new List<Doctor>
				{
				  new Doctor {
					ID= 1,
					Name= "Jessie",
					Speciality= "Hematology",
					Salary= 27064,
					PerformanceRate= 65,
				  },
				  new Doctor {
					ID= 2,
					Name= "Judy",
					Speciality= "Neurology",
					Salary= 18711,
					PerformanceRate= 32,
				  },
				  new Doctor {
					ID= 3,
					Name= "Naomi",
					Speciality= "Pediatrics",
					Salary= 32145,
					PerformanceRate= 27,
				  },
				  new Doctor {
					ID= 4,
					Name= "Joann",
					Speciality= "Hematology",
					Salary= 9232,
					PerformanceRate= 72,
				  },
				  new Doctor {
					ID= 5,
					Name= "Judy",
					Speciality= "Dermatology",
					Salary= 48498,
					PerformanceRate= 19,
				  },
				  new Doctor {
					ID= 6,
					Name= "Alyssa",
					Speciality= "Gastroenterology",
					Salary= 16586,
					PerformanceRate= 79,
				  },
				  new Doctor {
					ID= 7,
					Name= "Mable",
					Speciality= "Infectious Disease",
					Salary= 33706,
					PerformanceRate= 5,
				  },
				  new Doctor {
					ID= 8,
					Name= "Paula",
					Speciality= "Urology",
					Salary= 19094,
					PerformanceRate= 0,
				  },
				  new Doctor {
					ID= 9,
					Name= "Rafael",
					Speciality= "Pediatrics",
					Salary= 12266,
					PerformanceRate= 97,
				  },
				  new Doctor {
					ID= 10,
					Name= "Sara",
					Speciality= "Pediatrics",
					Salary= 45041,
					PerformanceRate= 82,
				  },
				};

			#endregion
			#region Patients

			var patients = new List<Patient>
				{
				  new Patient { ID= 1, Name= "Dana", DoctorID= 5 },
				  new Patient { ID= 2, Name= "Isaac", DoctorID= 7 },
				  new Patient { ID= 3, Name= "Damon", DoctorID= 9 },
				  new Patient { ID= 4, Name= "Miriam", DoctorID= 8 },
				  new Patient { ID= 5, Name= "Terence", DoctorID= 7 },
				  new Patient { ID= 6, Name= "Roosevelt", DoctorID= 1 },
				  new Patient { ID= 7, Name= "Eduardo", DoctorID= 9 },
				  new Patient { ID= 8, Name= "Wilbert", DoctorID= 8 },
				  new Patient { ID= 9, Name= "Tasha", DoctorID= 5 },
				  new Patient { ID= 10, Name= "Max", DoctorID= 1 },
				  new Patient { ID= 11, Name= "BrIDget", DoctorID= 2 },
				  new Patient { ID= 12, Name= "Juan", DoctorID= 8 },
				  new Patient { ID= 13, Name= "Krystal", DoctorID= 10 },
				  new Patient { ID= 14, Name= "Erma", DoctorID= 10 },
				  new Patient { ID= 15, Name= "Orlando", DoctorID= 6 },
				  new Patient { ID= 16, Name= "Marvin", DoctorID= 5 },
				  new Patient { ID= 17, Name= "Lamar", DoctorID= 4 },
				  new Patient { ID= 18, Name= "Joe", DoctorID= 7 },
				  new Patient { ID= 19, Name= "Wendell", DoctorID= 8 },
				  new Patient { ID= 20, Name= "Sandra", DoctorID= 4 },
				  new Patient { ID= 21, Name= "Stephanie", DoctorID= 6 },
				  new Patient { ID= 22, Name= "Ervin", DoctorID= 7 },
				  new Patient { ID= 23, Name= "Beth", DoctorID= 4 },
				  new Patient { ID= 24, Name= "Gretchen", DoctorID= 7 },
				  new Patient { ID= 25, Name= "Gwendolyn", DoctorID= 2 },
				  new Patient { ID= 26, Name= "Jerry", DoctorID= 7 },
				  new Patient { ID= 27, Name= "Mitchell", DoctorID= 6 },
				  new Patient { ID= 28, Name= "Maggie", DoctorID= 8 },
				  new Patient { ID= 29, Name= "Sandy", DoctorID= 3 },
				  new Patient { ID= 30, Name= "Lloyd", DoctorID= 2 },
				};

			#endregion
			#region Diseases

			var Diseases = new List<Disease>
				{
				  new Disease { ID= 1, Name= "Diabetes" },
				  new Disease { ID= 2, Name= "Hypertension" },
				  new Disease { ID= 3, Name= "Asthma" },
				  new Disease { ID= 4, Name= "Depression" },
				  new Disease { ID= 5, Name= "Arthritis" },
				  new Disease { ID= 6, Name= "Allergy" },
				  new Disease { ID= 7, Name= "Flu" },
				};

			#endregion

			builder.Entity<Doctor>().HasData(doctors);
			builder.Entity<Patient>().HasData(patients);
			builder.Entity<Disease>().HasData(Diseases);
		}
	}
}
