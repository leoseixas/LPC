#pragma checksum "C:\Users\Leonardo Seixas\Documents\LPC3\ProjetoConta\ContaWeb\Views\Imovel\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7cad6bfb5aa053b36c84d8710ad2b869714fc05c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Imovel_Edit), @"mvc.1.0.view", @"/Views/Imovel/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Imovel/Edit.cshtml", typeof(AspNetCore.Views_Imovel_Edit))]
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
#line 1 "C:\Users\Leonardo Seixas\Documents\LPC3\ProjetoConta\ContaWeb\Views\_ViewImports.cshtml"
using ContaWeb;

#line default
#line hidden
#line 2 "C:\Users\Leonardo Seixas\Documents\LPC3\ProjetoConta\ContaWeb\Views\_ViewImports.cshtml"
using ContaWeb.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7cad6bfb5aa053b36c84d8710ad2b869714fc05c", @"/Views/Imovel/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd5414e3136804c52c49d492a205db5048833828", @"/Views/_ViewImports.cshtml")]
    public class Views_Imovel_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ContaDomain.Entities.Imovel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("Edit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "Post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(36, 39, true);
            WriteLiteral("\r\n\r\n<div class=\"form-horizontal\">\r\n    ");
            EndContext();
            BeginContext(75, 1346, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7cad6bfb5aa053b36c84d8710ad2b869714fc05c4049", async() => {
                BeginContext(109, 63, true);
                WriteLiteral("\r\n        \r\n        <input hidden type=\"text\" name=\"id\" id=\"id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 172, "\"", 189, 1);
#line 7 "C:\Users\Leonardo Seixas\Documents\LPC3\ProjetoConta\ContaWeb\Views\Imovel\Edit.cshtml"
WriteAttributeValue("", 180, Model.id, 180, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(190, 176, true);
                WriteLiteral("/>\r\n\r\n        <div class=\"form-group\">\r\n            <label>Identificaçãp</label>\r\n            <input  class=\"form-control\"\r\n                    type=\"text\" name=\"Identificacao\"");
                EndContext();
                BeginWriteAttribute("value", "\r\n                    value=\"", 366, "\"", 415, 1);
#line 13 "C:\Users\Leonardo Seixas\Documents\LPC3\ProjetoConta\ContaWeb\Views\Imovel\Edit.cshtml"
WriteAttributeValue("", 395, Model.Identificacao, 395, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(416, 178, true);
                WriteLiteral("/>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            <label>Numero</label>\r\n            <input  class=\"form-control\"\r\n                    type=\"text\" name=\"Numero\"");
                EndContext();
                BeginWriteAttribute("value", "\r\n                    value=\"", 594, "\"", 636, 1);
#line 20 "C:\Users\Leonardo Seixas\Documents\LPC3\ProjetoConta\ContaWeb\Views\Imovel\Edit.cshtml"
WriteAttributeValue("", 623, Model.Numero, 623, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(637, 176, true);
                WriteLiteral("/>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label>Bairro</label>\r\n            <input  class=\"form-control\"\r\n                    type=\"text\" name=\"Bairro\"");
                EndContext();
                BeginWriteAttribute("value", "\r\n                    value=\"", 813, "\"", 855, 1);
#line 26 "C:\Users\Leonardo Seixas\Documents\LPC3\ProjetoConta\ContaWeb\Views\Imovel\Edit.cshtml"
WriteAttributeValue("", 842, Model.Bairro, 842, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(856, 176, true);
                WriteLiteral("/>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label>Cidade</label>\r\n            <input  class=\"form-control\"\r\n                    type=\"text\" name=\"Cidade\"");
                EndContext();
                BeginWriteAttribute("value", "\r\n                    value=\"", 1032, "\"", 1074, 1);
#line 32 "C:\Users\Leonardo Seixas\Documents\LPC3\ProjetoConta\ContaWeb\Views\Imovel\Edit.cshtml"
WriteAttributeValue("", 1061, Model.Cidade, 1061, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1075, 178, true);
                WriteLiteral("/>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            <label>Estado</label>\r\n            <input  class=\"form-control\"\r\n                    type=\"text\" name=\"Estado\"");
                EndContext();
                BeginWriteAttribute("value", "\r\n                    value=\"", 1253, "\"", 1295, 1);
#line 39 "C:\Users\Leonardo Seixas\Documents\LPC3\ProjetoConta\ContaWeb\Views\Imovel\Edit.cshtml"
WriteAttributeValue("", 1282, Model.Estado, 1282, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1296, 118, true);
                WriteLiteral("/>\r\n        </div>\r\n\r\n        <input  class=\"btn btn-primary\" \r\n                type=\"submit\" value=\"Salvar\"/>\r\n\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1421, 8, true);
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ContaDomain.Entities.Imovel> Html { get; private set; }
    }
}
#pragma warning restore 1591
