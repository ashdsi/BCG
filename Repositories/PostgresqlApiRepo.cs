using BCG_Orgbuilder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BCG_Orgbuilder.Repositories
{
    public class PostgresqlApiRepo : IApiRepo
    {
        private readonly ApiContext _context;
        public PostgresqlApiRepo(ApiContext context)
        {
            _context = context;
        }
        public IEnumerable<Api> GetAllCommands()
        {
            return _context.customer.ToList();
        }
    }
}
