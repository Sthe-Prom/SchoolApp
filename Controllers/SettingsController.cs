using SchoolApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

using SchoolApp.Models.Interfaces;
using SchoolApp.Models;

namespace SchoolApp.Controllers
{
   
    public class SettingsController : Controller
    {
        //Private Fields
        //--------------

        private IAppealReason ctx_appealReason;
        private IStatus ctx_status;
        
        //Constructor
        //-----------
        public SettingsController(IAppealReason ctx_appealReason_, IStatus ctx_status_)
        {
           ctx_appealReason = ctx_appealReason_;
           ctx_status = ctx_status_;
        }

        //READ
        public IActionResult Settings()
        {
            SettingsViewModel vm = new SettingsViewModel();
            vm.AppealReasons = ctx_appealReason.AppealReasons;
            vm.Statuses = ctx_status.Statuses;   

            return View(vm);         
        }            
        
    }
}

