#pragma checksum "C:\Users\MalindisaS\OneDrive - University of the Free State\Documents\Projects\SchoolApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cea4b2e0b957adf6082f4e5097850cb0884cb2ea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\MalindisaS\OneDrive - University of the Free State\Documents\Projects\SchoolApp\Views\_ViewImports.cshtml"
using SchoolApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\MalindisaS\OneDrive - University of the Free State\Documents\Projects\SchoolApp\Views\_ViewImports.cshtml"
using SchoolApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\MalindisaS\OneDrive - University of the Free State\Documents\Projects\SchoolApp\Views\_ViewImports.cshtml"
using SchoolApp.Models.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\MalindisaS\OneDrive - University of the Free State\Documents\Projects\SchoolApp\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\MalindisaS\OneDrive - University of the Free State\Documents\Projects\SchoolApp\Views\_ViewImports.cshtml"
using System.Web.Mvc;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cea4b2e0b957adf6082f4e5097850cb0884cb2ea", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9520f81dd16b66461c441b36b061fdc0c9bcca4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AppealsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("frm1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/background.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Kids"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\MalindisaS\OneDrive - University of the Free State\Documents\Projects\SchoolApp\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    Layout = "_Layout";

    var userId = userManager.GetUserId(User);
    User user_id = await userManager.FindByIdAsync(userId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""pagetitle text-center"">
    <h1>Welcome to School Online Applications</h1>
    <hr /><br />
</div>
<!-- End Page Title -->

<section class=""section dashboard"">

    <div class=""row"">
        <div class=""col-sm-10 text-center center-c"">
            <h3>Online Applications & Appeals</h3>
            <br />
            <h6>Make Your Child's next step a Priority, Apply online and reserve your child a space for the upcoming year.</h6>
            <hr />
        </div>
    </div>

");
#nullable restore
#line 30 "C:\Users\MalindisaS\OneDrive - University of the Free State\Documents\Projects\SchoolApp\Views\Home\Index.cshtml"
     if(signInManager.IsSignedIn(User))                                                
    {
        if(await userManager.IsInRoleAsync(user_id,"Admins"))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""row"">

                <!-- Left side columns -->
                <div class=""col-lg-center-c"">
                    <div class=""row"">

                        <!-- Applicant Card -->
                        <div class=""col-xxl-6 col-md-6 col-xl-6"">

                            <div class=""card info-card customers-card"">
                            
                                <div class=""card-body"">
                                    <h5 class=""card-title"">Applications <span>| This Year</span></h5>

                                    <div class=""d-flex align-items-center"">
                                        <div class=""card-icon rounded-circle d-flex align-items-center justify-content-center"">
                                            <i class=""bi bi-people""></i>
                                        </div>

");
#nullable restore
#line 53 "C:\Users\MalindisaS\OneDrive - University of the Free State\Documents\Projects\SchoolApp\Views\Home\Index.cshtml"
                                          
                                            int appCount = Model.Applications.Count();
                                            int appealCount = Model.Appeals.Count();
                                        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        <div class=\"ps-3\">\r\n                                            <h6>");
#nullable restore
#line 59 "C:\Users\MalindisaS\OneDrive - University of the Free State\Documents\Projects\SchoolApp\Views\Home\Index.cshtml"
                                           Write(appCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h6>
                                            
                                        </div>
                                    </div>

                                </div>
                            </div>

                        </div>
                        <!-- End Customers Card -->

                        <div class=""col-xxl-6 col-md-6 col-xl-6"">

                            <div class=""card info-card customers-card"">
                                
                                <div class=""card-body"">
                                    <h5 class=""card-title"">Appeals <span>| This Year</span></h5>

                                    <div class=""d-flex align-items-center"">
                                        <div class=""card-icon rounded-circle d-flex align-items-center justify-content-center"">
                                          
                                            <i class=""bi bi-file-arrow-up""></i>
                                        </div>
");
            WriteLiteral("                                        <div class=\"ps-3\">\r\n                                            <h6>");
#nullable restore
#line 83 "C:\Users\MalindisaS\OneDrive - University of the Free State\Documents\Projects\SchoolApp\Views\Home\Index.cshtml"
                                           Write(appealCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h6>
                                            

                                        </div>
                                    </div>

                                </div>
                            </div>

                        </div>
                        <!-- End Recent Activity -->

                        <!-- Reports -->
                        <div class=""col-12"">
                            <div class=""card"">

                                <div class=""filter"">
                                    <a class=""icon"" href=""#"" data-bs-toggle=""dropdown""><i class=""bi bi-three-dots""></i></a>
                                    <ul class=""dropdown-menu dropdown-menu-end dropdown-menu-arrow"">
                                        <li class=""dropdown-header text-start"">
                                            <h6>Filter</h6>
                                        </li>

                                        <li><a class=""dropdown-item"" href=""#"">Today</a></li>
     ");
            WriteLiteral(@"                                   <li><a class=""dropdown-item"" href=""#"">This Month</a></li>
                                        <li><a class=""dropdown-item"" href=""#"">This Year</a></li>
                                    </ul>
                                </div>

");
#nullable restore
#line 112 "C:\Users\MalindisaS\OneDrive - University of the Free State\Documents\Projects\SchoolApp\Views\Home\Index.cshtml"
                                   
                                    var Apps = from apps in Model.Applications                                                                      
                                                join status in Model.Statuses
                                                on apps.StatusID equals status.StatusID
                                                join acc in Model.Accounts
                                                on apps.AccountID equals acc.AccountID
                                                join school in Model.Schools
                                                on apps.SchoolID equals school.SchoolID

                                                select new {
                                                    apps.ApplicationID,
                                                    apps.Name,
                                                    apps.Surname,
                                                    apps.ApplicationDate,
                                                    apps.ApplicationRef,
                                                    apps.AccountID,    
                                                    apps.DOB,                          
                                                    status.StatusName,
                                                    school.SchoolName
                                                    
                                                };

                                    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                <div class=""card-body"">
                                    <h5 class=""card-title"">Applications <span>/Today</span></h5>

                                    <table class=""table"">
                                        <thead>
                                            <th>#</th>
                                            <th>Applicant</th>
                                            <th>Ref</th>
                                            <th>Date</th>
                                            <th>School</th>
                                            <th>Status</th>
                                        </thead>
                                        <tbody>
");
#nullable restore
#line 149 "C:\Users\MalindisaS\OneDrive - University of the Free State\Documents\Projects\SchoolApp\Views\Home\Index.cshtml"
                                             if( Model.Applications != null && Model.Applications.Count() != 0)
                                            {
                                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 151 "C:\Users\MalindisaS\OneDrive - University of the Free State\Documents\Projects\SchoolApp\Views\Home\Index.cshtml"
                                                 foreach (var item in Apps)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <tr>\r\n                                                        <td>");
#nullable restore
#line 154 "C:\Users\MalindisaS\OneDrive - University of the Free State\Documents\Projects\SchoolApp\Views\Home\Index.cshtml"
                                                       Write(item.ApplicationID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 155 "C:\Users\MalindisaS\OneDrive - University of the Free State\Documents\Projects\SchoolApp\Views\Home\Index.cshtml"
                                                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 155 "C:\Users\MalindisaS\OneDrive - University of the Free State\Documents\Projects\SchoolApp\Views\Home\Index.cshtml"
                                                                  Write(item.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 156 "C:\Users\MalindisaS\OneDrive - University of the Free State\Documents\Projects\SchoolApp\Views\Home\Index.cshtml"
                                                       Write(item.ApplicationRef);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 157 "C:\Users\MalindisaS\OneDrive - University of the Free State\Documents\Projects\SchoolApp\Views\Home\Index.cshtml"
                                                       Write(item.ApplicationDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 158 "C:\Users\MalindisaS\OneDrive - University of the Free State\Documents\Projects\SchoolApp\Views\Home\Index.cshtml"
                                                       Write(item.SchoolName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 159 "C:\Users\MalindisaS\OneDrive - University of the Free State\Documents\Projects\SchoolApp\Views\Home\Index.cshtml"
                                                       Write(item.StatusName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                                                    </tr>\r\n");
#nullable restore
#line 162 "C:\Users\MalindisaS\OneDrive - University of the Free State\Documents\Projects\SchoolApp\Views\Home\Index.cshtml"

                                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 163 "C:\Users\MalindisaS\OneDrive - University of the Free State\Documents\Projects\SchoolApp\Views\Home\Index.cshtml"
                                                 
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        </tbody>
                                    </table>

                                </div>

                            </div>
                        </div>
                        <!-- End Reports -->

");
            WriteLiteral(@"
                     

                    </div>
                </div>
                <!-- End Left side columns -->

                <!-- Right side columns -->
                <div class=""col-lg-12 center-c"">

                    
                   

                    <!-- News & Updates Traffic -->
                    <div class=""card"">
                        <div class=""filter"">
                            <a class=""icon"" href=""#"" data-bs-toggle=""dropdown""><i class=""bi bi-three-dots""></i></a>
                            <ul class=""dropdown-menu dropdown-menu-end dropdown-menu-arrow"">
                                <li class=""dropdown-header text-start"">
                                    <h6>Filter</h6>
                                </li>

                                <li><a class=""dropdown-item"" href=""#"">Today</a></li>
                                <li><a class=""dropdown-item"" href=""#"">This Month</a></li>
                                <li><a class=""dropdown-item");
            WriteLiteral(@""" href=""#"">This Year</a></li>
                            </ul>
                        </div>

                        <div class=""card-body pb-0"">
                            <h5 class=""card-title"">Appeals <span>| Today</span></h5>


                        </div>
                    </div>
                    <!-- Appeals chart -->

                    <div class=""card"">
                        <div class=""filter"">
                            <a class=""icon"" href=""#"" data-bs-toggle=""dropdown""><i class=""bi bi-three-dots""></i></a>
                            <ul class=""dropdown-menu dropdown-menu-end dropdown-menu-arrow"">
                                <li class=""dropdown-header text-start"">
                                    <h6>Filter</h6>
                                </li>

                                <li><a class=""dropdown-item"" href=""#"">Today</a></li>
                                <li><a class=""dropdown-item"" href=""#"">This Month</a></li>
                                <");
            WriteLiteral("li><a class=\"dropdown-item\" href=\"#\">This Year</a></li>\r\n                            </ul>\r\n                        </div>\r\n\r\n");
#nullable restore
#line 241 "C:\Users\MalindisaS\OneDrive - University of the Free State\Documents\Projects\SchoolApp\Views\Home\Index.cshtml"
                            

                        var appealApps = from appeals in Model.Appeals 
                                    join apps in Model.Applications
                                    on appeals.ApplicationID equals apps.ApplicationID
                                    join appReason in Model.AppealReasons
                                    on appeals.AppealReasonID equals appReason.AppealReasonID
                                    join status in Model.Statuses
                                    on appeals.StatusID equals status.StatusID
                                    select new {
                                        appeals.ApplicationID,
                                        appeals.AppealID,
                                        appeals.AppealDate,
                                        appeals.AppealReasonID,
                                        appeals.StatusID,
                                        apps.AccountID,
                                        apps.Name,
                                        appReason.AppealReasonName,
                                        status.StatusName

                                    };

                    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                        <div class=""card-body pb-0"">
                            <h5 class=""card-title"">Recent Appeals <span>| Today</span></h5>

                             <table class=""table"">
                                <thead>
                                    <th>#</th>                        
                                    <th>Applicant</th>
                                    <th>Appeal Date</th>
                                    <th>Appeal Reason</th>
                                    <th>Appeal Status</th>
                                    <th class=""text-info"">Action</th>
                                </thead>
                                <tbody>
");
#nullable restore
#line 279 "C:\Users\MalindisaS\OneDrive - University of the Free State\Documents\Projects\SchoolApp\Views\Home\Index.cshtml"
                                      if( Model.Appeals != null && Model.Appeals.Count() != 0)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 281 "C:\Users\MalindisaS\OneDrive - University of the Free State\Documents\Projects\SchoolApp\Views\Home\Index.cshtml"
                                     foreach (var item in appealApps)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n                                            <td>");
#nullable restore
#line 284 "C:\Users\MalindisaS\OneDrive - University of the Free State\Documents\Projects\SchoolApp\Views\Home\Index.cshtml"
                                           Write(item.AppealID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 285 "C:\Users\MalindisaS\OneDrive - University of the Free State\Documents\Projects\SchoolApp\Views\Home\Index.cshtml"
                                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 286 "C:\Users\MalindisaS\OneDrive - University of the Free State\Documents\Projects\SchoolApp\Views\Home\Index.cshtml"
                                           Write(item.AppealDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 287 "C:\Users\MalindisaS\OneDrive - University of the Free State\Documents\Projects\SchoolApp\Views\Home\Index.cshtml"
                                           Write(item.AppealReasonName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 288 "C:\Users\MalindisaS\OneDrive - University of the Free State\Documents\Projects\SchoolApp\Views\Home\Index.cshtml"
                                           Write(item.StatusName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td class=\"text-center\">\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cea4b2e0b957adf6082f4e5097850cb0884cb2ea26048", async() => {
                WriteLiteral(@"
                                                    <div class=""row"">
                                                        <div class=""col-sm-12 col-md-12 col-lg-12"">
                                                            
                                                            <span class=""col-sm-4 col-md-4 col-lg-4"" style=""margin: 0 auto; float: none;"">
                                                                <input type=""hidden"" name=""AppealID""");
                BeginWriteAttribute("value", " value=\"", 14612, "\"", 14634, 1);
#nullable restore
#line 295 "C:\Users\MalindisaS\OneDrive - University of the Free State\Documents\Projects\SchoolApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 14620, item.AppealID, 14620, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                                                                <button type=""submit"" class=""btn btn-sm""  >
                                                                    <i  class=""bi-trash"" style=""color: #A71930;"" aria-hidden=""true""></i>                                                                                                
                                                                </button>
                                                                
                                                            </span>
                                                        </div>
                                                    </div>
                                                    
                                                    
                                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            </td>\r\n                                        </tr>\r\n");
#nullable restore
#line 308 "C:\Users\MalindisaS\OneDrive - University of the Free State\Documents\Projects\SchoolApp\Views\Home\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 308 "C:\Users\MalindisaS\OneDrive - University of the Free State\Documents\Projects\SchoolApp\Views\Home\Index.cshtml"
                                     
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </tbody>

                </table>


                        </div>
                    </div>
                    <!-- Appeals Table -->

                </div>
                <!-- End Right side columns -->

            </div>
");
#nullable restore
#line 323 "C:\Users\MalindisaS\OneDrive - University of the Free State\Documents\Projects\SchoolApp\Views\Home\Index.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    \r\n");
#nullable restore
#line 326 "C:\Users\MalindisaS\OneDrive - University of the Free State\Documents\Projects\SchoolApp\Views\Home\Index.cshtml"
     if(signInManager.IsSignedIn(User))                                              
    {
        if(await userManager.IsInRoleAsync(user_id,"Applicant"))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""row"">
                <div class=""col-lg-12 center-c"">

                    <div class=""card"">
                        <div class=""card-body"" style=""background-image: url(~/img/kids1.jpg');"">
                            <h5 class=""card-title"">Applicant Home Page</h5>
                            <div class=""row"">
                                <div class=""col-lg-12"">
                                    
                                </div>

                            </div>
                        
                        </div>
                    
                    </div>
                </div>
            </div> 
           <div class=""row align-items-top"">
                <div class=""col-lg-12"">
                        <!-- Card with an image overlay -->
                        <div class=""card"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "cea4b2e0b957adf6082f4e5097850cb0884cb2ea31993", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                <div class=""card-img-overlay"">
                                <h5 class=""card-title"">We have connected private entities to be constant check of the selected school</h5>
                                <p class=""card-text"">For un-approved applications, you may contact district offices by making an 
                                    appeal for your application, your child will be located to the best school fitting the conditions of the appeal. </p>
                                </div>
                        </div><!-- End Card with an image overlay -->
                        <div class=""card"">
                            <div class=""card-body"">
                            <h5 class=""card-title"">Applications and Appeal dates</h5>
                            <br />
                            <h6>Please see downloadable booklet for year-to-year opening and closing dates for applications and appeals.</h6>
                            </div>
                      ");
            WriteLiteral("  </div>\r\n                </div>\r\n            </div>  \r\n");
#nullable restore
#line 368 "C:\Users\MalindisaS\OneDrive - University of the Free State\Documents\Projects\SchoolApp\Views\Home\Index.cshtml"

            
        }
    }      

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</section>\r\n\r\n\r\n\r\n\r\n \r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<User> userManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<User> signInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AppealsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
