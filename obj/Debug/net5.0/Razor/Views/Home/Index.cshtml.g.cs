#pragma checksum "C:\Users\moham\OneDrive\Desktop\authenticationAndAuthorizationCore\AuthIdentity\AuthIdentity\AuthIdentity\AuthIdentity\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3561856b6d5d9c500276d59683cdb5e11692c3a5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AuthIdentity.Pages.Home.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AuthIdentity.Pages.Home
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
#line 1 "C:\Users\moham\OneDrive\Desktop\authenticationAndAuthorizationCore\AuthIdentity\AuthIdentity\AuthIdentity\AuthIdentity\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\moham\OneDrive\Desktop\authenticationAndAuthorizationCore\AuthIdentity\AuthIdentity\AuthIdentity\AuthIdentity\Views\_ViewImports.cshtml"
using AuthIdentity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\moham\OneDrive\Desktop\authenticationAndAuthorizationCore\AuthIdentity\AuthIdentity\AuthIdentity\AuthIdentity\Views\_ViewImports.cshtml"
using AuthIdentity.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\moham\OneDrive\Desktop\authenticationAndAuthorizationCore\AuthIdentity\AuthIdentity\AuthIdentity\AuthIdentity\Views\Home\Index.cshtml"
using AuthIdentity.Data.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3561856b6d5d9c500276d59683cdb5e11692c3a5", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b7bf6ebf16cdeb0028e20fbd525ed1e0be7ca44", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PostViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\Users\moham\OneDrive\Desktop\authenticationAndAuthorizationCore\AuthIdentity\AuthIdentity\AuthIdentity\AuthIdentity\Views\Home\Index.cshtml"
 foreach(var data in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"post\">\r\n    <p class=\"publisher\">");
#nullable restore
#line (12,27)-(12,45) 6 "C:\Users\moham\OneDrive\Desktop\authenticationAndAuthorizationCore\AuthIdentity\AuthIdentity\AuthIdentity\AuthIdentity\Views\Home\Index.cshtml"
Write(data.User.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span style=\"font-size:10px;display:block\">publish Date ");
#nullable restore
#line (12,103)-(12,119) 6 "C:\Users\moham\OneDrive\Desktop\authenticationAndAuthorizationCore\AuthIdentity\AuthIdentity\AuthIdentity\AuthIdentity\Views\Home\Index.cshtml"
Write(data.PublishTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>    \r\n    <p class=\"content\" style=\"font-weight:bold\">");
#nullable restore
#line (13,50)-(13,62) 6 "C:\Users\moham\OneDrive\Desktop\authenticationAndAuthorizationCore\AuthIdentity\AuthIdentity\AuthIdentity\AuthIdentity\Views\Home\Index.cshtml"
Write(data.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n    <hr>\r\n");
#nullable restore
#line 16 "C:\Users\moham\OneDrive\Desktop\authenticationAndAuthorizationCore\AuthIdentity\AuthIdentity\AuthIdentity\AuthIdentity\Views\Home\Index.cshtml"

}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PostViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
