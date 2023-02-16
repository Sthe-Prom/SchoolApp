using SchoolApp.Models;
using SchoolApp.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolApp.Models
{
    public class EFAppealStatus: IAppealStatus
    {
        public AppDbContext context;

        public IEnumerable<AppealStatus> AppealStatuses => context.AppealStatus;

        public EFAppealStatus(AppDbContext ctx)
        {
            context = ctx;
        }

        public async Task SaveAppealStatus(AppealStatus AppealStatus)
        {
            if (AppealStatus.AppealStatusID == 0)
            {
                context.AppealStatus.Add(AppealStatus);
            }
            else
            {
                AppealStatus dbEntry = context.AppealStatus
                    .FirstOrDefault(c => c.AppealStatusID == AppealStatus.AppealStatusID);

                if (dbEntry != null)
                {
                    dbEntry.AppealID = AppealStatus.AppealID;      
                    dbEntry.StatusID = AppealStatus.StatusID;                                     
                }
            }

            context.SaveChanges(); //commit to db
        }

        public AppealStatus DeleteAppealStatus(int AppealStatusID)
        {
            AppealStatus dbEntry = context.AppealStatus
                .FirstOrDefault(c => c.AppealStatusID == AppealStatusID);

            if (dbEntry != null)
            {
                context.AppealStatus.Remove(dbEntry);
                context.SaveChanges();
            }

            return dbEntry;
        }

    }
}
