using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiPruebaLinktic.Context;
using ApiPruebaLinktic.Entities;
using ApiPruebaLinktic.Interfaces;

namespace ApiPruebaLinktic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ReservationsController(AppDbContext context)
        {
            _context = context;
        }

        
        
        [HttpGet("Booking-Reservations", Name = "GetBookingReservations")]
        public async Task<ActionResult<IEnumerable<Reservation>>> GetReservations()
        {
            return await _context.Reservation.ToListAsync();
        }

        
        [HttpGet("ViewingReservations", Name = "ViewingReservations")]
        public async Task<ActionResult<IEnumerable<object>>> GetReservation(int idReservation)
        {

            var resultados = "";


            return Ok(resultados);
        }

        
        [HttpPut("ModifyingReservations", Name = "ModifyingReservations")]
        public async Task<IActionResult> PutReservation(int id, Reservation reservation)
        {
            if (id != reservation.id)
            {
                return BadRequest();
            }

            _context.Entry(reservation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ReservationsExists(id))
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

        
        [HttpPost("BookingReservations" ,Name = "AddBookingReservations")]
        public async Task<ActionResult<Reservation>> PostReservation(Reservation reservation)
        {
            _context.Reservation.Add(reservation);
            await _context.SaveChangesAsync();

            return Ok(reservation);
        }

        
        [HttpDelete("CancellingReservations", Name = "CancellingReservations")]
        public async Task<IActionResult> DeleteReservation(int id)
        {
            var reservation = await _context.Reservation.FindAsync(id);
            if (reservation == null)
            {
                return NotFound();
            }

            _context.Reservation.Remove(reservation);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ReservationsExists(int id)
        {
            return _context.Reservation.Any(e => e.id == id);
        }
    }
}
