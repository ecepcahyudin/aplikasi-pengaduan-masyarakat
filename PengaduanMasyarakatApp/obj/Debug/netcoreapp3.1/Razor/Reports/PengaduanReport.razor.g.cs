#pragma checksum "E:\Ecep\Project\Projek C#\Blazor\PengaduanMasyarakatApp\PengaduanMasyarakatApp\Reports\PengaduanReport.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee93dda18a3a115e8f1e24eebd35fb3cfb715a12"
// <auto-generated/>
#pragma warning disable 1591
namespace PengaduanMasyarakatApp.Reports
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\Ecep\Project\Projek C#\Blazor\PengaduanMasyarakatApp\PengaduanMasyarakatApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Ecep\Project\Projek C#\Blazor\PengaduanMasyarakatApp\PengaduanMasyarakatApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Ecep\Project\Projek C#\Blazor\PengaduanMasyarakatApp\PengaduanMasyarakatApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Ecep\Project\Projek C#\Blazor\PengaduanMasyarakatApp\PengaduanMasyarakatApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Ecep\Project\Projek C#\Blazor\PengaduanMasyarakatApp\PengaduanMasyarakatApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Ecep\Project\Projek C#\Blazor\PengaduanMasyarakatApp\PengaduanMasyarakatApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Ecep\Project\Projek C#\Blazor\PengaduanMasyarakatApp\PengaduanMasyarakatApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Ecep\Project\Projek C#\Blazor\PengaduanMasyarakatApp\PengaduanMasyarakatApp\_Imports.razor"
using PengaduanMasyarakatApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Ecep\Project\Projek C#\Blazor\PengaduanMasyarakatApp\PengaduanMasyarakatApp\_Imports.razor"
using PengaduanMasyarakatApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\Ecep\Project\Projek C#\Blazor\PengaduanMasyarakatApp\PengaduanMasyarakatApp\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\Ecep\Project\Projek C#\Blazor\PengaduanMasyarakatApp\PengaduanMasyarakatApp\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Ecep\Project\Projek C#\Blazor\PengaduanMasyarakatApp\PengaduanMasyarakatApp\Reports\PengaduanReport.razor"
using PengaduanMasyarakatApp.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Ecep\Project\Projek C#\Blazor\PengaduanMasyarakatApp\PengaduanMasyarakatApp\Reports\PengaduanReport.razor"
using PengaduanMasyarakatApp.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Ecep\Project\Projek C#\Blazor\PengaduanMasyarakatApp\PengaduanMasyarakatApp\Reports\PengaduanReport.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(EmptyLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/pengaduanReport")]
    public partial class PengaduanReport : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Laporan Pengaduan Masyarakat</h1>\r\n<br>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
            __builder.AddAttribute(3, "style", "font-size:25px");
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-md-12");
            __builder.AddMarkupContent(7, "\r\n\r\n        ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "row");
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "col-md-2");
            __builder.AddAttribute(13, "style", "width:300px");
            __builder.OpenComponent<Radzen.Blazor.RadzenLabel>(14);
            __builder.AddAttribute(15, "Text", "Tanggal");
            __builder.AddAttribute(16, "Style", "font-weight:bold");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n            :\r\n            ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "col-md-9");
            __builder.OpenComponent<Radzen.Blazor.RadzenLabel>(20);
            __builder.AddAttribute(21, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "E:\Ecep\Project\Projek C#\Blazor\PengaduanMasyarakatApp\PengaduanMasyarakatApp\Reports\PengaduanReport.razor"
                                                      data.TglPengaduan.ToString("dd MMMM yyyy HH:mm", CultureInfo.InvariantCulture)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n\r\n        ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "row");
            __builder.AddMarkupContent(26, "\r\n            ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "col-md-2");
            __builder.AddAttribute(29, "style", "width:300px");
            __builder.OpenComponent<Radzen.Blazor.RadzenLabel>(30);
            __builder.AddAttribute(31, "Text", "Judul");
            __builder.AddAttribute(32, "Style", "font-weight:bold");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n            :\r\n            ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "col-md-9");
            __builder.OpenComponent<Radzen.Blazor.RadzenLabel>(36);
            __builder.AddAttribute(37, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 27 "E:\Ecep\Project\Projek C#\Blazor\PengaduanMasyarakatApp\PengaduanMasyarakatApp\Reports\PengaduanReport.razor"
                                                      data.JudulLaporan

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n\r\n        ");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "row");
            __builder.AddMarkupContent(42, "\r\n            ");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "col-md-2");
            __builder.AddAttribute(45, "style", "width:300px");
            __builder.OpenComponent<Radzen.Blazor.RadzenLabel>(46);
            __builder.AddAttribute(47, "Text", "NIK");
            __builder.AddAttribute(48, "Style", "font-weight:bold");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n            :\r\n            ");
            __builder.OpenElement(50, "div");
            __builder.AddAttribute(51, "class", "col-md-9");
            __builder.OpenComponent<Radzen.Blazor.RadzenLabel>(52);
            __builder.AddAttribute(53, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 35 "E:\Ecep\Project\Projek C#\Blazor\PengaduanMasyarakatApp\PengaduanMasyarakatApp\Reports\PengaduanReport.razor"
                                                      data.NIK

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n\r\n        ");
            __builder.OpenElement(56, "div");
            __builder.AddAttribute(57, "class", "row");
            __builder.AddMarkupContent(58, "\r\n            ");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "class", "col-md-2");
            __builder.AddAttribute(61, "style", "width:300px");
            __builder.OpenComponent<Radzen.Blazor.RadzenLabel>(62);
            __builder.AddAttribute(63, "Text", "Pengaduan");
            __builder.AddAttribute(64, "Style", "font-weight:bold");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n            :\r\n            ");
            __builder.OpenElement(66, "div");
            __builder.AddAttribute(67, "class", "col-md-8");
            __builder.OpenComponent<Radzen.Blazor.RadzenLabel>(68);
            __builder.AddAttribute(69, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 43 "E:\Ecep\Project\Projek C#\Blazor\PengaduanMasyarakatApp\PengaduanMasyarakatApp\Reports\PengaduanReport.razor"
                                                      data.Laporan

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n\r\n\r\n        ");
            __builder.OpenElement(72, "div");
            __builder.AddAttribute(73, "class", "row");
            __builder.AddMarkupContent(74, "\r\n            ");
            __builder.OpenElement(75, "div");
            __builder.AddAttribute(76, "class", "col-md-2");
            __builder.AddAttribute(77, "style", "width:300px");
            __builder.OpenComponent<Radzen.Blazor.RadzenLabel>(78);
            __builder.AddAttribute(79, "Text", "Foto");
            __builder.AddAttribute(80, "Style", "font-weight:bold");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n            :\r\n            ");
            __builder.OpenElement(82, "div");
            __builder.AddAttribute(83, "class", "col-md-9");
            __builder.OpenComponent<Radzen.Blazor.RadzenImage>(84);
            __builder.AddAttribute(85, "Path", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 52 "E:\Ecep\Project\Projek C#\Blazor\PengaduanMasyarakatApp\PengaduanMasyarakatApp\Reports\PengaduanReport.razor"
                                                      data.Foto

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(86, "Style", "width:250px;height:250px;margin-top:10px");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n\r\n        ");
            __builder.OpenElement(89, "div");
            __builder.AddAttribute(90, "class", "row");
            __builder.AddAttribute(91, "style", "margin-top:5px");
            __builder.AddMarkupContent(92, "\r\n            ");
            __builder.OpenElement(93, "div");
            __builder.AddAttribute(94, "class", "col-md-2");
            __builder.AddAttribute(95, "style", "width: 300px");
            __builder.OpenComponent<Radzen.Blazor.RadzenLabel>(96);
            __builder.AddAttribute(97, "Text", "Tgl Tanggapan");
            __builder.AddAttribute(98, "Style", "font-weight:bold");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n            :\r\n            ");
            __builder.OpenElement(100, "div");
            __builder.AddAttribute(101, "class", "col-md-9");
            __builder.AddAttribute(102, "style", "width: 800px");
            __builder.OpenComponent<Radzen.Blazor.RadzenLabel>(103);
            __builder.AddAttribute(104, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 60 "E:\Ecep\Project\Projek C#\Blazor\PengaduanMasyarakatApp\PengaduanMasyarakatApp\Reports\PengaduanReport.razor"
                                                                           data.TglTanggapan?.ToString("dd MMMM yyyy HH:mm", CultureInfo.InvariantCulture)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r\n\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n\r\n        ");
            __builder.OpenElement(107, "div");
            __builder.AddAttribute(108, "class", "row");
            __builder.AddAttribute(109, "style", "margin-top:5px");
            __builder.AddMarkupContent(110, "\r\n            ");
            __builder.OpenElement(111, "div");
            __builder.AddAttribute(112, "class", "col-md-2");
            __builder.AddAttribute(113, "style", "width: 300px");
            __builder.OpenComponent<Radzen.Blazor.RadzenLabel>(114);
            __builder.AddAttribute(115, "Text", "Tanggapan");
            __builder.AddAttribute(116, "Style", "font-weight:bold");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(117, "\r\n            :\r\n            ");
            __builder.OpenElement(118, "div");
            __builder.AddAttribute(119, "class", "col-md-9");
            __builder.AddAttribute(120, "style", "width: 800px");
            __builder.OpenComponent<Radzen.Blazor.RadzenLabel>(121);
            __builder.AddAttribute(122, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 68 "E:\Ecep\Project\Projek C#\Blazor\PengaduanMasyarakatApp\PengaduanMasyarakatApp\Reports\PengaduanReport.razor"
                                                                           data.Tanggapan

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(123, "\r\n\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(124, "\r\n\r\n        ");
            __builder.OpenElement(125, "div");
            __builder.AddAttribute(126, "class", "row");
            __builder.AddAttribute(127, "style", "margin-top:5px;");
            __builder.AddMarkupContent(128, "\r\n            ");
            __builder.OpenElement(129, "div");
            __builder.AddAttribute(130, "class", "col-md-2");
            __builder.AddAttribute(131, "style", "width:300px");
            __builder.OpenComponent<Radzen.Blazor.RadzenLabel>(132);
            __builder.AddAttribute(133, "Text", "Status");
            __builder.AddAttribute(134, "Style", "font-weight:bold");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(135, "\r\n            :\r\n            ");
            __builder.OpenElement(136, "div");
            __builder.AddAttribute(137, "class", "col-md-9");
            __builder.OpenComponent<Radzen.Blazor.RadzenLabel>(138);
            __builder.AddAttribute(139, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 76 "E:\Ecep\Project\Projek C#\Blazor\PengaduanMasyarakatApp\PengaduanMasyarakatApp\Reports\PengaduanReport.razor"
                                                      data.Status

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(140, "\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(141, "\r\n\r\n        <br>\r\n\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(142, "\r\n\r\n\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 90 "E:\Ecep\Project\Projek C#\Blazor\PengaduanMasyarakatApp\PengaduanMasyarakatApp\Reports\PengaduanReport.razor"
       

    public PengaduanViewModel data { get; set; }

    protected override void OnInitialized()
    {
        data = DataReport.dataReportPengaduan;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WeatherForecastService ForecastService { get; set; }
    }
}
#pragma warning restore 1591
