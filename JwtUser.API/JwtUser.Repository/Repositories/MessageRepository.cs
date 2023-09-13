using JwtUser.Core.Entities;
using JwtUser.Core.Repositories;
using JwtUser.Repository.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JwtUser.Repository.Repositories
{
    public class MessageRepository : GenericRepository<Message>, IMessageRepository
    {
        public MessageRepository(AppDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<List<Message>> GetMessages(string userid, string companyid)
        {
            return  await _dbContext.Messages.Where(x=>x.FromId==userid && x.ToId==companyid || x.ToId==userid && x.FromId==companyid).ToListAsync();
        }
    }
}
