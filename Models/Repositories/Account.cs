using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolApp.Models
{    
    public class Account
    {
        [Key]
        public int AccountID { get; set; }

        [Required(ErrorMessage ="Please Enter Your Name")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Please Enter Your Surname")]
        public string Surname { get; set; }

        [Required(ErrorMessage ="Please Enter Your Email")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Please Enter Your Cell")]
        public string Cell { get; set; }
       
        [Required(ErrorMessage ="Please Select unit logo")]
        public string ProfileImg { get; set; }

        [Required(ErrorMessage ="Please Select Marital Status")]
        public string MaritalStatus { get; set; }

        [Required(ErrorMessage ="Please Upload Identity Doc")]
        public string IdentityDoc { get; set; }

        // [Required(ErrorMessage ="Please Select")]
        public string MarriageDoc { get; set; }

        public string FullAddress { get; set; }

        /* Relationship
           FKs         
        */
        [Required(ErrorMessage ="Please enter user id")]
        public string Id { get; set; }  
             
        /* Ref Nav Properties */      
        [ForeignKey("Id")]
        public virtual User User { get; set; }

        /* Ref. by */        
        public virtual ICollection<Address> Address { get; set; }
        public virtual ICollection<Application> Application { get; set; }

    }
}
