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
    
    public class AppealViewModel: BaseViewModel
    {       
        public Microsoft.AspNetCore.Mvc.Rendering.SelectList AppealReasons {get;set;}       
        public Microsoft.AspNetCore.Mvc.Rendering.SelectList Applications {get;set;} 
        public Microsoft.AspNetCore.Mvc.Rendering.SelectList Statuses {get;set;} 
        public IEnumerable<Status> AppealStatuses {get;set;}          

        public int AppealID {get; set;}

        [Required(ErrorMessage ="Please Select Appeal Reason")]
        public int AppealReasonID { get; set; }

        [Required(ErrorMessage ="Please Select Application")]
        public int ApplicationID { get; set; }

        [Required(ErrorMessage ="Please Enter Date")]
        public DateTime AppealDate { get; set; }

        public int? StatusID { get; set; }   
           
    }
}