using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;  
using SchoolApp.Models;
//using SchoolApp.Models.EF;
using SchoolApp.Models.Interfaces;


namespace SchoolApp.Models
{
    public class BaseViewModel
    {
        public IEnumerable<Account> Accounts {get;set;}           
    }
}