using BCG_Orgbuilder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BCG_Orgbuilder.Repositories
{
    public interface IApiRepo
    {
        IEnumerable<Api> GetAllCommands();
    }
}
