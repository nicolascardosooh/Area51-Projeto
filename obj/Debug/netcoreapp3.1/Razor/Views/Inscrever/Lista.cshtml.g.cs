#pragma checksum "C:\Users\Nicolas\Desktop\Nova pasta (2)\Etapa4-PI-Nicolas\area51\Views\Inscrever\Lista.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48b1cb32a68e7cc998cb68f7ceb36574a6ad4cfb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Inscrever_Lista), @"mvc.1.0.view", @"/Views/Inscrever/Lista.cshtml")]
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
#line 1 "C:\Users\Nicolas\Desktop\Nova pasta (2)\Etapa4-PI-Nicolas\area51\Views\_ViewImports.cshtml"
using area51;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Nicolas\Desktop\Nova pasta (2)\Etapa4-PI-Nicolas\area51\Views\_ViewImports.cshtml"
using area51.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48b1cb32a68e7cc998cb68f7ceb36574a6ad4cfb", @"/Views/Inscrever/Lista.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b6d7f8f3af44dd06b235ab84a5fead91ee6b147", @"/Views/_ViewImports.cshtml")]
    public class Views_Inscrever_Lista : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Inscrever>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Cadastro", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Nicolas\Desktop\Nova pasta (2)\Etapa4-PI-Nicolas\area51\Views\Inscrever\Lista.cshtml"
  
    ViewData["Title"] = "Inscrições";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 5 "C:\Users\Nicolas\Desktop\Nova pasta (2)\Etapa4-PI-Nicolas\area51\Views\Inscrever\Lista.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>

<div class=""text-center fundo-transparente box-shadow"">
    <table class=""table"">
        <thead class=""text-black"">
            <tr>
                <th>Id</th>
                <th>Nome</th>
                <th>Modalidade</th>
                <th>Idade</th>
                <th>Operações</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 19 "C:\Users\Nicolas\Desktop\Nova pasta (2)\Etapa4-PI-Nicolas\area51\Views\Inscrever\Lista.cshtml"
             foreach (Inscrever item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 22 "C:\Users\Nicolas\Desktop\Nova pasta (2)\Etapa4-PI-Nicolas\area51\Views\Inscrever\Lista.cshtml"
                   Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 23 "C:\Users\Nicolas\Desktop\Nova pasta (2)\Etapa4-PI-Nicolas\area51\Views\Inscrever\Lista.cshtml"
                   Write(item.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 24 "C:\Users\Nicolas\Desktop\Nova pasta (2)\Etapa4-PI-Nicolas\area51\Views\Inscrever\Lista.cshtml"
                   Write(item.Modalidade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 25 "C:\Users\Nicolas\Desktop\Nova pasta (2)\Etapa4-PI-Nicolas\area51\Views\Inscrever\Lista.cshtml"
                   Write(item.Idade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n<td>\r\n <a");
            BeginWriteAttribute("href", " href=\"", 721, "\"", 757, 2);
            WriteAttributeValue("", 728, "/Inscrever/Editar?Id=", 728, 21, true);
#nullable restore
#line 27 "C:\Users\Nicolas\Desktop\Nova pasta (2)\Etapa4-PI-Nicolas\area51\Views\Inscrever\Lista.cshtml"
WriteAttributeValue("", 749, item.Id, 749, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> Alterar</a>\r\n <a");
            BeginWriteAttribute("href", " href=\"", 776, "\"", 813, 2);
            WriteAttributeValue("", 783, "/Inscrever/Remover?Id=", 783, 22, true);
#nullable restore
#line 28 "C:\Users\Nicolas\Desktop\Nova pasta (2)\Etapa4-PI-Nicolas\area51\Views\Inscrever\Lista.cshtml"
WriteAttributeValue("", 805, item.Id, 805, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> Excluir</a>\r\n     </td>\r\n     \r\n                </tr>\r\n");
#nullable restore
#line 32 "C:\Users\Nicolas\Desktop\Nova pasta (2)\Etapa4-PI-Nicolas\area51\Views\Inscrever\Lista.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n        </tbody>\r\n\r\n    </table>\r\n    <br>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "48b1cb32a68e7cc998cb68f7ceb36574a6ad4cfb6944", async() => {
                WriteLiteral("Nova Matricula");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    <style>\r\n        body {\r\n            background-color: whitesmoke;\r\n        }\r\n    </style>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Inscrever>> Html { get; private set; }
    }
}
#pragma warning restore 1591