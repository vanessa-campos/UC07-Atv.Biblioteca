#pragma checksum "I:\Meu Drive\Senac-EAD\TII\MB.UC07 - Documentar e realizar manutenção de aplicações web\atividade 02\Biblioteca - netcore3.1\Biblioteca\Views\Usuario\AdminRequired.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d6635426228c13280324e7f5acdc1977341c2a0f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_AdminRequired), @"mvc.1.0.view", @"/Views/Usuario/AdminRequired.cshtml")]
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
#line 1 "I:\Meu Drive\Senac-EAD\TII\MB.UC07 - Documentar e realizar manutenção de aplicações web\atividade 02\Biblioteca - netcore3.1\Biblioteca\Views\_ViewImports.cshtml"
using Biblioteca;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "I:\Meu Drive\Senac-EAD\TII\MB.UC07 - Documentar e realizar manutenção de aplicações web\atividade 02\Biblioteca - netcore3.1\Biblioteca\Views\_ViewImports.cshtml"
using Biblioteca.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6635426228c13280324e7f5acdc1977341c2a0f", @"/Views/Usuario/AdminRequired.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ea07f0214da259abc315dec5bc842518e8ae187", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_AdminRequired : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "I:\Meu Drive\Senac-EAD\TII\MB.UC07 - Documentar e realizar manutenção de aplicações web\atividade 02\Biblioteca - netcore3.1\Biblioteca\Views\Usuario\AdminRequired.cshtml"
  
    ViewData["Title"] = "Atenção!";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"row justify-content-md-center\">ACESSO NEGADO</h1>\r\n<p class=\"text-danger\" style=\"font-weight: bold;\">É necessário nível de administrador!</p>\r\n\r\n<a href=\"/Home/Index\"><button class=\"btn btn-primary mb-2\">Voltar</button></a>\r\n ");
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
