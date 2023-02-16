using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolApp.Models
{    
    public class Status
    {
        [Key]
        public int StatusID { get; set; }

        [Required(ErrorMessage ="Please Enter Status Name")]
        public string StatusName { get; set; }

        /* Relationship
           FKs         
        */
                    
        /* Ref Nav Properties */      
       
        /* Ref. by */                
        public virtual ICollection<Application> Application { get; set; }
        // public virtual ICollection<AppealStatus> AppealStatus { get; set; }
        // public virtual ICollection<Appeal> Appeal { get; set; }

    }
}
