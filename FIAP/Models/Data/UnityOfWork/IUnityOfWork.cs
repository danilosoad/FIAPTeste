using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FIAP.Models.Data.UnityOfWork
{
    public interface IUnityOfWork
    {
        void Commit();
        void Rollback();
    }
}
