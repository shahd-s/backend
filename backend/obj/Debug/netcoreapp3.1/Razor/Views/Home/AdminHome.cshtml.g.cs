#pragma checksum "/Users/shahdsherif/projects/backend/backend/Views/Home/AdminHome.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e7237007ed18f4509d1bef1454a791efb10a3a98"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AdminHome), @"mvc.1.0.view", @"/Views/Home/AdminHome.cshtml")]
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
#line 1 "/Users/shahdsherif/projects/backend/backend/Views/_ViewImports.cshtml"
using backend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7237007ed18f4509d1bef1454a791efb10a3a98", @"/Views/Home/AdminHome.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8bd21606c269e3b34c4eb1481e55386c39679226", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AdminHome : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<productModel>>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e7237007ed18f4509d1bef1454a791efb10a3a983021", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <!--===============================================================================================-->
    <link rel=""stylesheet"" type=""text/css"" href=""vendor/bootstrap/css/bootstrap.min.css"">
    <!--===============================================================================================-->
    <!--===============================================================================================-->
    <style type=""text/css"">







        * {
            margin: 0px;
            padding: 0px;
            box-sizing: border-box;
        }

        body, html {
            height: 100%;
            font-family: sans-serif;
        }

        a {
            margin: 0px;
            transition: all 0.4s;
            -webkit-transition: all 0.4s;
            -o-transition: all 0.4s;
            -moz-transition: all 0.4s;
        }

            a:focus {
               ");
                WriteLiteral(@" outline: none !important;
            }

            a:hover {
                text-decoration: none;
            }

        h1, h2, h3, h4, h5, h6 {
            margin: 0px;
        }

        p {
            margin: 0px;
        }

        ul, li {
            margin: 0px;
            list-style-type: none;
        }


        input {
            display: block;
            outline: none;
            border: none !important;
        }

        textarea {
            display: block;
            outline: none;
        }

            textarea:focus, input:focus {
                border-color: transparent !important;
            }

        button {
            outline: none !important;
            border: none;
            background: transparent;
        }

            button:hover {
                cursor: pointer;
            }

        iframe {
            border: none !important;
        }



        .limiter {
            width: 100%;
            marg");
                WriteLiteral(@"in: 0 auto;
        }

        .container-table100 {
            width: 100%;
            min-height: 100vh;
            background: #d1d1d1;
            display: -webkit-box;
            display: -webkit-flex;
            display: -moz-box;
            display: -ms-flexbox;
            display: flex;
            align-items: center;
            justify-content: center;
            flex-wrap: wrap;
            padding: 33px 30px;
        }

        .wrap-table100 {
            width: 1300px;
        }

        table {
            width: 100%;
            background-color: #fff;
        }

        th, td {
            font-weight: unset;
            padding-right: 10px;
        }

        .column100 {
            width: 130px;
            padding-left: 25px;
        }

            .column100.column1 {
                width: 265px;
                padding-left: 42px;
            }

        .row100.head th {
            padding-top: 24px;
            padding-bottom: 20");
                WriteLiteral(@"px;
        }

        .row100 td {
            padding-top: 18px;
            padding-bottom: 14px;
        }


        .table100.ver2 td {
            font-family: Montserrat-Regular;
            font-size: 14px;
            color: #808080;
            line-height: 1.4;
        }

        .table100.ver2 th {
            font-family: Montserrat-Medium;
            font-size: 12px;
            color: #fff;
            line-height: 1.4;
            text-transform: uppercase;
            background-color: #333333;
        }

        .table100.ver2 .row100:hover td {
            background-color: #83d160;
            color: #fff;
        }

        .table100.ver2 .hov-column-ver2 {
            background-color: #83d160;
            color: #fff;
        }

        .table100.ver2 .hov-column-head-ver2 {
            background-color: #484848 !important;
        }

        .table100.ver2 .row100 td:hover {
            background-color: #57b846;
            color: #fff;
     ");
                WriteLiteral(@"   }

        .table100.ver2 tbody tr:nth-child(even) {
            background-color: #eaf8e6;
        }

        .table100.ver2 td {
            font-family: Montserrat-Regular;
            font-size: 14px;
            color: #808080;
            line-height: 1.4;
        }

        .table100.ver2 th {
            font-family: Montserrat-Medium;
            font-size: 12px;
            color: #fff;
            line-height: 1.4;
            text-transform: uppercase;
            background-color: #333333;
        }

        .table100.ver2 .row100:hover td {
            background-color: #83d160;
            color: #fff;
        }

        .table100.ver2 .hov-column-ver2 {
            background-color: #83d160;
            color: #fff;
        }

        .table100.ver2 .hov-column-head-ver2 {
            background-color: #484848 !important;
        }

        .table100.ver2 .row100 td:hover {
            background-color: #57b846;
            color: #fff;
        }
    ");
                WriteLiteral("</style>\r\n    <!--link rel=\"stylesheet\" type=\"text/css\" href=\"css/main.css\"-->\r\n    <!--===============================================================================================-->\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e7237007ed18f4509d1bef1454a791efb10a3a989478", async() => {
                WriteLiteral(@"

    <div class=""limiter"">
        <div class=""container-table100"">
            <div class=""wrap-table100"">
                <div class=""table100 ver1 m-b-110"">
                </div>

                <div class=""table100 ver2 m-b-110"">
                    <table data-vertable=""ver2"">
                        <thead>
                            <tr class=""row100 head"">
                                <th class=""column100 column1"" data-column=""column1"">Customer Name/Order Num</th>
                                <th class=""column100 column2"" data-column=""column2"">Order Items</th>
                            </tr>
                        </thead>
");
                WriteLiteral("                                                <tbody>\r\n");
#nullable restore
#line 242 "/Users/shahdsherif/projects/backend/backend/Views/Home/AdminHome.cshtml"
                                                     for (int i = 0; i < Model.Count; i++)
                                                    {
                                                        var rowsize = Model[i].products.Count + 1;
                                                        string h = rowsize.ToString();

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                    <tr class=\"row100\">\r\n                                                        <td class=\"column100 column1\" data-column=\"column1\">");
#nullable restore
#line 247 "/Users/shahdsherif/projects/backend/backend/Views/Home/AdminHome.cshtml"
                                                                                                       Write(Model[i].cust.First_name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 247 "/Users/shahdsherif/projects/backend/backend/Views/Home/AdminHome.cshtml"
                                                                                                                                 Write(Model[i].cust.Last_name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" \'s Order ");
#nullable restore
#line 247 "/Users/shahdsherif/projects/backend/backend/Views/Home/AdminHome.cshtml"
                                                                                                                                                                   Write(Model[i].productorders.First().OrderNumber);

#line default
#line hidden
#nullable disable
                WriteLiteral(" <br /> Status: ");
#nullable restore
#line 247 "/Users/shahdsherif/projects/backend/backend/Views/Home/AdminHome.cshtml"
                                                                                                                                                                                                                              Write(Model[i].cust.Status);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\r\n\r\n");
#nullable restore
#line 249 "/Users/shahdsherif/projects/backend/backend/Views/Home/AdminHome.cshtml"
                                                         if (Model[i].products.Count != 0)
                                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                        <td class=\"column100 column2\" data-column=\"column1\">");
#nullable restore
#line 251 "/Users/shahdsherif/projects/backend/backend/Views/Home/AdminHome.cshtml"
                                                                                                       Write(Model[i].products.First().ProductName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n");
#nullable restore
#line 252 "/Users/shahdsherif/projects/backend/backend/Views/Home/AdminHome.cshtml"
                                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                    </tr>\r\n");
#nullable restore
#line 254 "/Users/shahdsherif/projects/backend/backend/Views/Home/AdminHome.cshtml"
                                                         if (Model[i].products.Count != 0)
                                                        {
                                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 256 "/Users/shahdsherif/projects/backend/backend/Views/Home/AdminHome.cshtml"
                                                         for (int j = 1; j < @Model[i].products.Count(); j++)
                                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                                <tr class=\"row100\">\r\n                                                                    <td class=\"column100 column1\" data-column=\"column1\">");
#nullable restore
#line 259 "/Users/shahdsherif/projects/backend/backend/Views/Home/AdminHome.cshtml"
                                                                                                                   Write(Model[i].products[j].ProductName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                                                </tr>\r\n");
#nullable restore
#line 261 "/Users/shahdsherif/projects/backend/backend/Views/Home/AdminHome.cshtml"

                                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 262 "/Users/shahdsherif/projects/backend/backend/Views/Home/AdminHome.cshtml"
                                                         
                                                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 263 "/Users/shahdsherif/projects/backend/backend/Views/Home/AdminHome.cshtml"
                                                             

                                                        } 

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                                </tbody>\r\n");
                WriteLiteral("                    </table>\r\n                </div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<productModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591