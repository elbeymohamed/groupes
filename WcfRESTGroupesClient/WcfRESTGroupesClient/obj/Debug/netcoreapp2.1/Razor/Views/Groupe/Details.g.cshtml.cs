#pragma checksum "D:\BdeB\session04\A16-PROGRAMMATION D'APPLICATIONS WEB\projetSession\option 02\WcfRESTGroupesClient\WcfRESTGroupesClient\Views\Groupe\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91c995722475282fd41cc44724f398bc933a62d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Groupe_Details), @"mvc.1.0.view", @"/Views/Groupe/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Groupe/Details.cshtml", typeof(AspNetCore.Views_Groupe_Details))]
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
#line 1 "D:\BdeB\session04\A16-PROGRAMMATION D'APPLICATIONS WEB\projetSession\option 02\WcfRESTGroupesClient\WcfRESTGroupesClient\Views\_ViewImports.cshtml"
using WcfRESTGroupesClient;

#line default
#line hidden
#line 2 "D:\BdeB\session04\A16-PROGRAMMATION D'APPLICATIONS WEB\projetSession\option 02\WcfRESTGroupesClient\WcfRESTGroupesClient\Views\_ViewImports.cshtml"
using WcfRESTGroupesClient.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91c995722475282fd41cc44724f398bc933a62d7", @"/Views/Groupe/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bcd111adbeae28f44e8f7e151a09dfe003febe06", @"/Views/_ViewImports.cshtml")]
    public class Views_Groupe_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WcfRESTGroupesClient.Models.Personne>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\BdeB\session04\A16-PROGRAMMATION D'APPLICATIONS WEB\projetSession\option 02\WcfRESTGroupesClient\WcfRESTGroupesClient\Views\Groupe\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(90, 122, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Personne</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(213, 38, false);
#line 14 "D:\BdeB\session04\A16-PROGRAMMATION D'APPLICATIONS WEB\projetSession\option 02\WcfRESTGroupesClient\WcfRESTGroupesClient\Views\Groupe\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.id));

#line default
#line hidden
            EndContext();
            BeginContext(251, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(295, 34, false);
#line 17 "D:\BdeB\session04\A16-PROGRAMMATION D'APPLICATIONS WEB\projetSession\option 02\WcfRESTGroupesClient\WcfRESTGroupesClient\Views\Groupe\Details.cshtml"
       Write(Html.DisplayFor(model => model.id));

#line default
#line hidden
            EndContext();
            BeginContext(329, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(373, 44, false);
#line 20 "D:\BdeB\session04\A16-PROGRAMMATION D'APPLICATIONS WEB\projetSession\option 02\WcfRESTGroupesClient\WcfRESTGroupesClient\Views\Groupe\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.courriel));

#line default
#line hidden
            EndContext();
            BeginContext(417, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(461, 40, false);
#line 23 "D:\BdeB\session04\A16-PROGRAMMATION D'APPLICATIONS WEB\projetSession\option 02\WcfRESTGroupesClient\WcfRESTGroupesClient\Views\Groupe\Details.cshtml"
       Write(Html.DisplayFor(model => model.courriel));

#line default
#line hidden
            EndContext();
            BeginContext(501, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(545, 44, false);
#line 26 "D:\BdeB\session04\A16-PROGRAMMATION D'APPLICATIONS WEB\projetSession\option 02\WcfRESTGroupesClient\WcfRESTGroupesClient\Views\Groupe\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.passWord));

#line default
#line hidden
            EndContext();
            BeginContext(589, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(633, 40, false);
#line 29 "D:\BdeB\session04\A16-PROGRAMMATION D'APPLICATIONS WEB\projetSession\option 02\WcfRESTGroupesClient\WcfRESTGroupesClient\Views\Groupe\Details.cshtml"
       Write(Html.DisplayFor(model => model.passWord));

#line default
#line hidden
            EndContext();
            BeginContext(673, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(717, 44, false);
#line 32 "D:\BdeB\session04\A16-PROGRAMMATION D'APPLICATIONS WEB\projetSession\option 02\WcfRESTGroupesClient\WcfRESTGroupesClient\Views\Groupe\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.userName));

#line default
#line hidden
            EndContext();
            BeginContext(761, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(805, 40, false);
#line 35 "D:\BdeB\session04\A16-PROGRAMMATION D'APPLICATIONS WEB\projetSession\option 02\WcfRESTGroupesClient\WcfRESTGroupesClient\Views\Groupe\Details.cshtml"
       Write(Html.DisplayFor(model => model.userName));

#line default
#line hidden
            EndContext();
            BeginContext(845, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(893, 68, false);
#line 40 "D:\BdeB\session04\A16-PROGRAMMATION D'APPLICATIONS WEB\projetSession\option 02\WcfRESTGroupesClient\WcfRESTGroupesClient\Views\Groupe\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(961, 4, true);
            WriteLiteral(" |\r\n");
            EndContext();
            BeginContext(1013, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(1017, 97, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f0a0f597dacf40348ec57b574d82cd6e", async() => {
                BeginContext(1085, 25, true);
                WriteLiteral("Retour au menu principal ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1114, 14, true);
            WriteLiteral("<br>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WcfRESTGroupesClient.Models.Personne> Html { get; private set; }
    }
}
#pragma warning restore 1591