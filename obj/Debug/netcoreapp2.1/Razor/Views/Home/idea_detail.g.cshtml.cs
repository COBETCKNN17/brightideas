#pragma checksum "/Users/boldgoldman/Documents/Developer Files/Coding Dojo/C#/Bright Ideas/Views/Home/idea_detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "10f910823a00a19906d9ca47f868538ea6fc3cf6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_idea_detail), @"mvc.1.0.view", @"/Views/Home/idea_detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/idea_detail.cshtml", typeof(AspNetCore.Views_Home_idea_detail))]
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
#line 1 "/Users/boldgoldman/Documents/Developer Files/Coding Dojo/C#/Bright Ideas/Views/_ViewImports.cshtml"
using CBeltII;

#line default
#line hidden
#line 2 "/Users/boldgoldman/Documents/Developer Files/Coding Dojo/C#/Bright Ideas/Views/_ViewImports.cshtml"
using CBeltII.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10f910823a00a19906d9ca47f868538ea6fc3cf6", @"/Views/Home/idea_detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e1ce052e3d5c681ef57ce04182d80c52169b4e0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_idea_detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/boldgoldman/Documents/Developer Files/Coding Dojo/C#/Bright Ideas/Views/Home/idea_detail.cshtml"
  
ViewData["Title"] = "Bright Idea Detail";

#line default
#line hidden
            BeginContext(47, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(48, 912, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e1c6782f1b7a440a9065014f5ac80e11", async() => {
                BeginContext(54, 899, true);
                WriteLiteral(@"
    <title>Bright Ideas Idea Detail</title>
    <script src=""https://code.jquery.com/jquery-3.2.1.slim.min.js"" integrity=""sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN""
        crossorigin=""anonymous""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.11.0/umd/popper.min.js"" integrity=""sha384-b/U6ypiBEHpOf/4+1nzFpr53nxSS+GLCkfwBdFNTxtclqqenISfwAzpKaMNFNmj4""
        crossorigin=""anonymous""></script>
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-beta/css/bootstrap.min.css"" integrity=""sha384-/Y6pD6FV/Vv2HJnA6t+vslU6fwYXjCFtcEpHbNJ0lyAFsXTsjBbfaDjzALeQsN6M""
        crossorigin=""anonymous"">
    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-beta/js/bootstrap.min.js"" integrity=""sha384-h0AbiXch4ZDo7tp9hKZ4TsHbi047NrKGLO3SEJAg45jXxnGIfYzk4Si90RDIqNm1""
        crossorigin=""anonymous""></script>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(960, 2, true);
            WriteLiteral("\n\n");
            EndContext();
            BeginContext(962, 1960, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c34fb484bdd4417ba83958e6dbb8591", async() => {
                BeginContext(968, 685, true);
                WriteLiteral(@"
    <div class=""container"">
        <div class=""row"">
            <div class=""col-3 text-left"" style=""margin-left: 30px; margin-top: 10px;"">
               
            </div>
            <div class=""col-3 text-left"" style=""margin-left: 30px; margin-top: 10px;"">
            </div>
            <div class=""col-3 text-right"" style=""margin-top: 10px;"">
                <a href=""/bright_ideas"" style=""margin-right: 15px;"">Bright Ideas</a>
                <a href=""/Logout"">Logout</a>
            </div>
        </div>
        <div class=""row"">
            <table style=""margin-left: 50px; margin-bottom: 30px;"">
                <tr>
                    <td>
                        <p><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1653, "\"", 1699, 2);
                WriteAttributeValue("", 1660, "/users/", 1660, 7, true);
#line 34 "/Users/boldgoldman/Documents/Developer Files/Coding Dojo/C#/Bright Ideas/Views/Home/idea_detail.cshtml"
WriteAttributeValue("", 1667, ViewBag.currentPost.User.UserId, 1667, 32, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1700, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(1702, 34, false);
#line 34 "/Users/boldgoldman/Documents/Developer Files/Coding Dojo/C#/Bright Ideas/Views/Home/idea_detail.cshtml"
                                                                        Write(ViewBag.currentPost.User.FirstName);

#line default
#line hidden
                EndContext();
                BeginContext(1736, 200, true);
                WriteLiteral("</a> says:</p>\n                    </td>\n                    <td style=\"margin-left: 20px;\">\n                        <p style=\"margin-left: 20px; border: 1px solid black; padding: 5px; width: 400px;\">");
                EndContext();
                BeginContext(1937, 28, false);
#line 37 "/Users/boldgoldman/Documents/Developer Files/Coding Dojo/C#/Bright Ideas/Views/Home/idea_detail.cshtml"
                                                                                                      Write(ViewBag.currentPost.PostText);

#line default
#line hidden
                EndContext();
                BeginContext(1965, 573, true);
                WriteLiteral(@"</p>
                    </td>
    
                </tr>
            </table>
        </div>
  
        <div class=""row"">
            <p style=""margin-left: 50px;"">People who liked this post:</p>
            <table class=""table table-hover"" style=""text-align: left; width: 45%; margin-top: 25px; margin-left:-195px;"">
                <thead class=""thead-dark"">
                    <tr style=""background-color: silver;"">
                        <th scope=""col"">Alias</th>
                        <th scope=""col"">Name</th>
                    </tr>
                </thead>
");
                EndContext();
#line 53 "/Users/boldgoldman/Documents/Developer Files/Coding Dojo/C#/Bright Ideas/Views/Home/idea_detail.cshtml"
                  
                foreach (var like in ViewBag.LikedBy)
                {

#line default
#line hidden
                BeginContext(2629, 47, true);
                WriteLiteral("                <tr>\n                    <td><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2676, "\"", 2707, 2);
                WriteAttributeValue("", 2683, "/users/", 2683, 7, true);
#line 57 "/Users/boldgoldman/Documents/Developer Files/Coding Dojo/C#/Bright Ideas/Views/Home/idea_detail.cshtml"
WriteAttributeValue("", 2690, like.User.UserId, 2690, 17, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2708, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(2710, 19, false);
#line 57 "/Users/boldgoldman/Documents/Developer Files/Coding Dojo/C#/Bright Ideas/Views/Home/idea_detail.cshtml"
                                                      Write(like.User.FirstName);

#line default
#line hidden
                EndContext();
                BeginContext(2729, 34, true);
                WriteLiteral("</a></td>\n                    <td>");
                EndContext();
                BeginContext(2764, 19, false);
#line 58 "/Users/boldgoldman/Documents/Developer Files/Coding Dojo/C#/Bright Ideas/Views/Home/idea_detail.cshtml"
                   Write(like.User.FirstName);

#line default
#line hidden
                EndContext();
                BeginContext(2783, 2, true);
                WriteLiteral("  ");
                EndContext();
                BeginContext(2786, 18, false);
#line 58 "/Users/boldgoldman/Documents/Developer Files/Coding Dojo/C#/Bright Ideas/Views/Home/idea_detail.cshtml"
                                         Write(like.User.LastName);

#line default
#line hidden
                EndContext();
                BeginContext(2804, 28, true);
                WriteLiteral("</td>\n                </tr>\n");
                EndContext();
#line 60 "/Users/boldgoldman/Documents/Developer Files/Coding Dojo/C#/Bright Ideas/Views/Home/idea_detail.cshtml"
                }
                

#line default
#line hidden
                BeginContext(2868, 47, true);
                WriteLiteral("            </table>\n        </div>\n    </div>\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
