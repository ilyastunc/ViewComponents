#pragma checksum "/Users/tunc/Documents/C#/ViewComponents/Views/Shared/Components/ProductSummary/RedCard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce6dd0d325b922d2af38d69cbed063cba677ad44"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ProductSummary_RedCard), @"mvc.1.0.view", @"/Views/Shared/Components/ProductSummary/RedCard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/ProductSummary/RedCard.cshtml", typeof(AspNetCore.Views_Shared_Components_ProductSummary_RedCard))]
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
#line 1 "/Users/tunc/Documents/C#/ViewComponents/Views/_ViewImports.cshtml"
using ViewComponents.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce6dd0d325b922d2af38d69cbed063cba677ad44", @"/Views/Shared/Components/ProductSummary/RedCard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa69799e2e4159fd27affc2fb184fae2b0015512", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_ProductSummary_RedCard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductSummaryViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(31, 110, true);
            WriteLiteral("\n<div class=\"card text-white bg-danger mb-3\" style=\"max-width: 18rem;\">\n  <div class=\"card-body\">\n    <strong>");
            EndContext();
            BeginContext(142, 11, false);
#line 5 "/Users/tunc/Documents/C#/ViewComponents/Views/Shared/Components/ProductSummary/RedCard.cshtml"
       Write(Model.Count);

#line default
#line hidden
            EndContext();
            BeginContext(153, 35, true);
            WriteLiteral("</strong> ürün toplam fiyatı <span>");
            EndContext();
            BeginContext(189, 16, false);
#line 5 "/Users/tunc/Documents/C#/ViewComponents/Views/Shared/Components/ProductSummary/RedCard.cshtml"
                                                      Write(Model.TotalPrice);

#line default
#line hidden
            EndContext();
            BeginContext(205, 20, true);
            WriteLiteral(" TL.</span>\n  </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductSummaryViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
