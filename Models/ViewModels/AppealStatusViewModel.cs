using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;  
using SchoolApp.Models;

namespace SchoolApp.Models
{
    public class AppealStatusViewModel: BaseViewModel
    {
        public Application Application {get;set;}
        public IEnumerable<Application> Applications {get;set;}
        public Account Account{get;set;} 
        public IEnumerable<Account> Accounts{get;set;}      
      
        public int AppealStatusID{get;set;}
        public int? AppealID{get;set;}
        public int? StatusID{get;set;}
       
        public Microsoft.AspNetCore.Mvc.Rendering.SelectList AppealSelect {get;set;}

        public Microsoft.AspNetCore.Mvc.Rendering.SelectList StatusSelect {get;set;}
       
       
    }
}