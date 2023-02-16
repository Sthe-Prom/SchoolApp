//using SchoolApp.Models.EF;
using SchoolApp.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolApp.Models
{
    public class EFStatus: IStatus
    {
        public AppDbContext context;

        public IEnumerable<Status> Statuses => context.Status;        

        public EFStatus(AppDbContext ctx)
        {
            context = ctx;
        }

        public async Task SaveStatus(Status Status)
        {
            if (Status.StatusID == 0)
            {
                context.Status.Add(Status);
            }
            else
            {
                Status dbEntry = context.Status
                    .FirstOrDefault(c => c.StatusID == Status.StatusID);

                if (dbEntry != null)
                {
                    dbEntry.StatusName = Status.StatusName;                                       
                }
            }

            context.SaveChanges(); //commit to db            
        }

        public Status DeleteStatus(int StatusID)
        {
            Status dbEntry = context.Status
                .FirstOrDefault(c => c.StatusID == StatusID);

            if (dbEntry != null)
            {
                context.Status.Remove(dbEntry);
                context.SaveChanges();
            }

            return dbEntry;
        }

    }
}
