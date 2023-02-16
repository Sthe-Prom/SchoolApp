//using SchoolApp.Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolApp.Models.Interfaces
{
    public interface IAppeal
    {
        IEnumerable<Appeal> Appeals { get; }

        Task SaveAppeal(Appeal Appeal);
        
        Appeal DeleteAppeal(int AppealID);
    }
}