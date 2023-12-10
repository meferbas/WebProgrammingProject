using AirlineSeatReservationSystem.Entity;
namespace  AirlineSeatReservationSystem.Data.Abstract
{
    public interface IFlightRepository
    {
        IQueryable<Flight> Flights {get;}

        void getFlight(Flight Flight);
    }
}