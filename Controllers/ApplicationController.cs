using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SchoolApp.Models;
using SchoolApp.Models.Interfaces;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Identity;

namespace SchoolApp.Controllers
{
    public class ApplicationController: Controller
    {
        private IApplication context;
        private IStatus ctx_context; 
        private IAccount ctx_account;     
        private ISchool ctx_school;    
        private readonly IWebHostEnvironment HostEnvironment;
         public IConfiguration Configuration;
         private SignInManager<User> signInManager;
        private UserManager<User> userManager;
        
        public ApplicationController(IApplication context_, IWebHostEnvironment he,
                             IStatus ctx_context_, IAccount ctx_account_, IConfiguration configuration,
                             SignInManager<User> signInManager_, UserManager<User> userManager_,  ISchool ctx_school_)
        {
            context = context_;
            HostEnvironment = he;
            ctx_context = ctx_context_;           
            ctx_account = ctx_account_;
            Configuration = configuration;
            signInManager = signInManager_;
            userManager = userManager_;
            ctx_school = ctx_school_;
        }

        public IActionResult Index() 
        {
            ApplicationsViewModel vm = new ApplicationsViewModel();
            vm.Applications = context.Applications;
            vm.Accounts = ctx_account.Accounts;
            vm.Statuses = ctx_context.Statuses;
            vm.Schools = ctx_school.Schools;

            return View(vm);
        }

        public IActionResult Status() 
        {
            ApplicationsViewModel vm = new ApplicationsViewModel();
            vm.Applications = context.Applications;
            vm.Accounts = ctx_account.Accounts;
            vm.Statuses = ctx_context.Statuses;
            vm.Schools = ctx_school.Schools;

            return View(vm);
        }

        [HttpGet]
        public IActionResult Application() 
        {     
            ApplicationViewModel vm = new ApplicationViewModel(); 
            vm.Statuses = ctx_context.Statuses;     
            vm.Accounts = ctx_account.Accounts;
            vm.SchoolList = getSchooList();
            vm.StatusList = getStatusList();
            return View(vm);
        }

        [HttpPost]
        public IActionResult Application(ApplicationViewModel vm) 
        {     
            string uploadedBC = UploadedBirthCert(vm);
            string UploadedSR = UploadedSchoolReport(vm);
            
            if(uploadedBC == null){
                uploadedBC = "Upload is null";
            } 

             if(UploadedSR == null){
                UploadedSR = "Upload is null";
            }  

            // int statusID = 0;
            // foreach (var item in ctx_context.Statuses)
            // {
            //     if(item.StatusName == "Applied"){
            //         statusID = item.StatusID;
            //     }
            // }

            string AppRef = vm.ApplicationDate.ToShortDateString().Substring(0, 4) + vm.Name.Substring(0, 2) + 
                                                    vm.Surname.Substring(0,2) + vm.Cell.Substring(4);

            int AccountID_ = 0;

            if((signInManager.IsSignedIn(User)))                                                
            {
                var userId = userManager.GetUserId(User);

                if(ctx_account.Accounts != null && ctx_account.Accounts.Count() != 0)
                {
                    foreach (var item in ctx_account.Accounts.Where(c => c.Id == userId))
                    {
                        AccountID_ = item.AccountID;
                    }
                }
            }

            var Application = new Application
            {
                Name = vm.Name,              
                Surname = vm.Surname,
                Gender = vm.Gender,
                Cell = vm.Cell,
                Disability = vm.Disability,
                IDNumber = vm.IDNumber,
                DOB = vm.DOB,
                BirthCertificate = uploadedBC,
                SchoolReport = UploadedSR,
                MedicalAid = vm.MedicalAid,
                ApplicationDate = System.DateTime.Now,
                ApplicationRef = vm.ApplicationRef,  
                AccountID = AccountID_,
                StatusID = vm.StatusID,
                SchoolID = vm.SchoolID,
                SchoolGrade = vm.SchoolGrade               
            };

            if(ModelState.IsValid)
            {
                context.SaveApplication(Application);
                return RedirectToAction("Index");
            }
            else
            {
                return View("Application");
            }
        }

         //UPDATE
        [HttpGet]
        public IActionResult Edit(int ApplicationID)
        {            
            ApplicationViewModel vm = new ApplicationViewModel();          
            vm.StatusList = getStatusList();     
            vm.Accounts = ctx_account.Accounts;
            vm.SchoolList = getSchooList();
            vm.Statuses = ctx_context.Statuses;  

            ApplicationViewModel vm2 = new ApplicationViewModel();

            string uploadedBC = UploadedBirthCert(vm2);
            string UploadedSR = UploadedSchoolReport(vm2);
            
            if(uploadedBC == null){
                uploadedBC = "Upload is null";
            } 

             if(UploadedSR == null){
                UploadedSR = "Upload is null";
            }  
                       
            Application Application = context.Applications.FirstOrDefault(c => c.ApplicationID == ApplicationID);
         
            vm.Name = Application.Name;             
            vm.Surname = Application.Surname;
            vm.Gender = Application.Gender;
            vm.Cell = Application.Cell;
            vm.Disability = Application.Disability;
            vm.IDNumber = Application.IDNumber;
            vm.DOB = Application.DOB;
            uploadedBC = Application.BirthCertificate;
            UploadedSR = Application.SchoolReport;
            vm.MedicalAid = Application.MedicalAid;
            vm.ApplicationDate = System.DateTime.Now;
            vm.ApplicationRef = Application.ApplicationRef;
            vm.AccountID = Application.AccountID;
            vm.StatusID = Application.StatusID;
            vm.SchoolID = Application.SchoolID;
            vm.SchoolGrade = Application.SchoolGrade;

            return View(vm);

        }      


        [HttpPost]
        public async Task<IActionResult> Edit(ApplicationViewModel vm)
        {                 
            string uploadedBC = UploadedBirthCert(vm);
            string uploadedSR = UploadedSchoolReport(vm);
            
             if(uploadedBC == null){
                uploadedBC = "Upload is null";
            } 

             if(uploadedSR == null){
                uploadedSR = "Upload is null";
            }  

            var Application = context.Applications.FirstOrDefault(c => c.ApplicationID == vm.ApplicationID);

            if(Application != default(Application))
            {
              
                Application.Name = vm.Name;             
                Application.Surname = vm.Surname;
                Application.Gender = vm.Gender;
                Application.Cell = vm.Cell;
                Application.Disability = vm.Disability;
                Application.IDNumber = vm.IDNumber;
                Application.DOB = vm.DOB;
                Application.BirthCertificate = uploadedBC;
                Application.SchoolReport = uploadedSR;
                Application.MedicalAid = vm.MedicalAid;
                Application.ApplicationDate = System.DateTime.Now;
                Application.ApplicationRef = vm.ApplicationRef;
                Application.AccountID = vm.AccountID;
                Application.StatusID = vm.StatusID;
                Application.SchoolID = vm.SchoolID;
                Application.SchoolGrade = vm.SchoolGrade;
                              
            }  

            try
            {
                if(ModelState.IsValid)
                {
                    context.SaveApplication(Application);
                    ViewData["Feedback"] = "Success";
                    return RedirectToAction("Index");
                }
                else
                {
                    return View("Edit");
                }
            }
            catch
            {
                return View(vm);
            }
        }


        //DELETE
        public IActionResult Delete(int ApplicationID)
        {
            Application Application = context.DeleteApplication(ApplicationID);         
            return RedirectToAction("Index");
        }       

        private string UploadedBirthCert(ApplicationViewModel model)
        {
            string uniqueFileName = null;

            if(model.BirthCertificate != null)
            {
                string uploadsFolder = Path.Combine( HostEnvironment.WebRootPath, "applicant/docs");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.BirthCertificate.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);

                using(var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.BirthCertificate.CopyTo(fileStream);
                }
            }

            return uniqueFileName;
        }

        private string UploadedSchoolReport(ApplicationViewModel model)
        {
            string uniqueFileName = null;

            if(model.SchoolReport != null)
            {
                string uploadsFolder = Path.Combine( HostEnvironment.WebRootPath, "applicant/docs");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.SchoolReport.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);

                using(var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.SchoolReport.CopyTo(fileStream);
                }
            }

            return uniqueFileName;
        }

        public Microsoft.AspNetCore.Mvc.Rendering.SelectList getSchooList()
        {
            string c = Configuration.GetValue<string>("Data:UserDB2:ConnectionString");

            List<School> models = new List<School>();
                       
            using(SqlConnection connection = new SqlConnection(c)) 
            {
                using(SqlCommand cmd = new SqlCommand("", connection))
                {
                    connection.Open();
                    cmd.CommandText = "Select SchoolName, SchoolID from [School]";
                    using(var reader = cmd.ExecuteReader())
                    {
                        if(reader.HasRows)
                        {
                            while(reader.Read())
                            {
                                var m = new School();
                                m.SchoolID = reader.GetInt32(reader.GetOrdinal("SchoolID"));
                                m.SchoolName = reader.GetString(reader.GetOrdinal("SchoolName"));
                                models.Add(m);
                            }
                        }
                    }
                }
            };

            Microsoft.AspNetCore.Mvc.Rendering.SelectList userSelect = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(models, "SchoolID", "SchoolName");
            return userSelect;
        }
       
        public Microsoft.AspNetCore.Mvc.Rendering.SelectList getStatusList()
        {
            string c = Configuration.GetValue<string>("Data:UserDB2:ConnectionString");

            List<Status> models = new List<Status>();
                       
            using(SqlConnection connection = new SqlConnection(c)) 
            {
                using(SqlCommand cmd = new SqlCommand("", connection))
                {
                    connection.Open();
                    cmd.CommandText = "Select StatusName, StatusID from Status";
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

            Microsoft.AspNetCore.Mvc.Rendering.SelectList userSelect = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(models, "StatusID", "StatusName");
            return userSelect;
        }


    }
}
