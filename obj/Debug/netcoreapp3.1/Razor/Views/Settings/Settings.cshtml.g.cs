#pragma checksum "C:\Users\MalindisaS\OneDrive - University of the Free State\Documents\Projects\SchoolApp\Views\Settings\Settings.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ef8dc972e3158820775a2163a8cce9e35e56946"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Settings_Settings), @"mvc.1.0.view", @"/Views/Settings/Settings.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ef8dc972e3158820775a2163a8cce9e35e56946", @"/Views/Settings/Settings.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9520f81dd16b66461c441b36b061fdc0c9bcca4", @"/Views/_ViewImports.cshtml")]
    public class Views_Settings_Settings : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SettingsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Home/Index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Status/Add"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/AppealReason/Add"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\MalindisaS\OneDrive - University of the Free State\Documents\Projects\SchoolApp\Views\Settings\Settings.cshtml"
  
    ViewData["Title"] = "Settings";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"pagetitle\">\r\n    <h1>Manage Admin Settings</h1>\r\n    <nav>\r\n        <ol class=\"breadcrumb\">\r\n            <li class=\"breadcrumb-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4ef8dc972e3158820775a2163a8cce9e35e569467790", async() => {
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
            <li class=""breadcrumb-item active"">Settings</li>
        </ol>
    </nav>
</div>

<section>
    
      <div class=""row"">
        <div class=""col-lg-6"">

          <div class=""card"">
            <div class=""card-body"">
              <h5 class=""card-title"">Manage Application Statuses</h5>
                   <div class=""form-group text-right"">
                      <span>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4ef8dc972e3158820775a2163a8cce9e35e569469278", async() => {
                WriteLiteral("Add New Application Status");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</span>                                                             
                      <hr />
                  </div>
                  <table class=""table table-striped table-responsive-lg table-bordered table-sm grid_print"">
                      <tr>                                                          
                          <th class=""text-center"">#</th> 
                          <th class=""text-center"">Status Name</th>                                   
                          <th class=""text-center text-info h5"">Action</th>      
                          
                      </tr>
                  
");
#nullable restore
#line 38 "C:\Users\MalindisaS\OneDrive - University of the Free State\Documents\Projects\SchoolApp\Views\Settings\Settings.cshtml"
                           foreach (var item in Model.Statuses)
                          {

#line default
#line hidden
#nullable disable
            WriteLiteral("                              <tr>                                                        \r\n                                  <td class=\"text-left\">");
#nullable restore
#line 41 "C:\Users\MalindisaS\OneDrive - University of the Free State\Documents\Projects\SchoolApp\Views\Settings\Settings.cshtml"
                                                   Write(item.StatusID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                  <td class=\"text-left\">");
#nullable restore
#line 42 "C:\Users\MalindisaS\OneDrive - University of the Free State\Documents\Projects\SchoolApp\Views\Settings\Settings.cshtml"
                                                   Write(item.StatusName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                  <td class=\"text-center\">\r\n                                   \r\n                                       ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4ef8dc972e3158820775a2163a8cce9e35e5694612414", async() => {
                WriteLiteral("\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4ef8dc972e3158820775a2163a8cce9e35e5694612717", async() => {
                    WriteLiteral("\r\n                                                    <i class=\"bi-pencil\" style=\"color: #00675A;\"></i>&nbsp;\r\n                                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-StatusID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 48 "C:\Users\MalindisaS\OneDrive - University of the Free State\Documents\Projects\SchoolApp\Views\Settings\Settings.cshtml"
                                                        WriteLiteral(item.StatusID);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["StatusID"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-StatusID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["StatusID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(" \r\n                                            <a type=\"submit\"");
                BeginWriteAttribute("class", "\r\n                                                    class=\"", 2369, "\"", 2430, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                                <i class=\"bi-trash-fill\" style=\"color: #A71930;\" aria-hidden=\"true\"></i>\r\n                                            </a>\r\n                                            <input type=\"hidden\" name=\"StatusID\"");
                BeginWriteAttribute("value", " value=\"", 2686, "\"", 2708, 1);
#nullable restore
#line 55 "C:\Users\MalindisaS\OneDrive - University of the Free State\Documents\Projects\SchoolApp\Views\Settings\Settings.cshtml"
WriteAttributeValue("", 2694, item.StatusID, 2694, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                  </td>\r\n                              </tr>\r\n");
#nullable restore
#line 60 "C:\Users\MalindisaS\OneDrive - University of the Free State\Documents\Projects\SchoolApp\Views\Settings\Settings.cshtml"
                          }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                  </table>


            </div>
          </div>

        </div>

        <div class=""col-lg-6"">

          <div class=""card"">
            <div class=""card-body"">
              <h5 class=""card-title"">Manage Appeal Reasons</h5>
                  <div class=""form-group text-right"">
                      <span>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4ef8dc972e3158820775a2163a8cce9e35e5694618456", async() => {
                WriteLiteral("Add New Appeal Reason");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</span>                                                             
                      <hr />
                  </div>
                  <table class=""table table-striped table-responsive-lg table-bordered table-sm grid_print"">
                      <tr>                                                          
                          <th class=""text-center"">#</th> 
                          <th class=""text-center"">Appeal Reason</th>                                   
                          <th class=""text-center text-info h5"">Action</th>      
                          
                      </tr>
                  
");
#nullable restore
#line 86 "C:\Users\MalindisaS\OneDrive - University of the Free State\Documents\Projects\SchoolApp\Views\Settings\Settings.cshtml"
                           foreach (var item in Model.AppealReasons)
                          {

#line default
#line hidden
#nullable disable
            WriteLiteral("                              <tr>                                                        \r\n                                  <td class=\"text-left\">");
#nullable restore
#line 89 "C:\Users\MalindisaS\OneDrive - University of the Free State\Documents\Projects\SchoolApp\Views\Settings\Settings.cshtml"
                                                   Write(item.AppealReasonID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                  <td class=\"text-left\">");
#nullable restore
#line 90 "C:\Users\MalindisaS\OneDrive - University of the Free State\Documents\Projects\SchoolApp\Views\Settings\Settings.cshtml"
                                                   Write(item.AppealReasonName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                  <td class=\"text-center\">\r\n                                     \r\n                                       ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4ef8dc972e3158820775a2163a8cce9e35e5694621609", async() => {
                WriteLiteral("\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4ef8dc972e3158820775a2163a8cce9e35e5694621912", async() => {
                    WriteLiteral("\r\n                                                    <i class=\"bi-pencil\" style=\"color: #00675A;\"></i>&nbsp;\r\n                                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-AppealReasonID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 96 "C:\Users\MalindisaS\OneDrive - University of the Free State\Documents\Projects\SchoolApp\Views\Settings\Settings.cshtml"
                                                              WriteLiteral(item.AppealReasonID);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["AppealReasonID"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-AppealReasonID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["AppealReasonID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(" \r\n                                            <a type=\"submit\"");
                BeginWriteAttribute("class", "\r\n                                                    class=\"", 4935, "\"", 4996, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                                <i class=""bi-trash-fill"" style=""color: #A71930;"" aria-hidden=""true""></i>
                                            </a>
                                            <input type=""hidden"" name=""QuestionSubsectionID""");
                BeginWriteAttribute("value", " value=\"", 5264, "\"", 5292, 1);
#nullable restore
#line 103 "C:\Users\MalindisaS\OneDrive - University of the Free State\Documents\Projects\SchoolApp\Views\Settings\Settings.cshtml"
WriteAttributeValue("", 5272, item.AppealReasonID, 5272, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\r\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </td>\r\n                              </tr>\r\n");
#nullable restore
#line 108 "C:\Users\MalindisaS\OneDrive - University of the Free State\Documents\Projects\SchoolApp\Views\Settings\Settings.cshtml"
                          }

#line default
#line hidden
#nullable disable
            WriteLiteral("                  </table>\r\n            </div>\r\n          </div>\r\n\r\n        </div>\r\n      </div>\r\n        \r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SettingsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
