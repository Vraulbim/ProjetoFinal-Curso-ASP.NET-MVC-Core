#pragma checksum "C:\Users\Desenvolvimento\Documents\Cursos Ponto.Sys\ASP.NET Core MVC\AppMvcCompleta\AppMVCCompleta\src\DevIO.App\Views\Produtos\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7dd47af039399a018a50bd6b5866c9814e7eac12"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produtos_Details), @"mvc.1.0.view", @"/Views/Produtos/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Produtos/Details.cshtml", typeof(AspNetCore.Views_Produtos_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7dd47af039399a018a50bd6b5866c9814e7eac12", @"/Views/Produtos/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e46520552455c26e1c0c5c6407f1a714682de3ab", @"/Views/_ViewImports.cshtml")]
    public class Views_Produtos_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DevIO.App.ViewModels.ProdutoViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 300px; height: 428px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\Desenvolvimento\Documents\Cursos Ponto.Sys\ASP.NET Core MVC\AppMvcCompleta\AppMVCCompleta\src\DevIO.App\Views\Produtos\Details.cshtml"
  
    ViewData["Title"] = "Detalhes do Produto" + Model.Nome;

#line default
#line hidden
            BeginContext(111, 31, true);
            WriteLiteral("\n<h4 style=\"padding-top: 50px\">");
            EndContext();
            BeginContext(143, 17, false);
#line 7 "C:\Users\Desenvolvimento\Documents\Cursos Ponto.Sys\ASP.NET Core MVC\AppMvcCompleta\AppMVCCompleta\src\DevIO.App\Views\Produtos\Details.cshtml"
                         Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(160, 54, true);
            WriteLiteral("</h4>\n<hr/>\n\n<div>\n    <div class=\"col-md-4\">\n        ");
            EndContext();
            BeginContext(214, 89, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7dd47af039399a018a50bd6b5866c9814e7eac126105", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 224, "~/Imagens/", 224, 10, true);
#line 12 "C:\Users\Desenvolvimento\Documents\Cursos Ponto.Sys\ASP.NET Core MVC\AppMvcCompleta\AppMVCCompleta\src\DevIO.App\Views\Produtos\Details.cshtml"
AddHtmlAttributeValue("", 234, Model.Imagem, 234, 13, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 12 "C:\Users\Desenvolvimento\Documents\Cursos Ponto.Sys\ASP.NET Core MVC\AppMvcCompleta\AppMVCCompleta\src\DevIO.App\Views\Produtos\Details.cshtml"
AddHtmlAttributeValue("", 254, Model.Nome, 254, 11, false);

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
            BeginContext(303, 104, true);
            WriteLiteral("\n    </div>\n    <div class=\"col-md-6\">\n        <dl>\n            <dt class = \"col-sm-2\">\n                ");
            EndContext();
            BeginContext(408, 40, false);
#line 17 "C:\Users\Desenvolvimento\Documents\Cursos Ponto.Sys\ASP.NET Core MVC\AppMvcCompleta\AppMVCCompleta\src\DevIO.App\Views\Produtos\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(448, 72, true);
            WriteLiteral("\n            </dt>\n            <dd class = \"col-sm-10\">\n                ");
            EndContext();
            BeginContext(521, 36, false);
#line 20 "C:\Users\Desenvolvimento\Documents\Cursos Ponto.Sys\ASP.NET Core MVC\AppMvcCompleta\AppMVCCompleta\src\DevIO.App\Views\Produtos\Details.cshtml"
           Write(Html.DisplayFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(557, 71, true);
            WriteLiteral("\n            </dd>\n            <dt class = \"col-sm-2\">\n                ");
            EndContext();
            BeginContext(629, 45, false);
#line 23 "C:\Users\Desenvolvimento\Documents\Cursos Ponto.Sys\ASP.NET Core MVC\AppMvcCompleta\AppMVCCompleta\src\DevIO.App\Views\Produtos\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Descricao));

#line default
#line hidden
            EndContext();
            BeginContext(674, 72, true);
            WriteLiteral("\n            </dt>\n            <dd class = \"col-sm-10\">\n                ");
            EndContext();
            BeginContext(747, 41, false);
#line 26 "C:\Users\Desenvolvimento\Documents\Cursos Ponto.Sys\ASP.NET Core MVC\AppMvcCompleta\AppMVCCompleta\src\DevIO.App\Views\Produtos\Details.cshtml"
           Write(Html.DisplayFor(model => model.Descricao));

#line default
#line hidden
            EndContext();
            BeginContext(788, 71, true);
            WriteLiteral("\n            </dd>\n            <dt class = \"col-sm-2\">\n                ");
            EndContext();
            BeginContext(860, 41, false);
#line 29 "C:\Users\Desenvolvimento\Documents\Cursos Ponto.Sys\ASP.NET Core MVC\AppMvcCompleta\AppMVCCompleta\src\DevIO.App\Views\Produtos\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Valor));

#line default
#line hidden
            EndContext();
            BeginContext(901, 72, true);
            WriteLiteral("\n            </dt>\n            <dd class = \"col-sm-10\">\n                ");
            EndContext();
            BeginContext(974, 37, false);
#line 32 "C:\Users\Desenvolvimento\Documents\Cursos Ponto.Sys\ASP.NET Core MVC\AppMvcCompleta\AppMVCCompleta\src\DevIO.App\Views\Produtos\Details.cshtml"
           Write(Html.DisplayFor(model => model.Valor));

#line default
#line hidden
            EndContext();
            BeginContext(1011, 71, true);
            WriteLiteral("\n            </dd>\n            <dt class = \"col-sm-2\">\n                ");
            EndContext();
            BeginContext(1083, 41, false);
#line 35 "C:\Users\Desenvolvimento\Documents\Cursos Ponto.Sys\ASP.NET Core MVC\AppMvcCompleta\AppMVCCompleta\src\DevIO.App\Views\Produtos\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Ativo));

#line default
#line hidden
            EndContext();
            BeginContext(1124, 72, true);
            WriteLiteral("\n            </dt>\n            <dd class = \"col-sm-10\">\n                ");
            EndContext();
            BeginContext(1197, 37, false);
#line 38 "C:\Users\Desenvolvimento\Documents\Cursos Ponto.Sys\ASP.NET Core MVC\AppMvcCompleta\AppMVCCompleta\src\DevIO.App\Views\Produtos\Details.cshtml"
           Write(Html.DisplayFor(model => model.Ativo));

#line default
#line hidden
            EndContext();
            BeginContext(1234, 71, true);
            WriteLiteral("\n            </dd>\n            <dt class = \"col-sm-2\">\n                ");
            EndContext();
            BeginContext(1306, 46, false);
#line 41 "C:\Users\Desenvolvimento\Documents\Cursos Ponto.Sys\ASP.NET Core MVC\AppMvcCompleta\AppMVCCompleta\src\DevIO.App\Views\Produtos\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Fornecedor));

#line default
#line hidden
            EndContext();
            BeginContext(1352, 72, true);
            WriteLiteral("\n            </dt>\n            <dd class = \"col-sm-10\">\n                ");
            EndContext();
            BeginContext(1425, 52, false);
#line 44 "C:\Users\Desenvolvimento\Documents\Cursos Ponto.Sys\ASP.NET Core MVC\AppMvcCompleta\AppMVCCompleta\src\DevIO.App\Views\Produtos\Details.cshtml"
           Write(Html.DisplayFor(model => model.Fornecedor.Documento));

#line default
#line hidden
            EndContext();
            BeginContext(1477, 61, true);
            WriteLiteral("\n            </dd>\n        </dl>\n    </div>\n</div>\n<div>\n    ");
            EndContext();
            BeginContext(1538, 89, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7dd47af039399a018a50bd6b5866c9814e7eac1213375", async() => {
                BeginContext(1617, 6, true);
                WriteLiteral("Editar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 50 "C:\Users\Desenvolvimento\Documents\Cursos Ponto.Sys\ASP.NET Core MVC\AppMvcCompleta\AppMVCCompleta\src\DevIO.App\Views\Produtos\Details.cshtml"
                                                            WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1627, 5, true);
            WriteLiteral("\n    ");
            EndContext();
            BeginContext(1632, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7dd47af039399a018a50bd6b5866c9814e7eac1215874", async() => {
                BeginContext(1675, 6, true);
                WriteLiteral("Voltar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1685, 8, true);
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
