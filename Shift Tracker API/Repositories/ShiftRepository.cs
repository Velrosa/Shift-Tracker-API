using Shift_Tracker_API.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Shift_Tracker_API.Repositories
{
    public class ShiftRepository : IShiftRepository
    {
        private readonly ShiftContext _context;
        public ShiftRepository(ShiftContext context)
        {
            _context = context;
        }
        
        public Task<Shift> Create(Shift shift)
        {
            throw new System.NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Shift>> Get()
        {
            throw new System.NotImplementedException();
        }

        public Task<Shift> Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task Update(Shift shift)
        {
            throw new System.NotImplementedException();
        }
    }
}
