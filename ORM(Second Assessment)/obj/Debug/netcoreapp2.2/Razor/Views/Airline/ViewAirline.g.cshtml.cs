#pragma checksum "C:\Users\Mian Abubakar\source\repos\MuhammadAbubakar786\ORM-CRUD-Second-Assesment-\ORM(Second Assessment)\Views\Airline\ViewAirline.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc4807b32a60f0cb08bf73149f0b5c3c0d603887"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Airline_ViewAirline), @"mvc.1.0.view", @"/Views/Airline/ViewAirline.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Airline/ViewAirline.cshtml", typeof(AspNetCore.Views_Airline_ViewAirline))]
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
#line 1 "C:\Users\Mian Abubakar\source\repos\MuhammadAbubakar786\ORM-CRUD-Second-Assesment-\ORM(Second Assessment)\Views\_ViewImports.cshtml"
using ORM_Second_Assessment_;

#line default
#line hidden
#line 2 "C:\Users\Mian Abubakar\source\repos\MuhammadAbubakar786\ORM-CRUD-Second-Assesment-\ORM(Second Assessment)\Views\_ViewImports.cshtml"
using ORM_Second_Assessment_.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc4807b32a60f0cb08bf73149f0b5c3c0d603887", @"/Views/Airline/ViewAirline.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04beace1ed2fc94a09302c2028eea640f81aa9b4", @"/Views/_ViewImports.cshtml")]
    public class Views_Airline_ViewAirline : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ORM_Second_Assessment_.Models.Airline>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Mian Abubakar\source\repos\MuhammadAbubakar786\ORM-CRUD-Second-Assesment-\ORM(Second Assessment)\Views\Airline\ViewAirline.cshtml"
  
    ViewData["Title"] = "ViewAirline";

#line default
#line hidden
            BeginContext(95, 134, true);
            WriteLiteral("\r\n<h1>ViewAirline</h1>\r\n\r\n<div>\r\n    <h4>Airline</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(230, 38, false);
#line 14 "C:\Users\Mian Abubakar\source\repos\MuhammadAbubakar786\ORM-CRUD-Second-Assesment-\ORM(Second Assessment)\Views\Airline\ViewAirline.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(268, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(332, 34, false);
#line 17 "C:\Users\Mian Abubakar\source\repos\MuhammadAbubakar786\ORM-CRUD-Second-Assesment-\ORM(Second Assessment)\Views\Airline\ViewAirline.cshtml"
       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(366, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(429, 40, false);
#line 20 "C:\Users\Mian Abubakar\source\repos\MuhammadAbubakar786\ORM-CRUD-Second-Assesment-\ORM(Second Assessment)\Views\Airline\ViewAirline.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(469, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(533, 36, false);
#line 23 "C:\Users\Mian Abubakar\source\repos\MuhammadAbubakar786\ORM-CRUD-Second-Assesment-\ORM(Second Assessment)\Views\Airline\ViewAirline.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(569, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(632, 43, false);
#line 26 "C:\Users\Mian Abubakar\source\repos\MuhammadAbubakar786\ORM-CRUD-Second-Assesment-\ORM(Second Assessment)\Views\Airline\ViewAirline.cshtml"
       Write(Html.DisplayNameFor(model => model.Country));

#line default
#line hidden
            EndContext();
            BeginContext(675, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(739, 39, false);
#line 29 "C:\Users\Mian Abubakar\source\repos\MuhammadAbubakar786\ORM-CRUD-Second-Assesment-\ORM(Second Assessment)\Views\Airline\ViewAirline.cshtml"
       Write(Html.DisplayFor(model => model.Country));

#line default
#line hidden
            EndContext();
            BeginContext(778, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(841, 42, false);
#line 32 "C:\Users\Mian Abubakar\source\repos\MuhammadAbubakar786\ORM-CRUD-Second-Assesment-\ORM(Second Assessment)\Views\Airline\ViewAirline.cshtml"
       Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(883, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(947, 38, false);
#line 35 "C:\Users\Mian Abubakar\source\repos\MuhammadAbubakar786\ORM-CRUD-Second-Assesment-\ORM(Second Assessment)\Views\Airline\ViewAirline.cshtml"
       Write(Html.DisplayFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(985, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1048, 45, false);
#line 38 "C:\Users\Mian Abubakar\source\repos\MuhammadAbubakar786\ORM-CRUD-Second-Assesment-\ORM(Second Assessment)\Views\Airline\ViewAirline.cshtml"
       Write(Html.DisplayNameFor(model => model.ShortCode));

#line default
#line hidden
            EndContext();
            BeginContext(1093, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1157, 41, false);
#line 41 "C:\Users\Mian Abubakar\source\repos\MuhammadAbubakar786\ORM-CRUD-Second-Assesment-\ORM(Second Assessment)\Views\Airline\ViewAirline.cshtml"
       Write(Html.DisplayFor(model => model.ShortCode));

#line default
#line hidden
            EndContext();
            BeginContext(1198, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1261, 40, false);
#line 44 "C:\Users\Mian Abubakar\source\repos\MuhammadAbubakar786\ORM-CRUD-Second-Assesment-\ORM(Second Assessment)\Views\Airline\ViewAirline.cshtml"
       Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
            EndContext();
            BeginContext(1301, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1365, 36, false);
#line 47 "C:\Users\Mian Abubakar\source\repos\MuhammadAbubakar786\ORM-CRUD-Second-Assesment-\ORM(Second Assessment)\Views\Airline\ViewAirline.cshtml"
       Write(Html.DisplayFor(model => model.Date));

#line default
#line hidden
            EndContext();
            BeginContext(1401, 49, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1450, "\"", 1494, 2);
            WriteAttributeValue("", 1457, "/airline/editairlinedata?id=", 1457, 28, true);
#line 52 "C:\Users\Mian Abubakar\source\repos\MuhammadAbubakar786\ORM-CRUD-Second-Assesment-\ORM(Second Assessment)\Views\Airline\ViewAirline.cshtml"
WriteAttributeValue("", 1485, Model.Id, 1485, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1495, 97, true);
            WriteLiteral(" class=\"btn btn-dark\">Edit</a>\r\n    <a href=\"/airline/listAirlinedata\">Back to List</a>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ORM_Second_Assessment_.Models.Airline> Html { get; private set; }
    }
}
#pragma warning restore 1591
