using Microsoft.AspNetCore.Mvc;
using Shift_Tracker_API.Models;
using Shift_Tracker_API.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Shift_Tracker_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShiftsController : ControllerBase
    {
        private readonly IShiftRepository _shiftrepository;

        public ShiftsController(IShiftRepository shiftRepository)
        {
            _shiftrepository = shiftRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Shift>> GetShifts()
        {
            return await _shiftrepository.Get();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Shift>> GetShifts(int id)
        {
            return await _shiftrepository.Get(id);
        }
        
        [HttpPost]
        public async Task<ActionResult<Shift>> PostShifts([FromBody] Shift shift)
        {
            var newShift = await _shiftrepository.Create(shift);
            return CreatedAtAction(nameof(GetShifts), new { id = newShift.ShiftId }, newShift);
        }

        [HttpPut]
        public async Task<ActionResult> PutShifts(int id, [FromBody] Shift shift)
        {
            if(id != shift.ShiftId)
            {
                return BadRequest();
            }

            await _shiftrepository.Update(shift);

            return NoContent();
        }

        [HttpDelete]
        public async Task<ActionResult> Delete(int id)
        {
            var shiftToDelete = await _shiftrepository.Get(id);
            if(shiftToDelete == null) { return NotFound(); }

            await _shiftrepository.Delete(shiftToDelete.ShiftId);
            return NoContent();
        }
    }
}
