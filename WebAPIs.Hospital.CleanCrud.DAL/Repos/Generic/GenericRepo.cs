using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPIs.Hospital.CleanCrud.DAL
{
    public class GenericRepo<TEntity> : IGenericRepo<TEntity>
where TEntity : class
{
        private readonly HospitalContext context;

        public GenericRepo(HospitalContext context)
        {
            this.context = context;
        }
    

        public List<TEntity> GetAll()
        {
            return context.Set<TEntity>().ToList();
        }

        public TEntity? GetById(int id)
        {
            return context.Set<TEntity>().Find(id);
        }

        public void Add(TEntity TEntity)
        {
           context.Set<TEntity>().Add(TEntity);
        }
        public void Update(TEntity TEntity)
        {
            context.Set<TEntity>().Update(TEntity);
        }
        public int SaveChanges()
        {
            return context.SaveChanges();
        }
    }
}
