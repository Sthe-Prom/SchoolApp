using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SchoolApp.Models;
using SchoolApp.Models.Interfaces;

namespace SchoolApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IApplication ctx_app;
        private ISchool ctx_school;
        private IStatus ctx_status;
        private IAccount ctx_acc;
        private IAppeal ctx_appeal;
        private IAppealReason ctx_appReason;
        //private IAppeal ctx_appeal;


        public HomeController(ILogger<HomeController> logger, IApplication ctx_app_, IAppeal ctx_appeal_,
                            ISchool ctx_school_, IStatus ctx_status_, IAccount ctx_acc_, IAppealReason ctx_appReason_)
        {
            _logger = logger;
            ctx_app = ctx_app_;
            ctx_appeal = ctx_appeal_;
            ctx_school = ctx_school_;
            ctx_status = ctx_status_;
            ctx_acc = ctx_acc_;     
            ctx_appeal = ctx_appeal_;   
            ctx_appReason = ctx_appReason_;
        }            

        public IActionResult Index() 
        {
            AppealsViewModel vm = new AppealsViewModel();
            vm.Applications = ctx_app.Applications;
            vm.Appeals = ctx_appeal.Appeals;
            vm.Schools = ctx_school.Schools;
            vm.Statuses = ctx_status.Statuses;
            vm.Accounts = ctx_acc.Accounts;
            vm.Appeals = ctx_appeal.Appeals;
            vm.AppealReasons = ctx_appReason.AppealReasons;

            return View(vm);
        }

        public IActionResult Home() => View();

        public IActionResult Privacy() => View();

        public IActionResult Contact() => View();

        public IActionResult About() => View();

        public IActionResult FAQs() => View();


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
