using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolApp.Models
{    
    public class AppealReason
    {
        [Key]
        public int AppealReasonID { get; set; }

        [Required(ErrorMessage ="Please Enter Appeal Reason")]
        public string AppealReasonName { get; set; }

        /* Relationship
           FKs         
        */       
             
        /* Ref Nav Properties */      
       
        /* Ref. by */                
        public virtual ICollection<Appeal> Appeal { get; set; }

    }
}
