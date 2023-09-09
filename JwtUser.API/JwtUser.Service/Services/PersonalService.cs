using JwtUser.Core.Entities;
using JwtUser.Core.Repositories;
using JwtUser.Core.Services;
using JwtUser.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JwtUser.Service.Services
{
    public class PersonalService : GenericService<Personal>, IPersonalService
    {
        public PersonalService(IGenericRepository<Personal> genericRepository, IUnitOfWork unitOfWork) : base(genericRepository, unitOfWork)
        {
        }
    }
}
