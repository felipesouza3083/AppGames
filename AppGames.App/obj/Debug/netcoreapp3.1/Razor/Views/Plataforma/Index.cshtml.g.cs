#pragma checksum "C:\Users\felipe.souza\source\repos\AppGames\AppGames.App\Views\Plataforma\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "834a5a4e1e2933fa4f7756b556acfecd5bbde2d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Plataforma_Index), @"mvc.1.0.view", @"/Views/Plataforma/Index.cshtml")]
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
#line 1 "C:\Users\felipe.souza\source\repos\AppGames\AppGames.App\Views\_ViewImports.cshtml"
using AppGames.App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\felipe.souza\source\repos\AppGames\AppGames.App\Views\_ViewImports.cshtml"
using AppGames.App.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"834a5a4e1e2933fa4f7756b556acfecd5bbde2d6", @"/Views/Plataforma/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b7faee6fe30dae70ea76ec0942392b579bedccb", @"/Views/_ViewImports.cshtml")]
    public class Views_Plataforma_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AppGames.App.Models.Plataforma.PlataformaConsultaViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\felipe.souza\source\repos\AppGames\AppGames.App\Views\Plataforma\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<a href=""/Plataforma/Salvar"" class=""btn btn-success"">Nova Plataforma</a>
<br />
<table class=""table table-bordered table-hover"">
    <thead>
        <tr>
            <th>Nome</th>
            <th>Ações</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 18 "C:\Users\felipe.souza\source\repos\AppGames\AppGames.App\Views\Plataforma\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 22 "C:\Users\felipe.souza\source\repos\AppGames\AppGames.App\Views\Plataforma\Index.cshtml"
               Write(item.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 609, "\"", 653, 2);
            WriteAttributeValue("", 616, "/Plataforma/Editar/", 616, 19, true);
#nullable restore
#line 25 "C:\Users\felipe.souza\source\repos\AppGames\AppGames.App\Views\Plataforma\Index.cshtml"
WriteAttributeValue("", 635, item.IdPlataforma, 635, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning btn-sm\">Editar</a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 720, "\"", 765, 2);
            WriteAttributeValue("", 727, "/Plataforma/Deletar/", 727, 20, true);
#nullable restore
#line 26 "C:\Users\felipe.souza\source\repos\AppGames\AppGames.App\Views\Plataforma\Index.cshtml"
WriteAttributeValue("", 747, item.IdPlataforma, 747, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger btn-sm\">Excluir</a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 29 "C:\Users\felipe.souza\source\repos\AppGames\AppGames.App\Views\Plataforma\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AppGames.App.Models.Plataforma.PlataformaConsultaViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
