#pragma checksum "E:\Ecep\Project\Projek C#\Blazor\PengaduanMasyarakatApp\PengaduanMasyarakatApp\Reports\RekapPengaduanReport.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b3eadcbd47c189d6af848ea8adbc8ae92d89e193"
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
#line 4 "E:\Ecep\Project\Projek C#\Blazor\PengaduanMasyarakatApp\PengaduanMasyarakatApp\Reports\RekapPengaduanReport.razor"
using PengaduanMasyarakatApp.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Ecep\Project\Projek C#\Blazor\PengaduanMasyarakatApp\PengaduanMasyarakatApp\Reports\RekapPengaduanReport.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(EmptyLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/rekapPengaduanReport")]
    public partial class RekapPengaduanReport : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Rekap Pengaduan Masyarakat</h1>\r\n<br>\r\n\r\n");
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "table");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.AddMarkupContent(4, "<thead>\r\n        <tr>\r\n            <th>TglPengaduan</th>\r\n            <th>Judul</th>\r\n            <th>Status</th>\r\n            <th>TglTanggapan</th>\r\n        </tr>\r\n    </thead>\r\n    ");
            __builder.OpenElement(5, "tbody");
            __builder.AddMarkupContent(6, "\r\n");
#nullable restore
#line 20 "E:\Ecep\Project\Projek C#\Blazor\PengaduanMasyarakatApp\PengaduanMasyarakatApp\Reports\RekapPengaduanReport.razor"
         foreach (var data in datas)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "            ");
            __builder.OpenElement(8, "tr");
            __builder.AddMarkupContent(9, "\r\n                ");
            __builder.OpenElement(10, "td");
            __builder.AddContent(11, 
#nullable restore
#line 23 "E:\Ecep\Project\Projek C#\Blazor\PengaduanMasyarakatApp\PengaduanMasyarakatApp\Reports\RekapPengaduanReport.razor"
                     data.TglPengaduan.ToString("yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 24 "E:\Ecep\Project\Projek C#\Blazor\PengaduanMasyarakatApp\PengaduanMasyarakatApp\Reports\RekapPengaduanReport.razor"
                     data.JudulLaporan

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 25 "E:\Ecep\Project\Projek C#\Blazor\PengaduanMasyarakatApp\PengaduanMasyarakatApp\Reports\RekapPengaduanReport.razor"
                     data.Status

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 26 "E:\Ecep\Project\Projek C#\Blazor\PengaduanMasyarakatApp\PengaduanMasyarakatApp\Reports\RekapPengaduanReport.razor"
                     data.TglTanggapan

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n");
#nullable restore
#line 28 "E:\Ecep\Project\Projek C#\Blazor\PengaduanMasyarakatApp\PengaduanMasyarakatApp\Reports\RekapPengaduanReport.razor"
            jmlData = jmlData + 1;
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(23, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n\r\n");
            __builder.OpenElement(26, "h3");
            __builder.AddContent(27, "Jumlah data: ");
            __builder.AddContent(28, 
#nullable restore
#line 33 "E:\Ecep\Project\Projek C#\Blazor\PengaduanMasyarakatApp\PengaduanMasyarakatApp\Reports\RekapPengaduanReport.razor"
                  jmlData

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "E:\Ecep\Project\Projek C#\Blazor\PengaduanMasyarakatApp\PengaduanMasyarakatApp\Reports\RekapPengaduanReport.razor"
       

    public List<PengaduanViewModel> datas { get; set; }

    int jmlData = 0;
    protected override void OnInitialized()
    {
        datas = DataReport.dataReportRekapPengaduan;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
