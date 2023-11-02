using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPIs.Hospital.CleanCrud.DAL
{
    public interface IGenericRepo<TEntity> where TEntity :class
    {
        void Add(TEntity TEntity);
        List<TEntity> GetAll();
        void Update(TEntity TEntity);
        TEntity? GetById(int id);
        int SaveChanges();
    }
}
