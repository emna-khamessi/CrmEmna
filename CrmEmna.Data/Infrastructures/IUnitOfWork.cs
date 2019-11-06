using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmEmna.Data.Infrastructure
{
   public interface IUnitOfWork:IDisposable
    {
        void commit();
        IRepositoryBase<T> GetRepositoryBase<T>() where T:class;
        



        
    }
}
