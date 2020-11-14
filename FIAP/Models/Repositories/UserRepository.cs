using FIAP.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FIAP.Models.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _context;

        public UserRepository(DataContext context)
        {
            _context = context;
        }
        public void Add(UserModel user)
        {
            _context.Add(user);
        }

        public void Delete(UserModel user)
        {
            _context.Remove(user);
        }

        public IEnumerable<UserModel> GetUsers()
        {
            return _context.Usuarios;
        }

        public IEnumerable<UserModel> GetUsersByEmail(string email)
        {
            return _context.Usuarios.Where(x => x.EMAIL.Contains(email));
        }

        public UserModel GetUsersById(int id)
        {
            return _context.Usuarios.FirstOrDefault(x => x.ID.Equals(id));
        }
    }
}
