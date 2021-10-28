using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using KeyboardAPI.Models;

namespace KeyboardAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KeyboardsController : ControllerBase
    {
        private readonly KeyboardDbContext _context;

        public KeyboardsController(KeyboardDbContext context)
        {
            _context = context;
        }

        // GET: api/Keyboards
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Keyboard>>> GetKeyboards()
        {
            return await _context.Keyboards
                .Include("Brand")
                .Include("ConnectionType")
                .Include("KeyLayout")
                .Include("KeyboardDesign")
                .Include("KeyboardSize")
                .Include("MechanicalSwitchColorNavigation")
                .Include("SwitchMechanism")
                .ToListAsync();
        }
         
        // GET: api/Keyboards/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Keyboard>> GetKeyboard(int id)
        {
            var keyboard = await _context.Keyboards
                .Include("Brand")
                .Include("ConnectionType")
                .Include("KeyLayout")
                .Include("KeyboardDesign")
                .Include("KeyboardSize")
                .Include("MechanicalSwitchColorNavigation")
                .Include("SwitchMechanism")
                .Where(k => k.Id == id)
                .FirstOrDefaultAsync();

            if (keyboard == null)
            {
                return NotFound();
            }

            return keyboard;
        }

        // PUT: api/Keyboards/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutKeyboard(int id, Keyboard keyboard)
        {
            if (id != keyboard.Id)
            {
                return BadRequest();
            }

            _context.Entry(keyboard).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KeyboardExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Keyboards
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Keyboard>> PostKeyboard(Keyboard keyboard)
        {
            _context.Keyboards.Add(keyboard);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetKeyboard", new { id = keyboard.Id }, keyboard);
        }

        // DELETE: api/Keyboards/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteKeyboard(int id)
        {
            var keyboard = await _context.Keyboards.FindAsync(id);
            if (keyboard == null)
            {
                return NotFound();
            }

            _context.Keyboards.Remove(keyboard);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool KeyboardExists(int id)
        {
            return _context.Keyboards.Any(e => e.Id == id);
        }
    }
}
