using EHR.API.Data;
using EHR01.Models;
using EHR.API.Repositories.Interfaces;
using EHR.API.Data;
using Microsoft.EntityFrameworkCore;

namespace EHR.API.Repositories.Implementations
{
    public class PatientRepository : GenericRepository<Patient>, IPatientRepository
    {
        private readonly ApplicationDbContext _context;

        public PatientRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Patient?> GetByMRNAsync(string mrn)
        {
            return await _context.Patients
                                 .FirstOrDefaultAsync(p => p.MRN == mrn);
        }
    }
}
