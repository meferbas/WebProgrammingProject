using AirlineSeatReservationSystem.Entity;
using AirlineSeatReservationSystem.Data.Abstract;
using AirlineSeatReservationSystem.Data.Concrete.Efcore;

namespace AirlineSeatReservationSystem.Data.Concrete
{
    public class EfUserRepository : IUserRepository
    {

        private DataContext _context;
        public EfUserRepository(DataContext context)
        {
            _context = context;
        }
        public IQueryable<User> Users => _context.Users;
        public void CreateUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }
    }
}