#pragma checksum "F:\MRBACKSLASH\lessonbuddy\lessonbuddy.mrbackslash.it\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d1761cb11039970f4513e75e6c601be5e21ed74"
// <auto-generated/>
#pragma warning disable 1591
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
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudThemeProvider>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\r\n");
            __builder.OpenComponent<MudBlazor.MudDialogProvider>(2);
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n");
            __builder.OpenComponent<MudBlazor.MudSnackbarProvider>(4);
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.OpenComponent<MudBlazor.MudLayout>(6);
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudAppBar>(8);
                __builder2.AddAttribute(9, "Elevation", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 8 "F:\MRBACKSLASH\lessonbuddy\lessonbuddy.mrbackslash.it\Shared\MainLayout.razor"
                          1

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudIconButton>(11);
                    __builder3.AddAttribute(12, "Icon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 9 "F:\MRBACKSLASH\lessonbuddy\lessonbuddy.mrbackslash.it\Shared\MainLayout.razor"
                              Icons.Material.Filled.Menu

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(13, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 9 "F:\MRBACKSLASH\lessonbuddy\lessonbuddy.mrbackslash.it\Shared\MainLayout.razor"
                                                                 Color.Inherit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(14, "Edge", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Edge>(
#nullable restore
#line 9 "F:\MRBACKSLASH\lessonbuddy\lessonbuddy.mrbackslash.it\Shared\MainLayout.razor"
                                                                                      Edge.Start

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(15, "OnClick", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "F:\MRBACKSLASH\lessonbuddy\lessonbuddy.mrbackslash.it\Shared\MainLayout.razor"
                                                                                                             (e) => DrawerToggle()

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(16, "\r\n\t\t");
                    __builder3.OpenComponent<MudBlazor.MudText>(17);
                    __builder3.AddAttribute(18, "Typo", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 10 "F:\MRBACKSLASH\lessonbuddy\lessonbuddy.mrbackslash.it\Shared\MainLayout.razor"
                       Typo.h5

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(19, "Class", "ml-3");
                    __builder3.AddAttribute(20, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(21, "Lesson Buddy");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(22, "\r\n\t\t");
                    __builder3.OpenComponent<MudBlazor.MudSpacer>(23);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(24, "\r\n\t\t");
                    __builder3.OpenComponent<MudBlazor.MudIconButton>(25);
                    __builder3.AddAttribute(26, "Icon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 12 "F:\MRBACKSLASH\lessonbuddy\lessonbuddy.mrbackslash.it\Shared\MainLayout.razor"
                              Icons.Material.Filled.MoreVert

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(27, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 12 "F:\MRBACKSLASH\lessonbuddy\lessonbuddy.mrbackslash.it\Shared\MainLayout.razor"
                                                                     Color.Inherit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(28, "Edge", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Edge>(
#nullable restore
#line 12 "F:\MRBACKSLASH\lessonbuddy\lessonbuddy.mrbackslash.it\Shared\MainLayout.razor"
                                                                                          Edge.End

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(29, "\r\n\t");
                __builder2.OpenComponent<MudBlazor.MudDrawer>(30);
                __builder2.AddAttribute(31, "ClipMode", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.DrawerClipMode>(
#nullable restore
#line 14 "F:\MRBACKSLASH\lessonbuddy\lessonbuddy.mrbackslash.it\Shared\MainLayout.razor"
                                                  DrawerClipMode.Always

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(32, "Elevation", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 14 "F:\MRBACKSLASH\lessonbuddy\lessonbuddy.mrbackslash.it\Shared\MainLayout.razor"
                                                                                    2

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(33, "Open", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 14 "F:\MRBACKSLASH\lessonbuddy\lessonbuddy.mrbackslash.it\Shared\MainLayout.razor"
                           _drawerOpen

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(34, "OpenChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _drawerOpen = __value, _drawerOpen))));
                __builder2.AddAttribute(35, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<lessonbuddy.mrbackslash.it.Shared.NavMenu>(36);
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(37, "\r\n\t");
                __builder2.OpenComponent<MudBlazor.MudMainContent>(38);
                __builder2.AddAttribute(39, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(40, "div");
                    __builder3.AddAttribute(41, "style", "padding: 20px;");
                    __builder3.AddAttribute(42, "b-69mee7tyqr");
#nullable restore
#line 19 "F:\MRBACKSLASH\lessonbuddy\lessonbuddy.mrbackslash.it\Shared\MainLayout.razor"
__builder3.AddContent(43, Body);

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "F:\MRBACKSLASH\lessonbuddy\lessonbuddy.mrbackslash.it\Shared\MainLayout.razor"
       
	bool _drawerOpen = true;

	void DrawerToggle()
	{
		_drawerOpen = !_drawerOpen;
	}

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
