using FIAP.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FIAP.Models.Repositories
{
    public class LoginRepository : ILoginRepository
    {
        private readonly DataContext _context;

        public LoginRepository(DataContext context)
        {
            _context = context;
        }
        public LoginModel GetLoginByUserName(string email)
        {
            return _context.Login.FirstOrDefault(x => x.USERNAME.Equals(email));
        }
    }
}
