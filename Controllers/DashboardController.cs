using SchoolApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

using SchoolApp.Models.Interfaces;
using SchoolApp.Models;

using Microsoft.Data.SqlClient;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

using Microsoft.Extensions.Configuration;

namespace SchoolApp.Controllers
{
   
    public class DashboardController : Controller
    {
        //Private Fields
        //--------------

        private IAppeal context;
        private IStatus ctx_status;
        private IApplication ctx_app;
        private IAccount ctx_acc;
        private IAppealReason ctx_apealReason;
        private IConfiguration Configuration;
        
        //Constructor
        //-----------
        public DashboardController(IAppeal ctx, IConfiguration configuration, IStatus ctx_status_,
                                IApplication ctx_app_, IAccount ctx_acc_, IAppealReason ctx_apealReason_)
        {
            context = ctx;
            Configuration = configuration;
            ctx_status = ctx_status_;
            ctx_app = ctx_app_;
            ctx_acc = ctx_acc_;
            ctx_apealReason = ctx_apealReason_;
        }

        //READ
        public ViewResult Index() 
        {
            AppealsViewModel vm = new AppealsViewModel();
            vm.Appeals = context.Appeals;
            vm.Applications = ctx_app.Applications;
            vm.Accounts = ctx_acc.Accounts;
            vm.Statuses = ctx_status.Statuses;
            vm.AppealReasons = ctx_apealReason.AppealReasons;

            return View(vm);
        }

        public ViewResult Status() 
        {
            AppealsViewModel vm = new AppealsViewModel();
            vm.Appeals = context.Appeals;
            vm.Applications = ctx_app.Applications;
            vm.Accounts = ctx_acc.Accounts;
            vm.Statuses = ctx_status.Statuses;
            vm.AppealReasons = ctx_apealReason.AppealReasons;

            return View(vm);
        }

     
        
    

    }
}

