#pragma checksum "C:\Users\jwhud\source\repos\Embernet\Embernet\PortfolioLaunchPage\Pages\Calendar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa517faf63937a06b02e2d85f7fa76ae80f952f2"
// <auto-generated/>
#pragma warning disable 1591
namespace PortfolioLaunchPage.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\jwhud\source\repos\Embernet\Embernet\PortfolioLaunchPage\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jwhud\source\repos\Embernet\Embernet\PortfolioLaunchPage\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jwhud\source\repos\Embernet\Embernet\PortfolioLaunchPage\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\jwhud\source\repos\Embernet\Embernet\PortfolioLaunchPage\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\jwhud\source\repos\Embernet\Embernet\PortfolioLaunchPage\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\jwhud\source\repos\Embernet\Embernet\PortfolioLaunchPage\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\jwhud\source\repos\Embernet\Embernet\PortfolioLaunchPage\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\jwhud\source\repos\Embernet\Embernet\PortfolioLaunchPage\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\jwhud\source\repos\Embernet\Embernet\PortfolioLaunchPage\_Imports.razor"
using PortfolioLaunchPage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\jwhud\source\repos\Embernet\Embernet\PortfolioLaunchPage\_Imports.razor"
using PortfolioLaunchPage.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\jwhud\source\repos\Embernet\Embernet\PortfolioLaunchPage\_Imports.razor"
using PortfolioLaunchPage.Pages.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\jwhud\source\repos\Embernet\Embernet\PortfolioLaunchPage\_Imports.razor"
using ToDoListClassLibrary.DataAccess;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\jwhud\source\repos\Embernet\Embernet\PortfolioLaunchPage\_Imports.razor"
using ToDoListClassLibrary.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jwhud\source\repos\Embernet\Embernet\PortfolioLaunchPage\Pages\Calendar.razor"
using Syncfusion.Blazor.Schedule;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/calendar")]
    public partial class Calendar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Syncfusion.Blazor.Schedule.SfSchedule<AppointmentData>>(0);
            __builder.AddAttribute(1, "Height", "650px");
            __builder.AddAttribute(2, "SelectedDate", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.DateTime>(
#nullable restore
#line 4 "C:\Users\jwhud\source\repos\Embernet\Embernet\PortfolioLaunchPage\Pages\Calendar.razor"
                                                                         CurrentDate

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "SelectedDateChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.DateTime>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.DateTime>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => CurrentDate = __value, CurrentDate))));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __Blazor.PortfolioLaunchPage.Pages.Calendar.TypeInference.CreateScheduleEventSettings_0(__builder2, 5, 6, 
#nullable restore
#line 5 "C:\Users\jwhud\source\repos\Embernet\Embernet\PortfolioLaunchPage\Pages\Calendar.razor"
                                        DataSource

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(7, "\r\n    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Schedule.ScheduleViews>(8);
                __builder2.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Syncfusion.Blazor.Schedule.ScheduleView>(10);
                    __builder3.AddAttribute(11, "Option", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Schedule.View>(
#nullable restore
#line 7 "C:\Users\jwhud\source\repos\Embernet\Embernet\PortfolioLaunchPage\Pages\Calendar.razor"
                              View.Day

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(12, "\r\n        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Schedule.ScheduleView>(13);
                    __builder3.AddAttribute(14, "Option", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Schedule.View>(
#nullable restore
#line 8 "C:\Users\jwhud\source\repos\Embernet\Embernet\PortfolioLaunchPage\Pages\Calendar.razor"
                              View.Week

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(15, "\r\n        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Schedule.ScheduleView>(16);
                    __builder3.AddAttribute(17, "Option", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Schedule.View>(
#nullable restore
#line 9 "C:\Users\jwhud\source\repos\Embernet\Embernet\PortfolioLaunchPage\Pages\Calendar.razor"
                              View.WorkWeek

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(18, "\r\n        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Schedule.ScheduleView>(19);
                    __builder3.AddAttribute(20, "Option", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Schedule.View>(
#nullable restore
#line 10 "C:\Users\jwhud\source\repos\Embernet\Embernet\PortfolioLaunchPage\Pages\Calendar.razor"
                              View.Month

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(21, "\r\n        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Schedule.ScheduleView>(22);
                    __builder3.AddAttribute(23, "Option", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Schedule.View>(
#nullable restore
#line 11 "C:\Users\jwhud\source\repos\Embernet\Embernet\PortfolioLaunchPage\Pages\Calendar.razor"
                              View.Agenda

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "C:\Users\jwhud\source\repos\Embernet\Embernet\PortfolioLaunchPage\Pages\Calendar.razor"
      
    DateTime CurrentDate = new DateTime(2020, 2, 14);
    List<AppointmentData> DataSource = new List<AppointmentData>
    {

    };
    public class AppointmentData
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string Location { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Description { get; set; }
        public bool IsAllDay { get; set; }
        public string RecurrenceRule { get; set; }
        public string RecurrenceException { get; set; }
        public Nullable<int> RecurrenceID { get; set; }
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.PortfolioLaunchPage.Pages.Calendar
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateScheduleEventSettings_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TValue> __arg0)
        {
        __builder.OpenComponent<global::Syncfusion.Blazor.Schedule.ScheduleEventSettings<TValue>>(seq);
        __builder.AddAttribute(__seq0, "DataSource", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
