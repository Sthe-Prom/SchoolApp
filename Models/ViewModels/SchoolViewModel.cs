using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;  
using SchoolApp.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace SchoolApp.Models
{
    public class SchoolViewModel: BaseViewModel
    {
        public Address AddressModel {get;set;}
        public Account Account {get;set;}
        public School School {get;set;}
        public IEnumerable<Appeal> Appeals {get;set;} 
        public IEnumerable<Account> Accounts {get;set;}
        public IEnumerable<Application> Applications {get;set;} 
        public IEnumerable<Status> Statuses {get;set;} 
        public IEnumerable<AppealReason> AppealReasons {get;set;} 
        public IEnumerable<School> Schools {get;set;} 
        public ProfileViewModel ProfileModel {get;set;}  
        public Microsoft.AspNetCore.Mvc.Rendering.SelectList Users {get;set;}       
    }
}