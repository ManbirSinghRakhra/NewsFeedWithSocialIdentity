#pragma checksum "C:\rproj\NewsFeed\NewsFeedProject\NewsFeedMvc\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8071a7b7e71254197ce0df29a0cb70364db66694"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/About.cshtml", typeof(AspNetCore.Views_Home_About))]
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
#line 3 "C:\rproj\NewsFeed\NewsFeedProject\NewsFeedMvc\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Authentication;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8071a7b7e71254197ce0df29a0cb70364db66694", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62e3c5669d22932c735178270948a1fb2ec5f9f7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\rproj\NewsFeed\NewsFeedProject\NewsFeedMvc\Views\Home\About.cshtml"
  
    ViewData["Title"] = "About";

#line default
#line hidden
            BeginContext(41, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(46, 17, false);
#line 4 "C:\rproj\NewsFeed\NewsFeedProject\NewsFeedMvc\Views\Home\About.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(63, 11, true);
            WriteLiteral("</h2>\r\n<h3>");
            EndContext();
            BeginContext(75, 19, false);
#line 5 "C:\rproj\NewsFeed\NewsFeedProject\NewsFeedMvc\Views\Home\About.cshtml"
Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(94, 17, true);
            WriteLiteral("</h3>\r\n\r\n\r\n<dl>\r\n");
            EndContext();
#line 9 "C:\rproj\NewsFeed\NewsFeedProject\NewsFeedMvc\Views\Home\About.cshtml"
     foreach (var claim in User.Claims)
    {

#line default
#line hidden
            BeginContext(159, 12, true);
            WriteLiteral("        <dt>");
            EndContext();
            BeginContext(172, 10, false);
#line 11 "C:\rproj\NewsFeed\NewsFeedProject\NewsFeedMvc\Views\Home\About.cshtml"
       Write(claim.Type);

#line default
#line hidden
            EndContext();
            BeginContext(182, 19, true);
            WriteLiteral("</dt>\r\n        <dt>");
            EndContext();
            BeginContext(202, 11, false);
#line 12 "C:\rproj\NewsFeed\NewsFeedProject\NewsFeedMvc\Views\Home\About.cshtml"
       Write(claim.Value);

#line default
#line hidden
            EndContext();
            BeginContext(213, 7, true);
            WriteLiteral("</dt>\r\n");
            EndContext();
#line 13 "C:\rproj\NewsFeed\NewsFeedProject\NewsFeedMvc\Views\Home\About.cshtml"

    }

#line default
#line hidden
            BeginContext(229, 7, true);
            WriteLiteral("</dl>\r\n");
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
