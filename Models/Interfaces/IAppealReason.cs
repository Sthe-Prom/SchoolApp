//using SchoolApp.Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolApp.Models.Interfaces
{
    public interface IAppealReason
    {
        IEnumerable<AppealReason> AppealReasons { get; }

        Task SaveAppealReason(AppealReason AppealReason);
        
        AppealReason DeleteAppealReason(int AppealReasonID);
    }
}