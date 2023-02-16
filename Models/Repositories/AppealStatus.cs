using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace SchoolApp.Models
{    
    #nullable enable
    public class AppealStatus
    {
        [Key]
        public int AppealStatusID { get; set; }              

        /* Relationship
           FKs         
        */

        //[Required(ErrorMessage ="Please Select Appeal")]
        public int? AppealID { get; set; }

        //[Required(ErrorMessage ="Please Select Status")]
        public int? StatusID { get; set; }
     
        [ForeignKey("AppealID")]
        public virtual Appeal Appeal { get; set; }      
     
        [ForeignKey("StatusID")]
        public virtual Status Status { get; set; }
       
    }
}
