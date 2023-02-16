//using SchoolApp.Models.EF;
using SchoolApp.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolApp.Models
{
    public class EFAppealReason: IAppealReason
    {
        public AppDbContext context;

        public IEnumerable<AppealReason> AppealReasons => context.AppealReason;        

        public EFAppealReason(AppDbContext ctx)
        {
            context = ctx;
        }

        public async Task SaveAppealReason(AppealReason AppealReason)
        {
            if (AppealReason.AppealReasonID == 0)
            {
                context.AppealReason.Add(AppealReason);
            }
            else
            {
                AppealReason dbEntry = context.AppealReason
                    .FirstOrDefault(c => c.AppealReasonID == AppealReason.AppealReasonID);

                if (dbEntry != null)
                {
                    dbEntry.AppealReasonName = AppealReason.AppealReasonName;
                    
                }
            }

            context.SaveChanges(); //commit to db            
        }

        public AppealReason DeleteAppealReason(int AppealReasonID)
        {
            AppealReason dbEntry = context.AppealReason
                .FirstOrDefault(c => c.AppealReasonID == AppealReasonID);

            if (dbEntry != null)
            {
                context.AppealReason.Remove(dbEntry);
                context.SaveChanges();
            }

            return dbEntry;
        }

    }
}
