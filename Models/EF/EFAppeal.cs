//using SchoolApp.Models.EF;
using SchoolApp.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolApp.Models
{
    public class EFAppeal: IAppeal
    {
        public AppDbContext context;

        public IEnumerable<Appeal> Appeals => context.Appeal;        

        public EFAppeal(AppDbContext ctx)
        {
            context = ctx;
        }

        public async Task SaveAppeal(Appeal Appeal)
        {
            if (Appeal.AppealID == 0)
            {
                context.Appeal.Add(Appeal);
            }
            else
            {
                Appeal dbEntry = context.Appeal
                    .FirstOrDefault(c => c.AppealID == Appeal.AppealID);

                if (dbEntry != null)
                {
                    dbEntry.AppealReasonID = Appeal.AppealReasonID;
                    dbEntry.ApplicationID = Appeal.ApplicationID;
                    dbEntry.StatusID = Appeal.StatusID;
                    dbEntry.AppealDate = Appeal.AppealDate;                     
                }
            }

            context.SaveChanges(); //commit to db            
        }

        public Appeal DeleteAppeal(int AppealID)
        {
            Appeal dbEntry = context.Appeal
                .FirstOrDefault(c => c.AppealID == AppealID);

            if (dbEntry != null)
            {
                context.Appeal.Remove(dbEntry);
                context.SaveChanges();
            }

            return dbEntry;
        }

    }
}
