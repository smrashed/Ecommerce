#pragma checksum "C:\Users\rashed\Desktop\SMECommerce\SMECommerce.app\Views\Product\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af7d6af3fc989a500b7ac4e3461216bd1c027822"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Details), @"mvc.1.0.view", @"/Views/Product/Details.cshtml")]
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
#line 1 "C:\Users\rashed\Desktop\SMECommerce\SMECommerce.app\Views\_ViewImports.cshtml"
using SMECommerce.app;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rashed\Desktop\SMECommerce\SMECommerce.app\Views\_ViewImports.cshtml"
using SMECommerce.app.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\rashed\Desktop\SMECommerce\SMECommerce.app\Views\_ViewImports.cshtml"
using SMECommerce.app.Models.Auth;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rashed\Desktop\SMECommerce\SMECommerce.app\Views\Product\Details.cshtml"
using SMECommerce.Models.EntityModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\rashed\Desktop\SMECommerce\SMECommerce.app\Views\Product\Details.cshtml"
using SMECommerce.Databases.DbContexts;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af7d6af3fc989a500b7ac4e3461216bd1c027822", @"/Views/Product/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11fcc35fed188ae2b50e22ad0b21e139ce1cc8f2", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Product_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SMECommerce.app.Models.ProductModels.ProductDetails>
    #nullable disable
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"


<!-- Main content -->
<section class=""content"">

    <!-- Default box -->
    <div class=""card card-solid"">
        <div class=""card-body"">
            <div class=""card-header"">
                <h3>Product Details</h3>
            </div>
            <div class=""row"">
                <div class=""col-12 col-sm-6"">

                    <div class=""col-12"">
                        <img");
            BeginWriteAttribute("src", " src=\"", 544, "\"", 572, 1);
#nullable restore
#line 20 "C:\Users\rashed\Desktop\SMECommerce\SMECommerce.app\Views\Product\Details.cshtml"
WriteAttributeValue("", 550, Model.ProductPhotoUrl, 550, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"product-image\" alt=\"Product Image\">\r\n                    </div>\r\n\r\n                </div>\r\n                <div class=\"col-12 col-sm-6\">\r\n                    <h3 class=\"my-3\">");
#nullable restore
#line 25 "C:\Users\rashed\Desktop\SMECommerce\SMECommerce.app\Views\Product\Details.cshtml"
                                Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af7d6af3fc989a500b7ac4e3461216bd1c0278225032", async() => {
                WriteLiteral("Description");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 26 "C:\Users\rashed\Desktop\SMECommerce\SMECommerce.app\Views\Product\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Description);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <p>");
#nullable restore
#line 27 "C:\Users\rashed\Desktop\SMECommerce\SMECommerce.app\Views\Product\Details.cshtml"
                  Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af7d6af3fc989a500b7ac4e3461216bd1c0278226808", async() => {
                WriteLiteral("Price");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 28 "C:\Users\rashed\Desktop\SMECommerce\SMECommerce.app\Views\Product\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Price);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <p>");
#nullable restore
#line 29 "C:\Users\rashed\Desktop\SMECommerce\SMECommerce.app\Views\Product\Details.cshtml"
                  Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" BDT</p>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af7d6af3fc989a500b7ac4e3461216bd1c0278228570", async() => {
                WriteLiteral("Manufacture Date");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 30 "C:\Users\rashed\Desktop\SMECommerce\SMECommerce.app\Views\Product\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ManufactureDate);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <p>");
#nullable restore
#line 31 "C:\Users\rashed\Desktop\SMECommerce\SMECommerce.app\Views\Product\Details.cshtml"
                  Write(Model.ManufactureDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af7d6af3fc989a500b7ac4e3461216bd1c02782210359", async() => {
                WriteLiteral("Category");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 32 "C:\Users\rashed\Desktop\SMECommerce\SMECommerce.app\Views\Product\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CategoryId);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <p>");
#nullable restore
#line 33 "C:\Users\rashed\Desktop\SMECommerce\SMECommerce.app\Views\Product\Details.cshtml"
                  Write(Model.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n        <!-- /.card-body -->\r\n    </div>\r\n    <!-- /.card -->\r\n\r\n</section>\r\n<!-- /.content -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SMECommerce.app.Models.ProductModels.ProductDetails> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
