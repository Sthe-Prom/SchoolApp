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
   
    public class StatusController : Controller
    {
        //Private Fields
        //--------------

        private IStatus context;
        
        //Constructor
        //-----------
        public StatusController(IStatus ctx)
        {
            context = ctx;
        }

        //READ
        public ViewResult Index() => View(context.Statuses);
       
        //CREATE
        [HttpGet]
        public ViewResult Add() => View();

        [HttpPost]
        public IActionResult Add(Status Status)
        {
            if(ModelState.IsValid)
            {
                context.SaveStatus(Status);
                return RedirectToAction("Settings", "Settings");
            }
            else
            {
                return View();
            }
        }
        
        //UPDATE
        public ViewResult Edit(int StatusID) =>
            View(context.Statuses
                .FirstOrDefault(c => c.StatusID == StatusID));      

        [HttpPost]
        public IActionResult Edit(Status Status)
        {
            if(ModelState.IsValid)
            {
                context.SaveStatus(Status);
                return RedirectToAction("Settings", "Settings");
            }
            else
            {
                return View(Status);
            }
        }

        //DELETE
        public IActionResult Delete(int StatusID)
        {
            Status Status = context.DeleteStatus(StatusID);

            return RedirectToAction("Settings", "Settings");
        }       
        

        
    }
}
