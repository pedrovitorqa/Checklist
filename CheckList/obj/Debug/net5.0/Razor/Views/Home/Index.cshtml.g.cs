#pragma checksum "C:\Users\PedroVitorDev\Desktop\Checklist trabalho final Leonardo\Trabalho final Leo\CheckList\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2972d0c702fa8396745373f529f14e9f7e133cd0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\PedroVitorDev\Desktop\Checklist trabalho final Leonardo\Trabalho final Leo\CheckList\Views\_ViewImports.cshtml"
using CheckList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\PedroVitorDev\Desktop\Checklist trabalho final Leonardo\Trabalho final Leo\CheckList\Views\_ViewImports.cshtml"
using CheckList.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2972d0c702fa8396745373f529f14e9f7e133cd0", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc97fd5ea0d9a47f58cfac4bd32cb9bedbfcfe9e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CheckList.ViewModel.Home.IndexViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\PedroVitorDev\Desktop\Checklist trabalho final Leonardo\Trabalho final Leo\CheckList\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Análise Dos Dados</h1>
</div>

<div class=""alinhar"">
<div class=""bs-example"">
    <div class=""container--md"">
        <div class=""row mb-4"">
            <div class=""col-sm-5"">
                <div class=""card"">
                    <div class=""card-body"">
                        <h5 class=""card-title"">Número de CheckList</h5>
                        <p class=""card-text"">O número de Checklists é de: ");
#nullable restore
#line 18 "C:\Users\PedroVitorDev\Desktop\Checklist trabalho final Leonardo\Trabalho final Leo\CheckList\Views\Home\Index.cshtml"
                                                                     Write(Model.totalCheckList);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                    </div>
                </div>
            </div>
            <div class=""col-sm-5"">                                                                    
                <div class=""card"">                                                                        
                    <div class=""card-body"">                                                           
                        <h5 class=""card-title"">Número de Itens</h5>                               
                        <p class=""card-text"">O número de Itens é de: ");
#nullable restore
#line 26 "C:\Users\PedroVitorDev\Desktop\Checklist trabalho final Leonardo\Trabalho final Leo\CheckList\Views\Home\Index.cshtml"
                                                                Write(Model.totalItens);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p> 
                    </div>
                </div>
            </div> 
            <div class=""col-sm-5"">                                                                       
                <div class=""card"">
                    <div class=""card-body"">
                        <h5 class=""card-title"">Número de Itens Realizados</h5>
                        <p class=""card-text"">O número de Itens Realizados é de: ");
#nullable restore
#line 34 "C:\Users\PedroVitorDev\Desktop\Checklist trabalho final Leonardo\Trabalho final Leo\CheckList\Views\Home\Index.cshtml"
                                                                           Write(Model.itensRealizados);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                    </div>
                </div>
            </div>
            <div class=""col-sm-5""> 
                <div class=""card"">
                    <div class=""card-body"">
                        <h5 class=""card-title"">Número de Itens Não Realizados</h5>
                        <p class=""card-text"">O número de Itens Não Realizados é de: ");
#nullable restore
#line 42 "C:\Users\PedroVitorDev\Desktop\Checklist trabalho final Leonardo\Trabalho final Leo\CheckList\Views\Home\Index.cshtml"
                                                                               Write(Model.itensNaoRealizados);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n</div>  \r\n\r\n                                                                                                                        ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CheckList.ViewModel.Home.IndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591