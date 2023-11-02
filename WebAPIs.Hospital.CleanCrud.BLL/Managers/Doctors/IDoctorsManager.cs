namespace WebAPIs.Hospital.CleanCrud.BLL
{
    public interface IDoctorsManager
    {
        List<DoctorsReadDTO> GetAllForUsers();
        void Add(DoctorAddDTO doctorToAdd);
        bool Update(DoctorsUpdateDTO doctorToUpdate);
        DoctorGetDetailByIdsDTO? GetDetailsById(int id);
    }
}