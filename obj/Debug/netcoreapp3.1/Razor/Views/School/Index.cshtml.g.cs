#pragma checksum "C:\Users\MalindisaS\OneDrive - University of the Free State\Documents\Projects\SchoolApp\Views\School\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19d6cb4d74f5d03f54cc61905040540e1eb07124"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_School_Index), @"mvc.1.0.view", @"/Views/School/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19d6cb4d74f5d03f54cc61905040540e1eb07124", @"/Views/School/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9520f81dd16b66461c441b36b061fdc0c9bcca4", @"/Views/_ViewImports.cshtml")]
    public class Views_School_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SchoolViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Home/Index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("frm1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\MalindisaS\OneDrive - University of the Free State\Documents\Projects\SchoolApp\Views\School\Index.cshtml"
  
    ViewData["Title"] = "Manage School";
    Layout = "_Layout";

    var userId = userManager.GetUserId(User);
    User user_id = await userManager.FindByIdAsync(userId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"pagetitle\">\r\n    <h1>Manage School</h1>\r\n    <nav>\r\n        <ol class=\"breadcrumb\">\r\n            <li class=\"breadcrumb-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "19d6cb4d74f5d03f54cc61905040540e1eb071246057", async() => {
                WriteLiteral("Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</li>
            <li class=""breadcrumb-item active"">Manage School</li>
        </ol>
    </nav>
</div>

<section>
     <div class=""col-lg-12"">

          <div class=""card"">
            <div class=""card-body"">
              <h5 class=""card-title"">Manage School</h5>

                <table class=""table"">
                    <thead>
                        <th>#</th>                        
                        <th>School Name</th>
                        <th>School Contact</th>
                        <th>School Clerk</th>
                        <th>School Address</th>
                        <th class=""text-info"">Action</th>
                    </thead>
                    <tbody>

");
#nullable restore
#line 42 "C:\Users\MalindisaS\OneDrive - University of the Free State\Documents\Projects\SchoolApp\Views\School\Index.cshtml"
                      
                        string UserID_ = "";

                        if((signInManager.IsSignedIn(User)))                                                
                        {
                            if(Model.Schools != null && Model.Schools.Count() != 0)
                            {
                                foreach (var item in Model.Schools.Where(c => c.Id == userId))
                                {
                                    UserID_ = item.Id;
                                }
                            }
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("               \r\n\r\n");
#nullable restore
#line 58 "C:\Users\MalindisaS\OneDrive - University of the Free State\Documents\Projects\SchoolApp\Views\School\Index.cshtml"
                     if( Model.Schools != null && Model.Schools.Count() != 0)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "C:\Users\MalindisaS\OneDrive - University of the Free State\Documents\Projects\SchoolApp\Views\School\Index.cshtml"
                         foreach (var item in Model.Schools)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 63 "C:\Users\MalindisaS\OneDrive - University of the Free State\Documents\Projects\SchoolApp\Views\School\Index.cshtml"
                               Write(item.SchoolID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 64 "C:\Users\MalindisaS\OneDrive - University of the Free State\Documents\Projects\SchoolApp\Views\School\Index.cshtml"
                               Write(item.SchoolName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 65 "C:\Users\MalindisaS\OneDrive - University of the Free State\Documents\Projects\SchoolApp\Views\School\Index.cshtml"
                               Write(item.SchoolContact);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 66 "C:\Users\MalindisaS\OneDrive - University of the Free State\Documents\Projects\SchoolApp\Views\School\Index.cshtml"
                               Write(item.SchoolClerk);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 67 "C:\Users\MalindisaS\OneDrive - University of the Free State\Documents\Projects\SchoolApp\Views\School\Index.cshtml"
                               Write(item.StreetNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 67 "C:\Users\MalindisaS\OneDrive - University of the Free State\Documents\Projects\SchoolApp\Views\School\Index.cshtml"
                                                  Write(item.StreetName);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 67 "C:\Users\MalindisaS\OneDrive - University of the Free State\Documents\Projects\SchoolApp\Views\School\Index.cshtml"
                                                                    Write(item.City);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>                                \r\n                                <td class=\"text-center\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "19d6cb4d74f5d03f54cc61905040540e1eb0712411807", async() => {
                WriteLiteral(@"
                                        <div class=""row"">
                                            <div class=""col-sm-12 col-md-12 col-lg-12"">
                                                
                                                <span class=""col-sm-4 col-md-4 col-lg-4"" style=""margin: 0 auto; float: none;"">
                                                    <input type=""hidden"" name=""SchoolID""");
                BeginWriteAttribute("value", " value=\"", 2998, "\"", 3020, 1);
#nullable restore
#line 74 "C:\Users\MalindisaS\OneDrive - University of the Free State\Documents\Projects\SchoolApp\Views\School\Index.cshtml"
WriteAttributeValue("", 3006, item.SchoolID, 3006, 14, false);

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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 87 "C:\Users\MalindisaS\OneDrive - University of the Free State\Documents\Projects\SchoolApp\Views\School\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 87 "C:\Users\MalindisaS\OneDrive - University of the Free State\Documents\Projects\SchoolApp\Views\School\Index.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n\r\n                </table>\r\n\r\n            </div>\r\n          </div>\r\n\r\n        </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SchoolViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
