using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolApp.Models
{        
    
    public class Application
    {
        //[Key]
        public int ApplicationID { get; set; }

        [Required(ErrorMessage ="Please Enter Your Name")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Please Enter Your Surname")]
        public string Surname { get; set; }

        [Required(ErrorMessage ="Please Enter Your Email")]
        public string Gender { get; set; }

        [Required(ErrorMessage ="Please Enter Your Cell Number")]        
        public string Cell { get; set; }
       
        [Required(ErrorMessage ="Please Select unit logo")]
        public bool Disability { get; set; }

        [Required(ErrorMessage ="Please Enter ID Number")]
        public string IDNumber { get; set; }

        [Required(ErrorMessage ="Please Upload Identity Doc")]
        public DateTime DOB { get; set; }

        [Required(ErrorMessage ="Please upload Child Birth Certificate")]
        public string BirthCertificate { get; set; }

        [Required]
        public string SchoolReport { get; set; }

        [Required(ErrorMessage = "Please Indicate Medical Aid")]
        public bool MedicalAid { get; set; }

        [Required]
        public DateTime ApplicationDate { get; set; }

        [Required(ErrorMessage = "Applicatiion Does not have a Ref")]
        public string ApplicationRef { get; set; }

        [Required(ErrorMessage ="Please Select Grade")]
        public string SchoolGrade { get; set; }

        /* Relationship
           FKs         
        */
        [Required(ErrorMessage ="Please Login with your account")]
        public int AccountID { get; set; }  
       
        public int StatusID { get; set; }  
        
        public int SchoolID { get; set; }  
             
        /* Ref Nav Properties */      
        [ForeignKey("AccountID")]
        public virtual Account Account { get; set; }

        [ForeignKey("StatusID")]
        public virtual Status Status { get; set; }

        [ForeignKey("SchoolID")]
        public virtual School School { get; set; }

        /* Ref. by */        
        public virtual ICollection<Appeal> Appeal { get; set; }
        

    }
}
