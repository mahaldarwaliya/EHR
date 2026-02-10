using EHR01.Models;

namespace EHR.API.Repositories.Interfaces
{
    public interface IPatientRepository : IGenericRepository<Patient>
    {
        Task<Patient?> GetByMRNAsync(string mrn);
    }
}
