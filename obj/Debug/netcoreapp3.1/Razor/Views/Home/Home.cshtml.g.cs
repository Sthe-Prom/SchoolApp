#pragma checksum "C:\Users\MalindisaS\OneDrive - University of the Free State\Documents\Projects\SchoolApp\Views\Home\Home.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5c2b924cbf052b2000cfc93ae1471b88c4a1f47"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Home), @"mvc.1.0.view", @"/Views/Home/Home.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5c2b924cbf052b2000cfc93ae1471b88c4a1f47", @"/Views/Home/Home.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9520f81dd16b66461c441b36b061fdc0c9bcca4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Home : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/background.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Kids"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\MalindisaS\OneDrive - University of the Free State\Documents\Projects\SchoolApp\Views\Home\Home.cshtml"
  
    ViewData["Title"] = "Home";
    Layout = "_HomeLayout";

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
    <div class=""row align-items-top"">
        <div class=""col-lg-12"">
                <!-- Card with an image overlay -->
                <div class=""card"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c5c2b924cbf052b2000cfc93ae1471b88c4a1f475880", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
                    

                        <div class=""row"">
                            <div class=""col-md-6 col-lg-6"">
                                <div class=""card"">
                                    <div class=""card-body"" style=""padding: 10px; maring: 10px; background-color: #fafafa;"">
                                        <h1 class=""card-title"">School Applications Online</h1>
                                        School Applications Online
                                    </div>
                                </div>
               ");
            WriteLiteral(@"             </div>
                            <div class=""col-md-6 col-lg-6"">
                                <div class=""card"">
                                    <div class=""card-body"" style=""padding: 10px; maring: 10px; background-color: #fafafa;"">
                                        <h1 class=""card-title"">Find Your Child the Best School</h1>
                                        Find Your Child the Best School
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>

                </div><!-- End Card with an image overlay -->
                <div class=""card"">
                    <div class=""card-body"" style=""padding: 10px; maring: 10px; background-color: #fafafa;"">
                    <h5 class=""card-title"">Applications and Appeal dates</h5>
                        <br />
                        <h6>Please see downloadable booklet for year-to-year opening and c");
            WriteLiteral("losing dates for applications and appeals.</h6>\r\n                    </div>\r\n                </div>\r\n        </div>\r\n    </div> \r\n   \r\n</section>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
