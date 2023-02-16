//using SchoolApp.Models.EF;
using SchoolApp.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolApp.Models
{
    public class EFApplication: IApplication
    {
        public AppDbContext context;

        public IEnumerable<Application> Applications => context.Application;        

        public EFApplication(AppDbContext ctx)
        {
            context = ctx;
        }

        public async Task SaveApplication(Application Application)
        {
            if (Application.ApplicationID == 0)
            {
                context.Application.Add(Application);
            }
            else
            {
                Application dbEntry = context.Application
                    .FirstOrDefault(c => c.ApplicationID == Application.ApplicationID);

                if (dbEntry != null)
                {               
                    dbEntry.Name = Application.Name;
                    dbEntry.Surname = Application.Surname;
                    dbEntry.Gender = Application.Gender;
                    dbEntry.Cell = Application.Cell;                   
                    dbEntry.Disability = Application.Disability;
                    dbEntry.IDNumber = Application.IDNumber;
                    dbEntry.DOB = Application.DOB;
                    dbEntry.BirthCertificate = Application.BirthCertificate;
                    dbEntry.SchoolReport = Application.SchoolReport;
                    dbEntry.ApplicationDate = Application.ApplicationDate;
                    dbEntry.ApplicationRef = Application.ApplicationRef;
                    dbEntry.MedicalAid = Application.MedicalAid;
                    dbEntry.StatusID = Application.StatusID;
                    dbEntry.AccountID = Application.AccountID;
                    dbEntry.SchoolID = Application.SchoolID;
                    dbEntry.SchoolGrade = Application.SchoolGrade;
                }
            }

            context.SaveChanges(); //commit to db            
        }

        public Application DeleteApplication(int ApplicationID)
        {
            Application dbEntry = context.Application
                .FirstOrDefault(c => c.ApplicationID == ApplicationID);

            if (dbEntry != null)
            {
                context.Application.Remove(dbEntry);
                context.SaveChanges();
            }

            return dbEntry;
        }

    }
}
