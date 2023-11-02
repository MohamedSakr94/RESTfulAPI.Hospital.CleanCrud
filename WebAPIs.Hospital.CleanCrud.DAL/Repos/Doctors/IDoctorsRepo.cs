namespace WebAPIs.Hospital.CleanCrud.DAL
{
    public interface IDoctorsRepo: IGenericRepo<Doctor>
    {
        List<Doctor> GetAllByPerformance(int rate);
        Doctor? GetDetailsById(int id);
    }
}