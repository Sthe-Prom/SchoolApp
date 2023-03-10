using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SchoolApp.Models;

// using SchoolApp.Models.Interfaces;
using System.ComponentModel;


namespace SchoolApp.Controllers
{   
    // [Authorize (Roles="Admins")]
    public class UserAccountController : Controller
    {
        //private properties
        private UserManager<User> UserManager;
        private SignInManager<User> signInManager;
     
        //Const
        public UserAccountController(UserManager<User> userManager_, SignInManager<User> signInManager_)
        {
            UserManager = userManager_;
            signInManager = signInManager_;          
        }

        //Action Methods      
        [AllowAnonymous]
        public IActionResult Login(string returnUrl)
        {
            return View(new LoginModel {ReturnUrl = returnUrl } );
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel loginModel, string ReturnUrl)
        {
            if(ModelState.IsValid)
            {
                User user = await UserManager.FindByEmailAsync(loginModel.Email);
                var userId = UserManager.GetUserId(User);
                User user_id = await UserManager.FindByIdAsync(userId);

                if(user != null)
                {
                    //await signInManager.SignOutAsync();

                    Microsoft.AspNetCore.Identity.SignInResult result = await signInManager.PasswordSignInAsync(user, loginModel.Password, false, false);

                    if(result.Succeeded)
                    {
                        // if(await UserManager.IsInRoleAsync(user_id,"Applicant"))
                        // {
                             return Redirect(ReturnUrl ?? "/Home/Index");
                        // }
                        // else
                        //     return Redirect(ReturnUrl ?? "/Address/Address");

                        // if(await UserManager.IsInRoleAsync(user_id,"Applicant"))
                        // {
                        //     return Redirect(ReturnUrl ?? "/Account/Profile");
                        // }
                    }
                    else
                        return Redirect(ReturnUrl ?? "/UserAccount/Login");


                        //var result = await SignInManager.PasswordSignInAsync(model.Username, model.Password, model.RememberMe, shouldLockout: false);
                        // switch (result)
                        // {
                        //     case Microsoft.AspNetCore.Identity.SignInStatus.Success: <= (NETCORE 6)
                        //         if(await UserManager.IsInRoleAsync(user.Id,"Admins")) //<= Checking Role and redirecting accordingly.
                        //             return RedirectToAction("Index", "Home");
                        //         else
                        //             return RedirectToAction("profie", "Account");                           
                        //     default:
                        //         ModelState.AddModelError("", "Invalid login attempt.");
                        //         return View(loginModel);
                        // }
                    
                }

                ModelState.AddModelError(nameof(LoginModel.Email), "Invalid username or password");
            }

            ModelState.AddModelError(nameof(LoginModel.Email), "Invalid username or password");
            return View(loginModel);

        }

        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Home", "Home");
        }

        [AllowAnonymous]
        public IActionResult AccessDenied()
        {
            return View();
        }

       

    }
}
