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
    
    public class ApplicationViewModel: BaseViewModel
    {
         public int ApplicationID { get; set; }

        [Required(ErrorMessage ="Please Enter Your Name")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Please Enter Your Surname")]
        public string Surname { get; set; }

        [Required(ErrorMessage ="Please Enter Your Email")]
        public string Gender { get; set; }

        [Required(ErrorMessage ="Please Enter Your Cell")]
        public string Cell { get; set; }
       
        [Required(ErrorMessage ="Please Indicate Disability")]
        public bool Disability { get; set; }

        [Required(ErrorMessage ="Please enter ID Number")]
        public string IDNumber { get; set; }

        [Required(ErrorMessage ="DOB Not Found")]
        public DateTime DOB { get; set; }

        [Required(ErrorMessage ="Please upload Child Birth Certificate")]
        public IFormFile BirthCertificate { get; set; }

        [Required(ErrorMessage ="Please upload Child School Report")]
        public IFormFile SchoolReport { get; set; }

        [Required(ErrorMessage="Please Indicate Medical Aid")]
        public bool MedicalAid { get; set; }

        [Required]
        public DateTime ApplicationDate { get; set; }

        [Required(ErrorMessage="Applicatiion Does not have a Ref")]
        public string ApplicationRef { get; set; }
        
        public int StatusID { get; set; }

        [Required(ErrorMessage ="Please Login with your account")]
        public int AccountID { get; set; }  

        // [Required(ErrorMessage ="Please Select School")]
        public int SchoolID { get; set; }  

        [Required(ErrorMessage ="Please Select Grade")]
        public string SchoolGrade { get; set; }

        public IEnumerable<Status> Statuses {get;set;} 
        public IEnumerable<Account> Accounts {get;set;}  
        public Microsoft.AspNetCore.Mvc.Rendering.SelectList SchoolList {get;set;}  
        public Microsoft.AspNetCore.Mvc.Rendering.SelectList StatusList {get;set;}  

    }
}