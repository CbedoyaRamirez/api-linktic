using ApiPruebaLinktic.Entities;

namespace ApiPruebaLinktic.Interfaces
{
    public interface IReservations
    {
        Task<List<Reservation>> GetAllEstudianteAsync();
    }
}
