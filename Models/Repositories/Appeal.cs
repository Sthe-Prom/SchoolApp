using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolApp.Models
{    
    
    public class Appeal
    {
        [Key]
        public int AppealID { get; set; }

        [Required]
        public DateTime AppealDate { get; set; }

        /* Relationship
           FKs         
        */

        [Required(ErrorMessage ="Please enter Appeal Reason")]
        public int AppealReasonID { get; set; }  

        [Required(ErrorMessage ="Please Select Application for Appeal")]
        public int ApplicationID { get; set; } 
        
        public int? StatusID { get; set; }  
             
        /* Ref Nav Properties */      
        [ForeignKey("ApplicationID")]
        public virtual Application Application { get; set; }

        [ForeignKey("AppealReasonID")]
        public virtual AppealReason AppealReason { get; set; }

        // [ForeignKey("StatusID")]
        // public virtual Status? Status { get; set; }

        /* Ref. by */        
        public virtual ICollection<AppealStatus> AppealStatus { get; set; }
       

    }
}
