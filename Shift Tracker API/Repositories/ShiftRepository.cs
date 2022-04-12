using Microsoft.EntityFrameworkCore;
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
        
        public async Task<Shift> Create(Shift shift)
        {
            _context.Shifts.Add(shift);
            await _context.SaveChangesAsync();

            return shift;
        }

        public async Task Delete(int id)
        {
            var shiftToDelete = await _context.Shifts.FindAsync(id);
            _context.Shifts.Remove(shiftToDelete);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Shift>> Get()
        {
            return await _context.Shifts.ToListAsync();
        }

        public async Task<Shift> Get(int id)
        {
            return await _context.Shifts.FindAsync(id);
        }

        public async Task Update(Shift shift)
        {
            _context.Entry(shift).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
