#pragma checksum "C:\Users\nEW u\Documents\NEW_Csharp.NET\CFP_CodeFirst\ProductMVC_JQueryAgaxMethod\ProductMVC_JQueryAgaxMethod\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "053a1d6f0e6861d26ac4be9c19e20ad802314c45"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
#line 1 "C:\Users\nEW u\Documents\NEW_Csharp.NET\CFP_CodeFirst\ProductMVC_JQueryAgaxMethod\ProductMVC_JQueryAgaxMethod\Views\_ViewImports.cshtml"
using ProductMVC_JQueryAgaxMethod;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nEW u\Documents\NEW_Csharp.NET\CFP_CodeFirst\ProductMVC_JQueryAgaxMethod\ProductMVC_JQueryAgaxMethod\Views\_ViewImports.cshtml"
using ProductMVC_JQueryAgaxMethod.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"053a1d6f0e6861d26ac4be9c19e20ad802314c45", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf2e347ae3e7d5dc5385b5916bda806d3f776b63", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color:lightgray;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\nEW u\Documents\NEW_Csharp.NET\CFP_CodeFirst\ProductMVC_JQueryAgaxMethod\ProductMVC_JQueryAgaxMethod\Views\Product\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "053a1d6f0e6861d26ac4be9c19e20ad802314c454040", async() => {
                WriteLiteral(@"
    <meta name=""viewport"" content=""width=device-width"" />
    <title>Index</title>
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js""></script>
    <script type=""text/javascript"">
        $(document).ready(function () {

            $('#buttonClick').click(function () {
                $.ajax({
                    type: 'GET',
                    url: """);
#nullable restore
#line 18 "C:\Users\nEW u\Documents\NEW_Csharp.NET\CFP_CodeFirst\ProductMVC_JQueryAgaxMethod\ProductMVC_JQueryAgaxMethod\Views\Product\Index.cshtml"
                     Write(Url.Action("Demo1"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""",
                    success: function (result) {
                        $('#result1').html(result);
                    }
                });
            });

            $('#buttonSubmit').click(function () {
               /* var fullName = $('#fullName').val();*/
                val1 = $('#fullName').val();
                $.ajax({
                    type: 'POST',
                    url: """);
#nullable restore
#line 30 "C:\Users\nEW u\Documents\NEW_Csharp.NET\CFP_CodeFirst\ProductMVC_JQueryAgaxMethod\ProductMVC_JQueryAgaxMethod\Views\Product\Index.cshtml"
                     Write(Url.Action("Demo2"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""",
                    data: { fullName: val1 },
                    success: function (result) {
                        $('#result2').html(result);
                    }
                });
            });

            $('#buttonDetail').click(function () {
                $.ajax({
                    type: 'GET',
                    url: """);
#nullable restore
#line 41 "C:\Users\nEW u\Documents\NEW_Csharp.NET\CFP_CodeFirst\ProductMVC_JQueryAgaxMethod\ProductMVC_JQueryAgaxMethod\Views\Product\Index.cshtml"
                     Write(Url.Action("Demo3"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""",
                    success: function (result) {
                        var s = 'Id: ' + result.id;
                        s += '<br>Name: ' + result.name;
                        s += '<br>Price: ' + result.price;
                        $('#result3').html(s);
                    }
                });
            });

            $('#buttonDetails').click(function () {
                $.ajax({
                    type: 'GET',
                    url: """);
#nullable restore
#line 54 "C:\Users\nEW u\Documents\NEW_Csharp.NET\CFP_CodeFirst\ProductMVC_JQueryAgaxMethod\ProductMVC_JQueryAgaxMethod\Views\Product\Index.cshtml"
                     Write(Url.Action("Demo4"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""",
                    success: function (result) {
                        var s = '';
                        for (var i = 0; i < result.length; i++) {
                            s += '<br>Id: ' + result[i].id;
                            s += '<br>Name: ' + result[i].name;
                            s += '<br>Price: ' + result[i].price;
                            s += '<br>------------------';
                        }
                        $('#result4').html(s);
                    }
                });
            });

        });
    </script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "053a1d6f0e6861d26ac4be9c19e20ad802314c458453", async() => {
                WriteLiteral("\r\n    <div class=\"text-center\">\r\n");
                WriteLiteral(@"        <h1 class=""display-12"">Product Records Of Medicine</h1>
       </div>
    <fieldset>
        <legend>Demo 1</legend>
        <input type=""button"" value=""Click"" id=""buttonClick"" />
        <br />
        <span id=""result1""></span>
    </fieldset>
");
                WriteLiteral(@"    <fieldset>
        <legend>Demo 2</legend>
        Full Name <input type=""text"" id=""fullName"" />
        <input type=""button"" value=""Submit"" id=""buttonSubmit"" />
        <br />
        <span id=""result2""></span>
    </fieldset>

    <fieldset>
        <legend>Demo 3</legend>
        <input type=""button"" value=""Detail"" id=""buttonDetail"" />
        <br />
        <span id=""result3""></span>
    </fieldset>

    <fieldset>
        <legend>Demo 4</legend>
        <input type=""button"" value=""Details"" id=""buttonDetails"" />
        <br />
        <span id=""result4""></span>
    </fieldset>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
