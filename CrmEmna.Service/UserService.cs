using CrmEmna.Data.Infrastructure;
using CrmEmna.Domain.Entities;
using Service.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmEmna.Service
{
    public class UserService:Service<User>,IUserService
    {
        static IDataBaseFactory factory = new DataBaseFactory();
        static IUnitOfWork UTK = new UnitOfWork(factory);
        public UserService():base(UTK)
        {

        }
    }
}
