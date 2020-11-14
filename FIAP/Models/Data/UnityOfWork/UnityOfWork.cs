using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FIAP.Models.Data.UnityOfWork
{
    public class UnityOfWork : IUnityOfWork
    {
        private readonly DataContext _context;

        public UnityOfWork(DataContext context)
        {
            _context = context;
        }
        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Rollback()
        {
            
        }
    }
}
