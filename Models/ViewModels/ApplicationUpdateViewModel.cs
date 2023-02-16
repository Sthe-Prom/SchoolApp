using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http; 
using Microsoft.AspNetCore.Mvc.ModelBinding;
using SchoolApp.Models;
//using SchoolApp.Models.EF;

namespace SchoolApp.Models
{   
    
    public class ApplicationUpdateViewModel: BaseViewModel
    {
        public IEnumerable<Status> Statuses {get;set;} 
        public IEnumerable<Account> Accounts {get;set;}  
        public Microsoft.AspNetCore.Mvc.Rendering.SelectList SchoolList {get;set;}  
        public Microsoft.AspNetCore.Mvc.Rendering.SelectList StatusList {get;set;}  
        public Application Application{get;set;}

        public int? StatusID {get;set;}
    }
}