//using SchoolApp.Models.EF;
using SchoolApp.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolApp.Models
{
    public class EFSchool: ISchool
    {
        public AppDbContext context;

        public IEnumerable<School> Schools => context.School;        

        public EFSchool(AppDbContext ctx)
        {
            context = ctx;
        }

        public async Task SaveSchool(School School)
        {
            if (School.SchoolID == 0)
            {
                context.School.Add(School);
            }
            else
            {
                School dbEntry = context.School
                    .FirstOrDefault(c => c.SchoolID == School.SchoolID);

                if (dbEntry != null)
                {
                    dbEntry.SchoolName = School.SchoolName;
                    dbEntry.SchoolContact = School.SchoolContact;
                    dbEntry.SchoolClerk = School.SchoolClerk;
                    dbEntry.StreetNumber = School.StreetNumber;
                    dbEntry.StreetNumber = School.StreetNumber;
                    dbEntry.City = School.City;
                    dbEntry.Suburb = School.Suburb; 
                    dbEntry.Zip = School.Zip;    
                    dbEntry.Id = School.Id;                 
                }
            }

            context.SaveChanges(); //commit to db            
        }

        public School DeleteSchool(int SchoolID)
        {
            School dbEntry = context.School
                .FirstOrDefault(c => c.SchoolID == SchoolID);

            if (dbEntry != null)
            {
                context.School.Remove(dbEntry);
                context.SaveChanges();
            }

            return dbEntry;
        }

    }
}
