#pragma checksum "C:\Users\Desenvolvimento\Documents\Cursos Ponto.Sys\ASP.NET Core MVC\AppMvcCompleta\AppMVCCompleta\src\DevIO.App\Views\Produtos\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e5e9833a0bb0c134830328ecafa5f2910f28980"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produtos_Delete), @"mvc.1.0.view", @"/Views/Produtos/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Produtos/Delete.cshtml", typeof(AspNetCore.Views_Produtos_Delete))]
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
#line 1 "C:\Users\Desenvolvimento\Documents\Cursos Ponto.Sys\ASP.NET Core MVC\AppMvcCompleta\AppMVCCompleta\src\DevIO.App\Views\_ViewImports.cshtml"
using DevIO.App;

#line default
#line hidden
#line 2 "C:\Users\Desenvolvimento\Documents\Cursos Ponto.Sys\ASP.NET Core MVC\AppMvcCompleta\AppMVCCompleta\src\DevIO.App\Views\_ViewImports.cshtml"
using DevIO.App.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e5e9833a0bb0c134830328ecafa5f2910f28980", @"/Views/Produtos/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e46520552455c26e1c0c5c6407f1a714682de3ab", @"/Views/_ViewImports.cshtml")]
    public class Views_Produtos_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DevIO.App.ViewModels.ProdutoViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 300px; height: 428px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\Desenvolvimento\Documents\Cursos Ponto.Sys\ASP.NET Core MVC\AppMvcCompleta\AppMVCCompleta\src\DevIO.App\Views\Produtos\Delete.cshtml"
   ViewData["Title"] = "Excluir" + Model.Nome + " ? "; 

#line default
#line hidden
            BeginContext(103, 31, true);
            WriteLiteral("\n<h4 style=\"padding-top: 50px\">");
            EndContext();
            BeginContext(135, 17, false);
#line 5 "C:\Users\Desenvolvimento\Documents\Cursos Ponto.Sys\ASP.NET Core MVC\AppMvcCompleta\AppMVCCompleta\src\DevIO.App\Views\Produtos\Delete.cshtml"
                         Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(152, 55, true);
            WriteLiteral("</h4>\n<hr />\n\n<div>\n    <div class=\"col-md-4\">\n        ");
            EndContext();
            BeginContext(207, 89, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8e5e9833a0bb0c134830328ecafa5f2910f289806437", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 217, "~/Imagens/", 217, 10, true);
#line 10 "C:\Users\Desenvolvimento\Documents\Cursos Ponto.Sys\ASP.NET Core MVC\AppMvcCompleta\AppMVCCompleta\src\DevIO.App\Views\Produtos\Delete.cshtml"
AddHtmlAttributeValue("", 227, Model.Imagem, 227, 13, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 10 "C:\Users\Desenvolvimento\Documents\Cursos Ponto.Sys\ASP.NET Core MVC\AppMvcCompleta\AppMVCCompleta\src\DevIO.App\Views\Produtos\Delete.cshtml"
AddHtmlAttributeValue("", 247, Model.Nome, 247, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(296, 102, true);
            WriteLiteral("\n    </div>\n    <div class=\"col-md-6\">\n        <dl>\n            <dt class=\"col-sm-2\">\n                ");
            EndContext();
            BeginContext(399, 40, false);
#line 15 "C:\Users\Desenvolvimento\Documents\Cursos Ponto.Sys\ASP.NET Core MVC\AppMvcCompleta\AppMVCCompleta\src\DevIO.App\Views\Produtos\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(439, 70, true);
            WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
            EndContext();
            BeginContext(510, 36, false);
#line 18 "C:\Users\Desenvolvimento\Documents\Cursos Ponto.Sys\ASP.NET Core MVC\AppMvcCompleta\AppMVCCompleta\src\DevIO.App\Views\Produtos\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(546, 69, true);
            WriteLiteral("\n            </dd>\n            <dt class=\"col-sm-2\">\n                ");
            EndContext();
            BeginContext(616, 45, false);
#line 21 "C:\Users\Desenvolvimento\Documents\Cursos Ponto.Sys\ASP.NET Core MVC\AppMvcCompleta\AppMVCCompleta\src\DevIO.App\Views\Produtos\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Descricao));

#line default
#line hidden
            EndContext();
            BeginContext(661, 70, true);
            WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
            EndContext();
            BeginContext(732, 41, false);
#line 24 "C:\Users\Desenvolvimento\Documents\Cursos Ponto.Sys\ASP.NET Core MVC\AppMvcCompleta\AppMVCCompleta\src\DevIO.App\Views\Produtos\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Descricao));

#line default
#line hidden
            EndContext();
            BeginContext(773, 69, true);
            WriteLiteral("\n            </dd>\n            <dt class=\"col-sm-2\">\n                ");
            EndContext();
            BeginContext(843, 42, false);
#line 27 "C:\Users\Desenvolvimento\Documents\Cursos Ponto.Sys\ASP.NET Core MVC\AppMvcCompleta\AppMVCCompleta\src\DevIO.App\Views\Produtos\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Imagem));

#line default
#line hidden
            EndContext();
            BeginContext(885, 70, true);
            WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
            EndContext();
            BeginContext(956, 38, false);
#line 30 "C:\Users\Desenvolvimento\Documents\Cursos Ponto.Sys\ASP.NET Core MVC\AppMvcCompleta\AppMVCCompleta\src\DevIO.App\Views\Produtos\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Imagem));

#line default
#line hidden
            EndContext();
            BeginContext(994, 69, true);
            WriteLiteral("\n            </dd>\n            <dt class=\"col-sm-2\">\n                ");
            EndContext();
            BeginContext(1064, 41, false);
#line 33 "C:\Users\Desenvolvimento\Documents\Cursos Ponto.Sys\ASP.NET Core MVC\AppMvcCompleta\AppMVCCompleta\src\DevIO.App\Views\Produtos\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Valor));

#line default
#line hidden
            EndContext();
            BeginContext(1105, 70, true);
            WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
            EndContext();
            BeginContext(1176, 37, false);
#line 36 "C:\Users\Desenvolvimento\Documents\Cursos Ponto.Sys\ASP.NET Core MVC\AppMvcCompleta\AppMVCCompleta\src\DevIO.App\Views\Produtos\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Valor));

#line default
#line hidden
            EndContext();
            BeginContext(1213, 69, true);
            WriteLiteral("\n            </dd>\n            <dt class=\"col-sm-2\">\n                ");
            EndContext();
            BeginContext(1283, 41, false);
#line 39 "C:\Users\Desenvolvimento\Documents\Cursos Ponto.Sys\ASP.NET Core MVC\AppMvcCompleta\AppMVCCompleta\src\DevIO.App\Views\Produtos\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Ativo));

#line default
#line hidden
            EndContext();
            BeginContext(1324, 70, true);
            WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
            EndContext();
            BeginContext(1395, 37, false);
#line 42 "C:\Users\Desenvolvimento\Documents\Cursos Ponto.Sys\ASP.NET Core MVC\AppMvcCompleta\AppMVCCompleta\src\DevIO.App\Views\Produtos\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Ativo));

#line default
#line hidden
            EndContext();
            BeginContext(1432, 69, true);
            WriteLiteral("\n            </dd>\n            <dt class=\"col-sm-2\">\n                ");
            EndContext();
            BeginContext(1502, 46, false);
#line 45 "C:\Users\Desenvolvimento\Documents\Cursos Ponto.Sys\ASP.NET Core MVC\AppMvcCompleta\AppMVCCompleta\src\DevIO.App\Views\Produtos\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Fornecedor));

#line default
#line hidden
            EndContext();
            BeginContext(1548, 70, true);
            WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
            EndContext();
            BeginContext(1619, 52, false);
#line 48 "C:\Users\Desenvolvimento\Documents\Cursos Ponto.Sys\ASP.NET Core MVC\AppMvcCompleta\AppMVCCompleta\src\DevIO.App\Views\Produtos\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Fornecedor.Documento));

#line default
#line hidden
            EndContext();
            BeginContext(1671, 49, true);
            WriteLiteral("\n            </dd>\n        </dl>\n    </div>\n\n    ");
            EndContext();
            BeginContext(1720, 214, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e5e9833a0bb0c134830328ecafa5f2910f2898014647", async() => {
                BeginContext(1746, 9, true);
                WriteLiteral("\n        ");
                EndContext();
                BeginContext(1755, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8e5e9833a0bb0c134830328ecafa5f2910f2898015037", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 54 "C:\Users\Desenvolvimento\Documents\Cursos Ponto.Sys\ASP.NET Core MVC\AppMvcCompleta\AppMVCCompleta\src\DevIO.App\Views\Produtos\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1791, 78, true);
                WriteLiteral("\n        <input class=\"btn btn-danger\" type=\"submit\" value=\"Delete\"/>\n        ");
                EndContext();
                BeginContext(1869, 53, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e5e9833a0bb0c134830328ecafa5f2910f2898016998", async() => {
                    BeginContext(1912, 6, true);
                    WriteLiteral("Voltar");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1922, 5, true);
                WriteLiteral("\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1934, 8, true);
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DevIO.App.ViewModels.ProdutoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
