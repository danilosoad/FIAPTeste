using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FIAP.Models.Repositories
{
    public interface ILoginRepository
    {
        LoginModel GetLoginByUserName(string email);
    }
}
