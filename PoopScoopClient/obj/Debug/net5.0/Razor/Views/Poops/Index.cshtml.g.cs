#pragma checksum "C:\Users\jpete\OneDrive\Desktop\Coding\PoopScoopClient.Solution\PoopScoopClient\Views\Poops\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36c383d976a7d7e5e2fad28c08796e1b21158312"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Poops_Index), @"mvc.1.0.view", @"/Views/Poops/Index.cshtml")]
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
#line 1 "C:\Users\jpete\OneDrive\Desktop\Coding\PoopScoopClient.Solution\PoopScoopClient\Views\_ViewImports.cshtml"
using PoopScoopClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jpete\OneDrive\Desktop\Coding\PoopScoopClient.Solution\PoopScoopClient\Views\_ViewImports.cshtml"
using PoopScoopClient.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36c383d976a7d7e5e2fad28c08796e1b21158312", @"/Views/Poops/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3e989437d90c613334d31e5a1c0ab8fcbdf3b15", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Poops_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<ol>\r\n");
#nullable restore
#line 2 "C:\Users\jpete\OneDrive\Desktop\Coding\PoopScoopClient.Solution\PoopScoopClient\Views\Poops\Index.cshtml"
 foreach (Poop poop in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <ul>\r\n        <li>ID: ");
#nullable restore
#line 5 "C:\Users\jpete\OneDrive\Desktop\Coding\PoopScoopClient.Solution\PoopScoopClient\Views\Poops\Index.cshtml"
           Write(poop.PoopId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        <li>Consistency: ");
#nullable restore
#line 6 "C:\Users\jpete\OneDrive\Desktop\Coding\PoopScoopClient.Solution\PoopScoopClient\Views\Poops\Index.cshtml"
                    Write(poop.Consistency);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        <li>Volume: ");
#nullable restore
#line 7 "C:\Users\jpete\OneDrive\Desktop\Coding\PoopScoopClient.Solution\PoopScoopClient\Views\Poops\Index.cshtml"
               Write(poop.Volume);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        <li>");
#nullable restore
#line 8 "C:\Users\jpete\OneDrive\Desktop\Coding\PoopScoopClient.Solution\PoopScoopClient\Views\Poops\Index.cshtml"
       Write(Html.ActionLink($"{poop.Color}", "Color", new { color = poop.Color}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        <li>Content: ");
#nullable restore
#line 9 "C:\Users\jpete\OneDrive\Desktop\Coding\PoopScoopClient.Solution\PoopScoopClient\Views\Poops\Index.cshtml"
                Write(poop.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        <li>Coating: ");
#nullable restore
#line 10 "C:\Users\jpete\OneDrive\Desktop\Coding\PoopScoopClient.Solution\PoopScoopClient\Views\Poops\Index.cshtml"
                Write(poop.Coating);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        <li>Grade: ");
#nullable restore
#line 11 "C:\Users\jpete\OneDrive\Desktop\Coding\PoopScoopClient.Solution\PoopScoopClient\Views\Poops\Index.cshtml"
              Write(poop.Grade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        <li>Problem: ");
#nullable restore
#line 12 "C:\Users\jpete\OneDrive\Desktop\Coding\PoopScoopClient.Solution\PoopScoopClient\Views\Poops\Index.cshtml"
                Write(poop.Problem);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        <li>Solution: ");
#nullable restore
#line 13 "C:\Users\jpete\OneDrive\Desktop\Coding\PoopScoopClient.Solution\PoopScoopClient\Views\Poops\Index.cshtml"
                 Write(poop.Solution);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        <br>\r\n    </ul>\r\n");
#nullable restore
#line 16 "C:\Users\jpete\OneDrive\Desktop\Coding\PoopScoopClient.Solution\PoopScoopClient\Views\Poops\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("</ol>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
