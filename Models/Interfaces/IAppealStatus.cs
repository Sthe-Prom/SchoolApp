//using SchoolApp.Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolApp.Models.Interfaces
{
    public interface IAppealStatus
    {
        IEnumerable<AppealStatus> AppealStatuses { get; }

        Task SaveAppealStatus(AppealStatus AppealStatus);
        
        AppealStatus DeleteAppealStatus(int AppealStatusID);
    }
}