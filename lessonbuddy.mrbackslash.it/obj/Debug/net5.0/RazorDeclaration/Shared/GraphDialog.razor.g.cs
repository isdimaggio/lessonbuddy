// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace lessonbuddy.mrbackslash.it.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "F:\MRBACKSLASH\lessonbuddy\lessonbuddy.mrbackslash.it\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\MRBACKSLASH\lessonbuddy\lessonbuddy.mrbackslash.it\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\MRBACKSLASH\lessonbuddy\lessonbuddy.mrbackslash.it\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\MRBACKSLASH\lessonbuddy\lessonbuddy.mrbackslash.it\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\MRBACKSLASH\lessonbuddy\lessonbuddy.mrbackslash.it\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\MRBACKSLASH\lessonbuddy\lessonbuddy.mrbackslash.it\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\MRBACKSLASH\lessonbuddy\lessonbuddy.mrbackslash.it\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\MRBACKSLASH\lessonbuddy\lessonbuddy.mrbackslash.it\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "F:\MRBACKSLASH\lessonbuddy\lessonbuddy.mrbackslash.it\_Imports.razor"
using lessonbuddy.mrbackslash.it;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "F:\MRBACKSLASH\lessonbuddy\lessonbuddy.mrbackslash.it\_Imports.razor"
using lessonbuddy.mrbackslash.it.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "F:\MRBACKSLASH\lessonbuddy\lessonbuddy.mrbackslash.it\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "F:\MRBACKSLASH\lessonbuddy\lessonbuddy.mrbackslash.it\Shared\GraphDialog.razor"
using lessonbuddy.mrbackslash.it.Entities;

#line default
#line hidden
#nullable disable
    public partial class GraphDialog : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 54 "F:\MRBACKSLASH\lessonbuddy\lessonbuddy.mrbackslash.it\Shared\GraphDialog.razor"
       
    [CascadingParameter] MudDialogInstance MudDialog { get; set; }

    [Parameter] public Session Session { get; set; }    

    void Close() => MudDialog.Close(DialogResult.Ok(true));

    List<ChartSeries> series;
    string[] xAxisLabels;
    ChartOptions chartOptions;

    protected override void OnParametersSet()
    {
        if (Session != null)
        {
            series = new List<ChartSeries>()
            {
                new ChartSeries()
                {
                    Name = "Intensità connessione",
                    Data = Session.Payloads.OrderBy(p => p.EventTime).Select(p => (double)p.ConnectionStrength).ToArray()
                },
                new ChartSeries()
                {
                    Name = "Livello di attenzione",
                    Data = Session.Payloads.OrderBy(p => p.EventTime).Select(p => (double)p.AttentionLevel).ToArray()
                },
                new ChartSeries()
                {
                    Name = "Livello di meditazione",
                    Data = Session.Payloads.OrderBy(p => p.EventTime).Select(p => (double)p.MeditationLevel).ToArray()
                }
            };

            xAxisLabels = Session.Payloads.OrderBy(p => p.EventTime).Select(p => p.EventTime.ToString("HH:mm:00")).ToArray();
            string firstLabel = Session.Payloads.OrderBy(p => p.EventTime).First().EventTime.ToString("HH:mm:ss.fff");
            string lastLabel = Session.Payloads.OrderBy(p => p.EventTime).Last().EventTime.ToString("HH:mm:ss.fff");

            string currentLabel = "";

            for (int i=0; i<xAxisLabels.Length; i++)
            {
                if(xAxisLabels[i] == currentLabel)
                {
                    xAxisLabels[i] = "";         
                }
                else
                {
                    currentLabel = xAxisLabels[i];

                    if (i == 0)
                    {
                        xAxisLabels[i] = firstLabel;
                    }                                       
                }

                if (i == xAxisLabels.Length - 1)
                {
                    xAxisLabels[i] = lastLabel;
                }
            }

            chartOptions = new ChartOptions();
            //chartOptions.InterpolationOption = InterpolationOption;
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591