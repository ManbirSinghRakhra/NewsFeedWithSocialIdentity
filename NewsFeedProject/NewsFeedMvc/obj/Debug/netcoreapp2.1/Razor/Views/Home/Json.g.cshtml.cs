#pragma checksum "C:\rproj\NewsFeed\NewsFeedProject\NewsFeedMvc\Views\Home\Json.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2bb23c001d083aace58a4dccd9ebdcde9a0a11dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Json), @"mvc.1.0.view", @"/Views/Home/Json.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Json.cshtml", typeof(AspNetCore.Views_Home_Json))]
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
#line 1 "C:\rproj\NewsFeed\NewsFeedProject\NewsFeedMvc\Views\_ViewImports.cshtml"
using NewsFeedMvc;

#line default
#line hidden
#line 2 "C:\rproj\NewsFeed\NewsFeedProject\NewsFeedMvc\Views\_ViewImports.cshtml"
using NewsFeedMvc.Models;

#line default
#line hidden
#line 1 "C:\rproj\NewsFeed\NewsFeedProject\NewsFeedMvc\Views\Home\Json.cshtml"
using Microsoft.AspNetCore.Authentication;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2bb23c001d083aace58a4dccd9ebdcde9a0a11dc", @"/Views/Home/Json.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62e3c5669d22932c735178270948a1fb2ec5f9f7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Json : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\rproj\NewsFeed\NewsFeedProject\NewsFeedMvc\Views\Home\Json.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(73, 29, true);
            WriteLiteral("\r\n<dt>access token</dt>\r\n<dd>");
            EndContext();
            BeginContext(103, 59, false);
#line 8 "C:\rproj\NewsFeed\NewsFeedProject\NewsFeedMvc\Views\Home\Json.cshtml"
Write(await ViewContext.HttpContext.GetTokenAsync("access_token"));

#line default
#line hidden
            EndContext();
            BeginContext(162, 37, true);
            WriteLiteral("</dd>\r\n\r\n<dt>refresh token</dt>\r\n<dd>");
            EndContext();
            BeginContext(200, 60, false);
#line 11 "C:\rproj\NewsFeed\NewsFeedProject\NewsFeedMvc\Views\Home\Json.cshtml"
Write(await ViewContext.HttpContext.GetTokenAsync("refresh_token"));

#line default
#line hidden
            EndContext();
            BeginContext(260, 5, true);
            WriteLiteral("</dd>");
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
