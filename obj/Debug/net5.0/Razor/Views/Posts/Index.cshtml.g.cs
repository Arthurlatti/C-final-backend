#pragma checksum "C:\Users\armyk\Desktop\Programming\CSharp\FinalProJectMVC\Views\Posts\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ebb679eb28b12cdbde8c9c8c9c208beb24302e39"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Posts_Index), @"mvc.1.0.view", @"/Views/Posts/Index.cshtml")]
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
#line 1 "C:\Users\armyk\Desktop\Programming\CSharp\FinalProJectMVC\Views\_ViewImports.cshtml"
using FinalProJectMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\armyk\Desktop\Programming\CSharp\FinalProJectMVC\Views\_ViewImports.cshtml"
using FinalProJectMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebb679eb28b12cdbde8c9c8c9c208beb24302e39", @"/Views/Posts/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0012776f9cac1642f5f093279bf5db922f1c5b3e", @"/Views/_ViewImports.cshtml")]
    public class Views_Posts_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FinalProJectMVC.Models.Post>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\armyk\Desktop\Programming\CSharp\FinalProJectMVC\Views\Posts\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Posts</h1>\r\n\r\n<div class=\"post-wrapper\">\r\n");
#nullable restore
#line 10 "C:\Users\armyk\Desktop\Programming\CSharp\FinalProJectMVC\Views\Posts\Index.cshtml"
 foreach (var post in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card\" style=\"width: 18rem;\">\r\n    <div class=\"card-body\">\r\n        <h5 class=\"card-title\">");
#nullable restore
#line 13 "C:\Users\armyk\Desktop\Programming\CSharp\FinalProJectMVC\Views\Posts\Index.cshtml"
                          Write(post.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n        <p class=\"card-text\">");
#nullable restore
#line 14 "C:\Users\armyk\Desktop\Programming\CSharp\FinalProJectMVC\Views\Posts\Index.cshtml"
                        Write(post.content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n    </div>\r\n");
#nullable restore
#line 17 "C:\Users\armyk\Desktop\Programming\CSharp\FinalProJectMVC\Views\Posts\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FinalProJectMVC.Models.Post>> Html { get; private set; }
    }
}
#pragma warning restore 1591
