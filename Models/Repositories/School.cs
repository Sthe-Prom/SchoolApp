using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolApp.Models
{    
    public class School
    {
        [Key]
        public int SchoolID { get; set; }

        [Required(ErrorMessage ="Please Enter School Name")]
        public string SchoolName { get; set; }

        [Required(ErrorMessage ="Please Enter School Contact")]
        public string SchoolContact { get; set; }

        [Required(ErrorMessage ="Please Enter School Clerk")]
        public string SchoolClerk { get; set; }

        [Required(ErrorMessage ="Please Enter School Street Name")]
        public string StreetName { get; set; }

        [Required(ErrorMessage ="Please Enter School Street Number")]
        public string StreetNumber { get; set; }

        [Required(ErrorMessage ="Please Enter School City")]
        public string City { get; set; }

        [Required(ErrorMessage ="Please Enter School Suburb")]
        public string Suburb { get; set; }
       
        [Required(ErrorMessage ="Please Enter School Zip Code")]
        public string Zip { get; set; }
       
        /* Relationship
           FKs         
        */
        [Required(ErrorMessage ="Please login with your registered account")]
        public string Id {get; set;}
      
        /* Ref Nav Properties */
        [ForeignKey("Id")]
        public virtual User User { get; set; } 
 
        /* Ref. by */        
        public virtual ICollection<Application> Application { get; set; }

    }
}
