using SchoolApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

using SchoolApp.Models.Interfaces;


using System.Data.Odbc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace SchoolApp.Controllers
{   
    public class AppealStatusController : Controller
    {
        //Private Fields
        //--------------

        private IAppealStatus context;
        private IApplication app_ctx;
        private IAccount acc_ctx;
       
        private IConfiguration Configuration;

        public string strConn = @"Server=156.38.224.15;Database=UserDB2;MultipleActiveResultSets=true;User ID=xslicwih_ms_admin;password=#21MsDBUser@"; 
             
        //Constructor
        //-----------
        public AppealStatusController(IAppealStatus ctx, IAccount acc_context_, IApplication app_context_,
                                            IConfiguration configuration)
        {
            context = ctx;
            app_ctx = app_context_;
            acc_ctx = acc_context_;
            this.Configuration = configuration;
        }

        //READ
        // public ViewResult Index() => View(context.QuestionSubsections);
        public ViewResult Index()
        {
            AppealStatusViewModel vm = new AppealStatusViewModel
            {                
                AppealSelect = getAppeals(),
                StatusSelect = getStatuses(),   
                Applications = app_ctx.Applications,
                Accounts = acc_ctx.Accounts            
            };
           
            return View(vm);
        }

        //CREATE
        [HttpGet]
        public ViewResult Add() 
        {
            AppealStatusViewModel vm = new AppealStatusViewModel
            {                
                AppealSelect = getAppeals(),
                StatusSelect = getStatuses()             
            };
           
            return View(vm);
        }

        [HttpPost]
        public IActionResult Add(AppealStatusViewModel vm)
        {
            var AppealStatus = new AppealStatus
            {
                AppealID = vm.AppealID,
                StatusID = vm.StatusID
            };

            if(ModelState.IsValid)
            {
                context.SaveAppealStatus(AppealStatus);
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
        
        //UPDATE
        public ViewResult Edit(int AppealStatusID) 
        {
            AppealStatusViewModel vm = new AppealStatusViewModel
            {                
                AppealSelect = getAppeals(),
                StatusSelect = getStatuses()  
            };           
          
            AppealStatus AppealStatus = context.AppealStatuses
                .FirstOrDefault(c => c.AppealStatusID == AppealStatusID);                          
           
            vm.AppealID = AppealStatus.AppealID;
            vm.StatusID = AppealStatus.StatusID;
          
            return View(vm);        
        }
                 

        [HttpPost]
        public IActionResult Edit(AppealStatusViewModel vm)
        {
            AppealStatus AppealStatus = context.AppealStatuses
                .FirstOrDefault(c => c.AppealStatusID == vm.AppealStatusID);
           
            if(AppealStatus != default(AppealStatus))
            {
                 AppealStatus.AppealID =  vm.AppealID;
                 AppealStatus.StatusID = vm.StatusID;
            }
                            

            if(ModelState.IsValid)
            {
                context.SaveAppealStatus(AppealStatus);
                return RedirectToAction("Index");
            }
            else
            {
                return View(AppealStatus);
            }
        }

        //DELETE
        public IActionResult Delete(int AppealStatusID)
        {
            AppealStatus AppealStatus = context.DeleteAppealStatus(AppealStatusID);

            return RedirectToAction("Index");
        }       
      

        //D R O P - D O W N S
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

        public Microsoft.AspNetCore.Mvc.Rendering.SelectList getAppeals()
        {
            string c = Configuration.GetValue<string>("Data:UserDB2:ConnectionString");
            List<Appeal> models = new List<Appeal>();
                       
            using(SqlConnection connection = new SqlConnection(c)) 
            {
                using(SqlCommand cmd = new SqlCommand("", connection))
                {
                    connection.Open();
                    cmd.CommandText = "Select AppealID, ApplicationID from Appeal";
                    using(var reader = cmd.ExecuteReader())
                    {
                        if(reader.HasRows)
                        {
                            while(reader.Read())
                            {
                                var m = new Appeal();
                                m.AppealID = reader.GetInt32(reader.GetOrdinal("AppealID"));
                                m.ApplicationID = reader.GetInt32(reader.GetOrdinal("ApplicationID"));
                                models.Add(m);
                            }
                        }
                    }
                }
            };

            Microsoft.AspNetCore.Mvc.Rendering.SelectList ApepalsSelect = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(models, "AppealID", "ApplicationID");
            return ApepalsSelect;
        }

        
    }
}
