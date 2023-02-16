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
   
    public class AppealController : Controller
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
        public AppealController(IAppeal ctx, IConfiguration configuration, IStatus ctx_status_,
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
       
        //UPDATE
        [HttpGet]
        public ViewResult Appeal()
        {
            AppealViewModel vm = new AppealViewModel();  
            vm.Applications = getApplications();
            vm.AppealReasons = getAppealReasons(); 
            vm.Statuses = getStatuses();   
            vm.AppealStatuses = ctx_status.Statuses;    
            return View(vm);
        }

           
        [HttpPost]
        public IActionResult Appeal(AppealViewModel vm)
        {          

            int statusID = 0;
            foreach (var item in ctx_status.Statuses)
            {
                if(item.StatusName == "Applied"){
                    statusID = item.StatusID;
                }
            }

            var Appeal = new Appeal
            {
                ApplicationID = vm.ApplicationID,              
                AppealReasonID = vm.AppealReasonID,
                AppealDate = vm.AppealDate,
                StatusID = statusID                        
            };
           
            if(ModelState.IsValid)
            {
                context.SaveAppeal(Appeal);
                return RedirectToAction("Index");
            }
            else
            {
                return View("Appeal");
            }
        }
        
        //UPDATE
        public ViewResult Edit(int AppealID)
        {
            AppealViewModel vm = new AppealViewModel();
            vm.Applications = getApplications();
            vm.AppealReasons = getAppealReasons();
            vm.Statuses  = getStatuses();
            vm.AppealStatuses = ctx_status.Statuses; 

            Appeal Appeal = context.Appeals.FirstOrDefault(c => c.AppealID == AppealID);
        
            vm.ApplicationID =  Appeal.ApplicationID;
            vm.AppealReasonID = Appeal.AppealReasonID;
            vm.AppealDate = Appeal.AppealDate;
            vm.StatusID =  Appeal.StatusID;            
                      
            return View(vm);  
        }     

        [HttpPost]
        public IActionResult Edit(AppealViewModel vm)
        {
            var Appeal = context.Appeals.FirstOrDefault(c => c.AppealID == vm.AppealID);             
            if(Appeal != default(Appeal))
            {
                Appeal.ApplicationID = vm.ApplicationID;
                Appeal.AppealReasonID = vm.AppealReasonID;
                Appeal.AppealDate = vm.AppealDate;
                Appeal.StatusID = vm.StatusID;                               
            }  

            try
            {
                if(ModelState.IsValid)
                {
                    context.SaveAppeal(Appeal);
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(vm);
                }
            }
            catch
            {
                return View(vm);
            
            }
        }

        //DELETE
        public IActionResult Delete(int AppealID)
        {
            Appeal Appeal = context.DeleteAppeal(AppealID);

            return RedirectToAction("Index");
        }               


        // DROP DOWNS
        // public Microsoft.AspNetCore.Mvc.Rendering.SelectList getApplications()
        // {
        //     string c = Configuration.GetValue<string>("Data:UserDB2:ConnectionString");

        //     List<Application> models = new List<Application>();
                       
        //     using(SqlConnection connection = new SqlConnection(c)) 
        //     {
        //         using(SqlCommand cmd = new SqlCommand("", connection))
        //         {
        //             connection.Open();
        //             cmd.CommandText = "Select ApplicationID, Name from Application";
        //             using(var reader = cmd.ExecuteReader())
        //             {
        //                 if(reader.HasRows)
        //                 {
        //                     while(reader.Read())
        //                     {
        //                         var m = new Application();
        //                         m.ApplicationID = reader.GetInt32(reader.GetOrdinal("ApplicationID"));
        //                         m.Name = reader.GetString(reader.GetOrdinal("Name"));
        //                         models.Add(m);
        //                     }
        //                 }
        //             }
        //         }
        //     };

        //     Microsoft.AspNetCore.Mvc.Rendering.SelectList userSelect = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(models, "ApplicationID", "Name");
        //     return userSelect;
        // }

        public Microsoft.AspNetCore.Mvc.Rendering.SelectList getAppealReasons()
        {
            string c = Configuration.GetValue<string>("Data:UserDB2:ConnectionString");

            List<AppealReason> models = new List<AppealReason>();
                       
            using(SqlConnection connection = new SqlConnection(c)) 
            {
                using(SqlCommand cmd = new SqlCommand("", connection))
                {
                    connection.Open();
                    cmd.CommandText = "Select AppealReasonID, AppealReasonName from AppealReason";
                    using(var reader = cmd.ExecuteReader())
                    {
                        if(reader.HasRows)
                        {
                            while(reader.Read())
                            {
                                var m = new AppealReason();
                                m.AppealReasonID = reader.GetInt32(reader.GetOrdinal("AppealReasonID"));
                                m.AppealReasonName = reader.GetString(reader.GetOrdinal("AppealReasonName"));
                                models.Add(m);
                            }
                        }
                    }
                }
            };

            Microsoft.AspNetCore.Mvc.Rendering.SelectList userSelect = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(models, "AppealReasonID", "AppealReasonName");
            return userSelect;
        }

        public Microsoft.AspNetCore.Mvc.Rendering.SelectList getStatuses()
        {
            string c = Configuration.GetValue<string>("Data:UserDB2:ConnectionString");

            List<Status> models = new List<Status>();
                       
            using(SqlConnection connection = new SqlConnection(c)) 
            {
                using(SqlCommand cmd = new SqlCommand("", connection))
                {
                    connection.Open();
                    cmd.CommandText = "Select StatusID, StatusName from Status";
                    using(var reader = cmd.ExecuteReader())
                    {
                        if(reader.HasRows)
                        {
                            while(reader.Read())
                            {
                                var m = new Status();
                                m.StatusID = reader.GetInt32(reader.GetOrdinal("StatusID"));
                                m.StatusName = reader.GetString(reader.GetOrdinal("StatusName"));
                                models.Add(m);
                            }
                        }
                    }
                }
            };

            Microsoft.AspNetCore.Mvc.Rendering.SelectList StatusSelect = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(models, "StatusID", "StatusName");
            return StatusSelect;
        }

        public Microsoft.AspNetCore.Mvc.Rendering.SelectList getApplications()
        {
            string c = Configuration.GetValue<string>("Data:UserDB2:ConnectionString");

            List<Application> models = new List<Application>();
                       
            using(SqlConnection connection = new SqlConnection(c)) 
            {
                using(SqlCommand cmd = new SqlCommand("", connection))
                {
                    connection.Open();
                    cmd.CommandText = "Select ApplicationID, [Name] from [Application]";
                    using(var reader = cmd.ExecuteReader())
                    {
                        if(reader.HasRows)
                        {
                            while(reader.Read())
                            {
                                var m = new Application();
                                m.ApplicationID = reader.GetInt32(reader.GetOrdinal("ApplicationID"));
                                m.Name = reader.GetString(reader.GetOrdinal("Name"));
                                models.Add(m);
                            }
                        }
                    }
                }
            };

            Microsoft.AspNetCore.Mvc.Rendering.SelectList ApplicationSelect = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(models, "ApplicationID", "Name");
            return ApplicationSelect;
        }

    }
}

