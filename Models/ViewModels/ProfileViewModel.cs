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
    public class ProfileViewModel: BaseViewModel
    {
        public int AccountID {get;set;}

        [Required(ErrorMessage ="Please enter your Name:")]
        public string Name {get;set;}

        [Required(ErrorMessage = "Please enter your surname:")]
        public string Surname {get;set;}

        [Required (ErrorMessage = "Please enter your email:")]        
        public string Email {get;set;}   

        [Required(ErrorMessage = "Please upload Catalogue Image liugly:")]
        public IFormFile ProfileImg {get;set;} 
          
        [Required(ErrorMessage = "Please enter your Cell Number:")]
        public string Cell {get;set;}   

        [Required(ErrorMessage ="Please Log in or Register Your account")]
        public string Id { get; set; }

        [Required(ErrorMessage ="Please Select Marital Status")]
        public string MaritalStatus { get; set; }

        [Required(ErrorMessage ="Please Upload Identity Doc")]
        public IFormFile IdentityDoc { get; set; }

        // [Required(ErrorMessage ="Please Select unit logo")]
        public IFormFile MarriageDoc { get; set; }

        public string FullAddress { get; set; }

        public Microsoft.AspNetCore.Mvc.Rendering.SelectList Users {get;set;}


    }
}