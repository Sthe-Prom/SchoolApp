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
    public class SettingsViewModel: BaseViewModel
    {
        public AppealReason AppealReason {get;set;}
        public Status Status {get;set;}
        public IEnumerable<AppealReason> AppealReasons {get;set;} 
        public IEnumerable<Status> Statuses {get;set;} 
           
    }
}