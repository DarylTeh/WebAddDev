#pragma checksum "D:\SP stuff\Web Development\kachoweded - Copy\Learner\TMS\Views\Home\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "159fb27bf067fcc35779ba77bfb9b1a6eeb2d140"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Login), @"mvc.1.0.view", @"/Views/Home/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Login.cshtml", typeof(AspNetCore.Views_Home_Login))]
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
#line 1 "D:\SP stuff\Web Development\kachoweded - Copy\Learner\TMS\Views\_ViewImports.cshtml"
using TMS;

#line default
#line hidden
#line 2 "D:\SP stuff\Web Development\kachoweded - Copy\Learner\TMS\Views\_ViewImports.cshtml"
using TMS.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"159fb27bf067fcc35779ba77bfb9b1a6eeb2d140", @"/Views/Home/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b920ee378507dd0789e3303ed664c79361ef06d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("dataForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 80, true);
            WriteLiteral("<p class=\"h1\">Login</p>\r\n<div class=\"row\">\r\n    <div class=\"col-md-8\">\r\n        ");
            EndContext();
            BeginContext(80, 1470, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bbf371c6305e4131984d5f6a01fe123b", async() => {
                BeginContext(164, 1079, true);
                WriteLiteral(@"
            <div class=""form-group row"">
                <label class=""col-md-2 col-form-label"" for=""usernameInput"">User name</label>
                <div class=""col-md-6"">
                    <input type=""email"" maxlength=""100"" id=""usernameInput"" name=""usernameInput"" class=""form-control ""
                           placeholder=""Email"" value=""JULIET@EMU.COM""  />
                </div>
            </div>
            <div class=""form-group row"">
                <label class=""col-md-2 col-form-label"" for=""passwordInput"">Password</label>
                <div class=""col-md-6"">
                    <input type=""text"" maxlength=""100"" id=""passwordInput"" name=""passwordInput"" class=""form-control ""
                           placeholder=""Password"" value=""p@ssw0rd"" />
                </div>
            </div>
            <div class=""form-group row"">
                <div class=""col-10 offset-2"">
                    
                    <input type=""submit"" class=""btn btn-primary"" value=""Login"" id=""loginB");
                WriteLiteral("utton\" />\r\n                </div>\r\n            </div>\r\n");
                EndContext();
#line 25 "D:\SP stuff\Web Development\kachoweded - Copy\Learner\TMS\Views\Home\Login.cshtml"
             if (ViewBag.Message != "")
            {

#line default
#line hidden
                BeginContext(1299, 153, true);
                WriteLiteral("             <div class=\"form-group row\">\r\n                <div class=\"col-md-6 offset-2\">\r\n                    <div class=\"alert-info\" id=\"messageBox\" >");
                EndContext();
                BeginContext(1453, 15, false);
#line 29 "D:\SP stuff\Web Development\kachoweded - Copy\Learner\TMS\Views\Home\Login.cshtml"
                                                        Write(ViewBag.Message);

#line default
#line hidden
                EndContext();
                BeginContext(1468, 52, true);
                WriteLiteral("</div>\r\n                </div>\r\n            </div>\r\n");
                EndContext();
#line 32 "D:\SP stuff\Web Development\kachoweded - Copy\Learner\TMS\Views\Home\Login.cshtml"
            }

#line default
#line hidden
                BeginContext(1535, 8, true);
                WriteLiteral("        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#line 4 "D:\SP stuff\Web Development\kachoweded - Copy\Learner\TMS\Views\Home\Login.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Antiforgery = true;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-antiforgery", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Antiforgery, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1550, 1161, true);
            WriteLiteral(@"
    </div>
    <div class=""col-md-4"">
        <div class=""card"" style=""width: 18rem;"">
            <div class=""card-body"">
                <h5 class=""card-title"">Login credentials for testing</h5>
                <h6 class=""card-subtitle mb-2 text-muted"">User credentials for testing purposes. All password is <span class=""text-danger"">p@ssword</span>.</h6>
                <p class=""card-text"">&nbsp;</p>
                <table>
                    <thead>
                        <tr><th>User name</th><th>Role</th></tr>
                    </thead>
                    <tbody>
                        <tr><td>JULIET@EMU.COM</td><td>ADMIN</td></tr>
                        <tr><td>KENNY@EMU.COM</td><td>ADMIN</td></tr>
                        <tr><td>LEEXIAOLONG@EMU.COM</td><td>INSTRUCTOR</td></tr>
                        <tr><td>KENNETH@EMU.COM</td><td>INSTRUCTOR</td></tr>
                        <tr><td>NANCY@EMU.COM</td><td>INSTRUCTOR</td></tr>
                        <tr><td>LARRY@EMU.COM</td><");
            WriteLiteral("td>INSTRUCTOR</td></tr>\r\n                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2730, 307, true);
                WriteLiteral(@"
 <script>
     $('#dataForm').validate({ // initialize the plugin
        rules: {
            usernameInput: {
                required: true,
                email: true
            },
            passwordInput: {
                required: true
            }
        }
    });
 </script>

");
                EndContext();
            }
            );
            BeginContext(3040, 2, true);
            WriteLiteral("\r\n");
            EndContext();
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
