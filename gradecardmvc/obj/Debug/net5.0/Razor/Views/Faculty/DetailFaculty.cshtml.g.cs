#pragma checksum "C:\CsharpProject\gradecardmvc\Views\Faculty\DetailFaculty.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a29bf161b0b89299f6fd854b9de2c1499a7311be"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Faculty_DetailFaculty), @"mvc.1.0.view", @"/Views/Faculty/DetailFaculty.cshtml")]
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
#line 1 "C:\CsharpProject\gradecardmvc\Views\_ViewImports.cshtml"
using gradecardmvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\CsharpProject\gradecardmvc\Views\_ViewImports.cshtml"
using gradecardmvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a29bf161b0b89299f6fd854b9de2c1499a7311be", @"/Views/Faculty/DetailFaculty.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bcca33d59a2a45ce8258d3f3a9551df55ab5c8ce", @"/Views/_ViewImports.cshtml")]
    public class Views_Faculty_DetailFaculty : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<gradecardmvc.Models.TeacherTable>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "getAllFaculty", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\CsharpProject\gradecardmvc\Views\Faculty\DetailFaculty.cshtml"
  
    ViewData["Title"] = "DetailStudent";
    Layout = "./Layout.cshtml";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    h2{
        font-family: 'Times new roman';
        font-weight:bold;
        color: white;
    }
    body{
        background-image: url(""/image/background4.jpg"");
        background-repeat: no-repeat;
        background-attachment: fixed;
        background-size: cover;
    }
    a{
        color:white;
    }

</style>

<h2>Faculty Profile Detail</h2>

<div class=""container"">  
    <hr />
    
        <div class=""panel panel-info"">

            <div class=""panel-heading"">
                Information of Respected Faculty
             </div>

            <div class=""panel-body"">
                
                ");
#nullable restore
#line 40 "C:\CsharpProject\gradecardmvc\Views\Faculty\DetailFaculty.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral(" :  ");
#nullable restore
#line 40 "C:\CsharpProject\gradecardmvc\Views\Faculty\DetailFaculty.cshtml"
                                                      Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <br>\r\n                ");
#nullable restore
#line 42 "C:\CsharpProject\gradecardmvc\Views\Faculty\DetailFaculty.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral(" : ");
#nullable restore
#line 42 "C:\CsharpProject\gradecardmvc\Views\Faculty\DetailFaculty.cshtml"
                                                       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                \r\n          </div>\r\n          </div>\r\n    \r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a29bf161b0b89299f6fd854b9de2c1499a7311be5475", async() => {
                WriteLiteral("Go to Faculty List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<gradecardmvc.Models.TeacherTable> Html { get; private set; }
    }
}
#pragma warning restore 1591
