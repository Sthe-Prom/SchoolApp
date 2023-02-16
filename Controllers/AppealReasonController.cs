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
   
    public class AppealReasonController : Controller
    {
        //Private Fields
        //--------------

        private IAppealReason context;
        
        //Constructor
        //-----------
        public AppealReasonController(IAppealReason ctx)
        {
            context = ctx;
        }

        //READ
        public ViewResult Index() => View(context.AppealReasons);
       
        //CREATE
        [HttpGet]
        public ViewResult Add() => View();

        [HttpPost]
        public IActionResult Add(AppealReason AppealReason)
        {
            if(ModelState.IsValid)
            {
                context.SaveAppealReason(AppealReason);
                return RedirectToAction("Settings", "Settings");
            }
            else
            {
                return View();
            }
        }
        
        //UPDATE
        public ViewResult Edit(int AppealReasonID) =>
            View(context.AppealReasons
                .FirstOrDefault(c => c.AppealReasonID == AppealReasonID));      

        [HttpPost]
        public IActionResult Edit(AppealReason AppealReason)
        {
            if(ModelState.IsValid)
            {
                context.SaveAppealReason(AppealReason);
                return RedirectToAction("Settings", "Settings");
            }
            else
            {
                return View(AppealReason);
            }
        }

        //DELETE
        public IActionResult Delete(int AppealReasonID)
        {
            AppealReason AppealReason = context.DeleteAppealReason(AppealReasonID);
            return RedirectToAction("Settings", "Settings");
        }       
        

        
    }
}
