#pragma checksum "C:\Users\Жанат\source\repos\BookMart\BookMart\Views\User\SignedOut.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fea4bd2079f97d72b1428e751b7cde696ba4b055"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_SignedOut), @"mvc.1.0.view", @"/Views/User/SignedOut.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/SignedOut.cshtml", typeof(AspNetCore.Views_User_SignedOut))]
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
#line 1 "C:\Users\Жанат\source\repos\BookMart\BookMart\Views\_ViewImports.cshtml"
using BookMart;

#line default
#line hidden
#line 2 "C:\Users\Жанат\source\repos\BookMart\BookMart\Views\_ViewImports.cshtml"
using BookMart.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fea4bd2079f97d72b1428e751b7cde696ba4b055", @"/Views/User/SignedOut.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8bfd765d4eb817c42d2cc9425820b4ec3ed2d8c2", @"/Views/_ViewImports.cshtml")]
    public class Views_User_SignedOut : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Жанат\source\repos\BookMart\BookMart\Views\User\SignedOut.cshtml"
  
    ViewData["Title"] = "Signed out";

#line default
#line hidden
            BeginContext(46, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(53, 17, false);
#line 5 "C:\Users\Жанат\source\repos\BookMart\BookMart\Views\User\SignedOut.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(70, 55, true);
            WriteLiteral("</h2>\r\n<p>\r\n    You have successfully signed out.\r\n</p>");
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
