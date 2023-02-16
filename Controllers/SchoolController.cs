using SchoolApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

using SchoolApp.Models.Interfaces;
using SchoolApp.Models;

using Microsoft.Extensions.Configuration;
using Microsoft.Data.SqlClient;

namespace SchoolApp.Controllers
{
   
    public class SchoolController : Controller
    {
        //Private Fields
        //--------------

        private ISchool context;
        private IApplication ctx_context;
        public IConfiguration Configuration;
        
        //Constructor
        //-----------
        public SchoolController(IApplication ctx, ISchool ctx_context_, IConfiguration configuration)
        {
            ctx_context = ctx;
            context = ctx_context_;
            Configuration = configuration;
        }
        
        public IActionResult Index()
        {
            SchoolViewModel vm = new SchoolViewModel();          
            vm.Applications = ctx_context.Applications;
            vm.Schools = context.Schools;

            return View(vm);
        }
              
         //CREATE
        [HttpGet]
        public ViewResult Add() 
        {
            SchoolViewModel vm = new SchoolViewModel();
            vm.Users = getUsers();

            return View(vm);

        }

        [HttpPost]
        public IActionResult Add(SchoolViewModel vm)
        {          


            var School = new School
            {
                SchoolName = vm.School.SchoolName,
                SchoolContact = vm.School.SchoolContact,
                SchoolClerk= vm.School.SchoolClerk,             
                City = vm.School.City,
                StreetNumber = vm.School.StreetNumber,
                StreetName = vm.School.StreetName,
                Suburb = vm.School.Suburb,   
                Zip = vm.School.Zip,
                Id = vm.School.Id                     
            };
          
            if(ModelState.IsValid)
            {
                context.SaveSchool(School);
                return RedirectToAction("Index");
            }
            else
            {
                return View(vm);
            }
        }
                              
        //DELETE
        public IActionResult Delete(int SchoolID)
        {
            School School = context.DeleteSchool(SchoolID);
            return RedirectToAction("Index");
        }       

         public Microsoft.AspNetCore.Mvc.Rendering.SelectList getUsers()
        {
            string c = Configuration.GetValue<string>("Data:UserDB2:ConnectionString");

            List<User> models = new List<User>();
                       
            using(SqlConnection connection = new SqlConnection(c)) 
            {
                using(SqlCommand cmd = new SqlCommand("", connection))
                {
                    connection.Open();
                    cmd.CommandText = "Select Id, Email from [User]";
                    using(var reader = cmd.ExecuteReader())
                    {
                        if(reader.HasRows)
                        {
                            while(reader.Read())
                            {
                                var m = new User();
                                m.Id = reader.GetString(reader.GetOrdinal("Id"));
                                m.Email = reader.GetString(reader.GetOrdinal("Email"));
                                models.Add(m);
                            }
                        }
                    }
                }
            };

            Microsoft.AspNetCore.Mvc.Rendering.SelectList userSelect = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(models, "Id", "Email");
            return userSelect;
        }
        
         
    }
}
