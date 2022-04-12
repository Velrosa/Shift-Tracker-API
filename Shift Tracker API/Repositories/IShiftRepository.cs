using Shift_Tracker_API.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Shift_Tracker_API.Repositories
{
    
    public interface IShiftRepository
    {
        Task<IEnumerable<Shift>> Get();
        Task<Shift> Get(int id);
        Task<Shift> Create(Shift shift);
        Task Update(Shift shift);
        Task Delete(int id);
    }
}
