//using SchoolApp.Models.EF;
using SchoolApp.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolApp.Models
{
    public class EFAccount: IAccount
    {
        public AppDbContext context;

        public IEnumerable<Account> Accounts => context.Account;        

        public EFAccount(AppDbContext ctx)
        {
            context = ctx;
        }

        public async Task SaveAccount(Account Account)
        {
            if (Account.AccountID == 0)
            {
                context.Account.Add(Account);
            }
            else
            {
                Account dbEntry = context.Account
                    .FirstOrDefault(c => c.AccountID == Account.AccountID);

                if (dbEntry != null)
                {
                    dbEntry.Name = Account.Name;
                    dbEntry.Surname = Account.Surname;
                    dbEntry.Email = Account.Email;
                    dbEntry.Cell = Account.Cell;
                    dbEntry.ProfileImg = Account.ProfileImg;
                    dbEntry.Id = Account.Id;
                    dbEntry.MaritalStatus = Account.MaritalStatus;
                    dbEntry.IdentityDoc = Account.IdentityDoc;
                    dbEntry.MarriageDoc = Account.MarriageDoc;
                    dbEntry.FullAddress = Account.FullAddress;
                    // dbEntry.SubunitID = Account.SubunitID;
                }
            }

            context.SaveChanges(); //commit to db
            
        }

        public Account DeleteAccount(int AccountID)
        {
            Account dbEntry = context.Account
                .FirstOrDefault(c => c.AccountID == AccountID);

            if (dbEntry != null)
            {
                context.Account.Remove(dbEntry);
                context.SaveChanges();
            }

            return dbEntry;
        }

    }
}
