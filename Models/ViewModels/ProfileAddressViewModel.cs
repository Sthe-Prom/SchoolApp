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
    public class ProfileAddressViewModel: BaseViewModel
    {
        public Address AddressModel {get;set;}
        public Account Account {get;set;}
        public IEnumerable<Account> Accounts {get;set;} 
        public IEnumerable<Address> Addresses {get;set;} 
        public ProfileViewModel ProfileModel {get;set;}  
        public Microsoft.AspNetCore.Mvc.Rendering.SelectList Users {get;set;}       
    }
}