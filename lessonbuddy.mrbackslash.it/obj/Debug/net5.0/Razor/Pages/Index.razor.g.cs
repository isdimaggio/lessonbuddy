#pragma checksum "F:\MRBACKSLASH\lessonbuddy\lessonbuddy.mrbackslash.it\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e6937834eab54a59b6c63b2a24e5331c5edce21c"
// <auto-generated/>
#pragma warning disable 1591
namespace lessonbuddy.mrbackslash.it.Pages
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
#line 3 "F:\MRBACKSLASH\lessonbuddy\lessonbuddy.mrbackslash.it\Pages\Index.razor"
using lessonbuddy.mrbackslash.it.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\MRBACKSLASH\lessonbuddy\lessonbuddy.mrbackslash.it\Pages\Index.razor"
using lessonbuddy.mrbackslash.it.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "F:\MRBACKSLASH\lessonbuddy\lessonbuddy.mrbackslash.it\Pages\Index.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 11 "F:\MRBACKSLASH\lessonbuddy\lessonbuddy.mrbackslash.it\Pages\Index.razor"
 if (authenticationState.User.IsInRole("Administrators"))
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<h1>Cruscotto amministratore</h1>");
#nullable restore
#line 14 "F:\MRBACKSLASH\lessonbuddy\lessonbuddy.mrbackslash.it\Pages\Index.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<h1>Cruscotto utente</h1>");
#nullable restore
#line 18 "F:\MRBACKSLASH\lessonbuddy\lessonbuddy.mrbackslash.it\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<style>\r\n\r\n    .mud-table-container {\r\n        height: calc(100vh - 350px);\r\n    }\r\n\r\n</style>\r\n\r\n<br>\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputFile>(3);
            __builder.AddAttribute(4, "id", "fileInput");
            __builder.AddAttribute(5, "OnChange", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>(this, 
#nullable restore
#line 29 "F:\MRBACKSLASH\lessonbuddy\lessonbuddy.mrbackslash.it\Pages\Index.razor"
                                    UploadFiles

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(6, "hidden", true);
            __builder.AddAttribute(7, "accept", ".lbd");
            __builder.CloseComponent();
            __builder.AddMarkupContent(8, "\r\n");
            __builder.OpenComponent<MudBlazor.MudButton>(9);
            __builder.AddAttribute(10, "HtmlTag", "label");
            __builder.AddAttribute(11, "Variant", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 31 "F:\MRBACKSLASH\lessonbuddy\lessonbuddy.mrbackslash.it\Pages\Index.razor"
                    Variant.Filled

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 32 "F:\MRBACKSLASH\lessonbuddy\lessonbuddy.mrbackslash.it\Pages\Index.razor"
                  Color.Secondary

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "StartIcon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 33 "F:\MRBACKSLASH\lessonbuddy\lessonbuddy.mrbackslash.it\Pages\Index.razor"
                       Icons.Filled.CloudUpload

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "for", "fileInput");
            __builder.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(16, "\r\n    Carica una nuova sessione\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(17, "\r\n<br>\r\n<br>\r\n\r\n");
            __Blazor.lessonbuddy.mrbackslash.it.Pages.Index.TypeInference.CreateMudTable_0(__builder, 18, 19, 
#nullable restore
#line 41 "F:\MRBACKSLASH\lessonbuddy\lessonbuddy.mrbackslash.it\Pages\Index.razor"
            sessions

#line default
#line hidden
#nullable disable
            , 20, 
#nullable restore
#line 42 "F:\MRBACKSLASH\lessonbuddy\lessonbuddy.mrbackslash.it\Pages\Index.razor"
           false

#line default
#line hidden
#nullable disable
            , 21, 
#nullable restore
#line 43 "F:\MRBACKSLASH\lessonbuddy\lessonbuddy.mrbackslash.it\Pages\Index.razor"
           true

#line default
#line hidden
#nullable disable
            , 22, 
#nullable restore
#line 44 "F:\MRBACKSLASH\lessonbuddy\lessonbuddy.mrbackslash.it\Pages\Index.razor"
              false

#line default
#line hidden
#nullable disable
            , 23, 
#nullable restore
#line 45 "F:\MRBACKSLASH\lessonbuddy\lessonbuddy.mrbackslash.it\Pages\Index.razor"
                   true

#line default
#line hidden
#nullable disable
            , 24, 
#nullable restore
#line 46 "F:\MRBACKSLASH\lessonbuddy\lessonbuddy.mrbackslash.it\Pages\Index.razor"
            new Func<Session,bool>(FilterFunc)

#line default
#line hidden
#nullable disable
            , 25, "Ordina per", 26, "Salva", 27, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 50 "F:\MRBACKSLASH\lessonbuddy\lessonbuddy.mrbackslash.it\Pages\Index.razor"
                         () => SaveSession()

#line default
#line hidden
#nullable disable
            ), 28, 
#nullable restore
#line 51 "F:\MRBACKSLASH\lessonbuddy\lessonbuddy.mrbackslash.it\Pages\Index.razor"
                    BackupItem

#line default
#line hidden
#nullable disable
            , 29, 
#nullable restore
#line 52 "F:\MRBACKSLASH\lessonbuddy\lessonbuddy.mrbackslash.it\Pages\Index.razor"
                   ResetItemToOriginalValues

#line default
#line hidden
#nullable disable
            , 30, 
#nullable restore
#line 47 "F:\MRBACKSLASH\lessonbuddy\lessonbuddy.mrbackslash.it\Pages\Index.razor"
                        selectedItem

#line default
#line hidden
#nullable disable
            , 31, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => selectedItem = __value, selectedItem)), 32, (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudText>(33);
                __builder2.AddAttribute(34, "Typo", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 56 "F:\MRBACKSLASH\lessonbuddy\lessonbuddy.mrbackslash.it\Pages\Index.razor"
                       Typo.h6

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(35, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(36, "Elenco sessioni caricate");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(37, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudSpacer>(38);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(39, "\r\n        ");
                __Blazor.lessonbuddy.mrbackslash.it.Pages.Index.TypeInference.CreateMudTextField_1(__builder2, 40, 41, "Search", 42, 
#nullable restore
#line 58 "F:\MRBACKSLASH\lessonbuddy\lessonbuddy.mrbackslash.it\Pages\Index.razor"
                                                                                 Adornment.Start

#line default
#line hidden
#nullable disable
                , 43, 
#nullable restore
#line 58 "F:\MRBACKSLASH\lessonbuddy\lessonbuddy.mrbackslash.it\Pages\Index.razor"
                                                                                                                  Icons.Material.Filled.Search

#line default
#line hidden
#nullable disable
                , 44, 
#nullable restore
#line 58 "F:\MRBACKSLASH\lessonbuddy\lessonbuddy.mrbackslash.it\Pages\Index.razor"
                                                                                                                                                          Size.Medium

#line default
#line hidden
#nullable disable
                , 45, "mt-0", 46, 
#nullable restore
#line 58 "F:\MRBACKSLASH\lessonbuddy\lessonbuddy.mrbackslash.it\Pages\Index.razor"
                                   searchString

#line default
#line hidden
#nullable disable
                , 47, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => searchString = __value, searchString)));
            }
            , 48, (__builder2) => {
#nullable restore
#line 63 "F:\MRBACKSLASH\lessonbuddy\lessonbuddy.mrbackslash.it\Pages\Index.razor"
         if(isAdmin)
        {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(49, "<col style=\"width:20%;\">\r\n            <col style=\"width:20%;\">\r\n            <col style=\"width:15%;\">\r\n            <col style=\"width:20%\">\r\n            <col style=\"width:11%\">\r\n            <col style=\"width:14%\">");
#nullable restore
#line 71 "F:\MRBACKSLASH\lessonbuddy\lessonbuddy.mrbackslash.it\Pages\Index.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(50, "<col style=\"width:25%;\">\r\n            <col style=\"width:20%;\">\r\n            <col style=\"width:25%\">\r\n            <col style=\"width:16%\">\r\n            <col style=\"width:14%\">");
#nullable restore
#line 79 "F:\MRBACKSLASH\lessonbuddy\lessonbuddy.mrbackslash.it\Pages\Index.razor"
        }

#line default
#line hidden
#nullable disable
            }
            , 51, (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudTh>(52);
                __builder2.AddAttribute(53, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(54, "Identificativo");
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 86 "F:\MRBACKSLASH\lessonbuddy\lessonbuddy.mrbackslash.it\Pages\Index.razor"
         if(isAdmin)
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<MudBlazor.MudTh>(55);
                __builder2.AddAttribute(56, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __Blazor.lessonbuddy.mrbackslash.it.Pages.Index.TypeInference.CreateMudTableSortLabel_2(__builder3, 57, 58, 
#nullable restore
#line 88 "F:\MRBACKSLASH\lessonbuddy\lessonbuddy.mrbackslash.it\Pages\Index.razor"
                                              new Func<Session, object>(x=>x.Username)

#line default
#line hidden
#nullable disable
                    , 59, (__builder4) => {
                        __builder4.AddContent(60, "Nome utente");
                    }
                    );
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 89 "F:\MRBACKSLASH\lessonbuddy\lessonbuddy.mrbackslash.it\Pages\Index.razor"
        }

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<MudBlazor.MudTh>(61);
                __builder2.AddAttribute(62, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __Blazor.lessonbuddy.mrbackslash.it.Pages.Index.TypeInference.CreateMudTableSortLabel_3(__builder3, 63, 64, 
#nullable restore
#line 91 "F:\MRBACKSLASH\lessonbuddy\lessonbuddy.mrbackslash.it\Pages\Index.razor"
                                          new Func<Session, object>(x=>x.Subject)

#line default
#line hidden
#nullable disable
                    , 65, (__builder4) => {
                        __builder4.AddContent(66, "Soggetto");
                    }
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(67, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(68);
                __builder2.AddAttribute(69, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __Blazor.lessonbuddy.mrbackslash.it.Pages.Index.TypeInference.CreateMudTableSortLabel_4(__builder3, 70, 71, 
#nullable restore
#line 92 "F:\MRBACKSLASH\lessonbuddy\lessonbuddy.mrbackslash.it\Pages\Index.razor"
                                          new Func<Session, object>(x=>x.Location)

#line default
#line hidden
#nullable disable
                    , 72, (__builder4) => {
                        __builder4.AddContent(73, "Luogo");
                    }
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(74, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(75);
                __builder2.AddAttribute(76, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __Blazor.lessonbuddy.mrbackslash.it.Pages.Index.TypeInference.CreateMudTableSortLabel_5(__builder3, 77, 78, 
#nullable restore
#line 93 "F:\MRBACKSLASH\lessonbuddy\lessonbuddy.mrbackslash.it\Pages\Index.razor"
                                                    SortDirection.Descending

#line default
#line hidden
#nullable disable
                    , 79, 
#nullable restore
#line 93 "F:\MRBACKSLASH\lessonbuddy\lessonbuddy.mrbackslash.it\Pages\Index.razor"
                                                                                      new Func<Session, object>(x=>x.UploadDateTime)

#line default
#line hidden
#nullable disable
                    , 80, (__builder4) => {
                        __builder4.AddContent(81, "Data caricamento");
                    }
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(82, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(83);
                __builder2.CloseComponent();
            }
            , 84, (context) => (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudTd>(85);
                __builder2.AddAttribute(86, "DataLabel", "Identificativo");
                __builder2.AddAttribute(87, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 98 "F:\MRBACKSLASH\lessonbuddy\lessonbuddy.mrbackslash.it\Pages\Index.razor"
__builder3.AddContent(88, context.Guidsession);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 100 "F:\MRBACKSLASH\lessonbuddy\lessonbuddy.mrbackslash.it\Pages\Index.razor"
         if(isAdmin)
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<MudBlazor.MudTd>(89);
                __builder2.AddAttribute(90, "DataLabel", "Nome utente");
                __builder2.AddAttribute(91, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 102 "F:\MRBACKSLASH\lessonbuddy\lessonbuddy.mrbackslash.it\Pages\Index.razor"
__builder3.AddContent(92, context.Username);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 103 "F:\MRBACKSLASH\lessonbuddy\lessonbuddy.mrbackslash.it\Pages\Index.razor"
        }

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<MudBlazor.MudTd>(93);
                __builder2.AddAttribute(94, "DataLabel", "Soggetto");
                __builder2.AddAttribute(95, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 105 "F:\MRBACKSLASH\lessonbuddy\lessonbuddy.mrbackslash.it\Pages\Index.razor"
__builder3.AddContent(96, context.Subject);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(97, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(98);
                __builder2.AddAttribute(99, "DataLabel", "Luogo");
                __builder2.AddAttribute(100, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 106 "F:\MRBACKSLASH\lessonbuddy\lessonbuddy.mrbackslash.it\Pages\Index.razor"
__builder3.AddContent(101, context.Location);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(102, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(103);
                __builder2.AddAttribute(104, "DataLabel", "Data");
                __builder2.AddAttribute(105, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 107 "F:\MRBACKSLASH\lessonbuddy\lessonbuddy.mrbackslash.it\Pages\Index.razor"
__builder3.AddContent(106, context.UploadDateTime.Value.ToString("dd/MM/yyyy HH:mm:ss"));

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(107, "\r\n\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(108);
                __builder2.AddAttribute(109, "DataLabel", "");
                __builder2.AddAttribute(110, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudFab>(111);
                    __builder3.AddAttribute(112, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 110 "F:\MRBACKSLASH\lessonbuddy\lessonbuddy.mrbackslash.it\Pages\Index.razor"
                           Color.Tertiary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(113, "Icon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 110 "F:\MRBACKSLASH\lessonbuddy\lessonbuddy.mrbackslash.it\Pages\Index.razor"
                                                  Icons.Material.Filled.AutoGraph

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(114, "OnClick", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 110 "F:\MRBACKSLASH\lessonbuddy\lessonbuddy.mrbackslash.it\Pages\Index.razor"
                                                                                              () => OpenGraphDialog(context)

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            , 115, (context) => (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudTd>(116);
                __builder2.AddAttribute(117, "DataLabel", "Identificativo");
                __builder2.AddAttribute(118, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 115 "F:\MRBACKSLASH\lessonbuddy\lessonbuddy.mrbackslash.it\Pages\Index.razor"
__builder3.AddContent(119, context.Guidsession);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 117 "F:\MRBACKSLASH\lessonbuddy\lessonbuddy.mrbackslash.it\Pages\Index.razor"
         if (isAdmin)
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<MudBlazor.MudTd>(120);
                __builder2.AddAttribute(121, "DataLabel", "Nome utente");
                __builder2.AddAttribute(122, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __Blazor.lessonbuddy.mrbackslash.it.Pages.Index.TypeInference.CreateMudTextField_6(__builder3, 123, 124, true, 125, 
#nullable restore
#line 120 "F:\MRBACKSLASH\lessonbuddy\lessonbuddy.mrbackslash.it\Pages\Index.razor"
                                            context.Username

#line default
#line hidden
#nullable disable
                    , 126, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => context.Username = __value, context.Username)));
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 122 "F:\MRBACKSLASH\lessonbuddy\lessonbuddy.mrbackslash.it\Pages\Index.razor"
        }

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<MudBlazor.MudTd>(127);
                __builder2.AddAttribute(128, "DataLabel", "Soggetto");
                __builder2.AddAttribute(129, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __Blazor.lessonbuddy.mrbackslash.it.Pages.Index.TypeInference.CreateMudTextField_7(__builder3, 130, 131, true, 132, 
#nullable restore
#line 125 "F:\MRBACKSLASH\lessonbuddy\lessonbuddy.mrbackslash.it\Pages\Index.razor"
                                        context.Subject

#line default
#line hidden
#nullable disable
                    , 133, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => context.Subject = __value, context.Subject)));
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(134, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(135);
                __builder2.AddAttribute(136, "DataLabel", "Luogo");
                __builder2.AddAttribute(137, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __Blazor.lessonbuddy.mrbackslash.it.Pages.Index.TypeInference.CreateMudTextField_8(__builder3, 138, 139, true, 140, 
#nullable restore
#line 128 "F:\MRBACKSLASH\lessonbuddy\lessonbuddy.mrbackslash.it\Pages\Index.razor"
                                        context.Location

#line default
#line hidden
#nullable disable
                    , 141, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => context.Location = __value, context.Location)));
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(142, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(143);
                __builder2.AddAttribute(144, "DataLabel", "Data caricamento");
                __builder2.AddAttribute(145, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 130 "F:\MRBACKSLASH\lessonbuddy\lessonbuddy.mrbackslash.it\Pages\Index.razor"
__builder3.AddContent(146, context.UploadDateTime.Value.ToString("dd/MM/yyyy HH:mm:ss"));

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
            }
            , 147, (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudTablePager>(148);
                __builder2.CloseComponent();
            }
            , 149, (__value) => {
#nullable restore
#line 53 "F:\MRBACKSLASH\lessonbuddy\lessonbuddy.mrbackslash.it\Pages\Index.razor"
           sessionDataTable = __value;

#line default
#line hidden
#nullable disable
            }
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 137 "F:\MRBACKSLASH\lessonbuddy\lessonbuddy.mrbackslash.it\Pages\Index.razor"
       

    [CascadingParameter]
	private Task<AuthenticationState> AuthenticationStateTask { get; set; }
	private AuthenticationState authenticationState;

    private MudTable<Session> sessionDataTable;

    private List<Session> sessions;
    private string searchString = "";

    private Session selectedItem = null;
    private Session elementBeforeEdit;

    private DialogOptions graphDialogOptions;
    private DialogParameters graphDialogParameters;

    private bool isAdmin = false;

    private void OpenGraphDialog(Session session)
    {
        graphDialogParameters = new DialogParameters();
        graphDialogParameters.Add("Session", session);        

        dialogService.Show<GraphDialog>("", graphDialogParameters, graphDialogOptions);
    }

    protected void LoadSessions()
    {
        if (!isAdmin)
		{
			sessions = sessionService.GetAll().Where(s => s.Username == authenticationState.User.Identity.Name).ToList();
		}
		else
		{
			sessions = sessionService.GetAll();
		}
    }

    protected override async Task OnInitializedAsync()
	{
		authenticationState = await AuthenticationStateTask;

		if (authenticationState.User.Identity.IsAuthenticated)
		{
			if (authenticationState.User.IsInRole("Administrators"))
			{
				isAdmin = true;
			}
        }

        LoadSessions();

        graphDialogOptions = new DialogOptions
        {
            FullScreen = true,
            CloseButton = true,
            DisableBackdropClick = true,
            NoHeader = true,
            Position = DialogPosition.Center            
        };		
	}	

    private void BackupItem(object element)
    {
        elementBeforeEdit = new()
        {            
            Username = ((Session)element).Username,
            Subject = ((Session)element).Subject,
            Location = ((Session)element).Location,
            UploadDateTime = ((Session)element).UploadDateTime
        };
    }

    private void ResetItemToOriginalValues(object element)
    {
        ((Session)element).Username = elementBeforeEdit.Username;
        ((Session)element).Subject = elementBeforeEdit.Subject;
        ((Session)element).Location = elementBeforeEdit.Location;
        ((Session)element).UploadDateTime = elementBeforeEdit.UploadDateTime;
    }

	private bool FilterFunc(Session session)
    {
        if (string.IsNullOrWhiteSpace(searchString))
            return true;
        if (session.Username.Contains(searchString, StringComparison.OrdinalIgnoreCase))
            return true;
        if (session.Subject.Contains(searchString, StringComparison.OrdinalIgnoreCase))
            return true;
        if (session.Location.Contains(searchString, StringComparison.OrdinalIgnoreCase))
            return true;
        return false;
    }

    private void SaveSession()
    {
        sessionService.Update(selectedItem);
    }

    IList<IBrowserFile> files = new List<IBrowserFile>();
    private async Task UploadFiles(InputFileChangeEventArgs e)
    {
        foreach (var file in e.GetMultipleFiles())
        {
            files.Add(file);
        }

        string result = "";

        foreach (var file in files)
        {
            result = await sessionService.Upload(file, authenticationState.User.Identity.Name);
        }

        if(result == "Sessione caricata correttamente")
        {
            Snackbar.Add(result, Severity.Success);
        }
        else
        {
            Snackbar.Add(result, Severity.Error);
        }

        LoadSessions();

        //await sessionDataTable.ReloadServerData();

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SessionsService sessionService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDialogService dialogService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISnackbar Snackbar { get; set; }
    }
}
namespace __Blazor.lessonbuddy.mrbackslash.it.Pages.Index
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudTable_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<T> __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, global::System.Boolean __arg3, int __seq4, global::System.Boolean __arg4, int __seq5, global::System.Func<T, global::System.Boolean> __arg5, int __seq6, global::System.String __arg6, int __seq7, global::System.String __arg7, int __seq8, global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs> __arg8, int __seq9, global::System.Action<global::System.Object> __arg9, int __seq10, global::System.Action<global::System.Object> __arg10, int __seq11, T __arg11, int __seq12, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg12, int __seq13, global::Microsoft.AspNetCore.Components.RenderFragment __arg13, int __seq14, global::Microsoft.AspNetCore.Components.RenderFragment __arg14, int __seq15, global::Microsoft.AspNetCore.Components.RenderFragment __arg15, int __seq16, global::Microsoft.AspNetCore.Components.RenderFragment<T> __arg16, int __seq17, global::Microsoft.AspNetCore.Components.RenderFragment<T> __arg17, int __seq18, global::Microsoft.AspNetCore.Components.RenderFragment __arg18, int __seq19, global::System.Action<global::MudBlazor.MudTable<T>> __arg19)
        {
        __builder.OpenComponent<global::MudBlazor.MudTable<T>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "Dense", __arg1);
        __builder.AddAttribute(__seq2, "Hover", __arg2);
        __builder.AddAttribute(__seq3, "ReadOnly", __arg3);
        __builder.AddAttribute(__seq4, "CanCancelEdit", __arg4);
        __builder.AddAttribute(__seq5, "Filter", __arg5);
        __builder.AddAttribute(__seq6, "SortLabel", __arg6);
        __builder.AddAttribute(__seq7, "CommitEditTooltip", __arg7);
        __builder.AddAttribute(__seq8, "OnCommitEditClick", __arg8);
        __builder.AddAttribute(__seq9, "RowEditPreview", __arg9);
        __builder.AddAttribute(__seq10, "RowEditCancel", __arg10);
        __builder.AddAttribute(__seq11, "SelectedItem", __arg11);
        __builder.AddAttribute(__seq12, "SelectedItemChanged", __arg12);
        __builder.AddAttribute(__seq13, "ToolBarContent", __arg13);
        __builder.AddAttribute(__seq14, "ColGroup", __arg14);
        __builder.AddAttribute(__seq15, "HeaderContent", __arg15);
        __builder.AddAttribute(__seq16, "RowTemplate", __arg16);
        __builder.AddAttribute(__seq17, "RowEditingTemplate", __arg17);
        __builder.AddAttribute(__seq18, "PagerContent", __arg18);
        __builder.AddComponentReferenceCapture(__seq19, (__value) => { __arg19((global::MudBlazor.MudTable<T>)__value); });
        __builder.CloseComponent();
        }
        public static void CreateMudTextField_1<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::MudBlazor.Adornment __arg1, int __seq2, global::System.String __arg2, int __seq3, global::MudBlazor.Size __arg3, int __seq4, global::System.String __arg4, int __seq5, T __arg5, int __seq6, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg6)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Placeholder", __arg0);
        __builder.AddAttribute(__seq1, "Adornment", __arg1);
        __builder.AddAttribute(__seq2, "AdornmentIcon", __arg2);
        __builder.AddAttribute(__seq3, "IconSize", __arg3);
        __builder.AddAttribute(__seq4, "Class", __arg4);
        __builder.AddAttribute(__seq5, "Value", __arg5);
        __builder.AddAttribute(__seq6, "ValueChanged", __arg6);
        __builder.CloseComponent();
        }
        public static void CreateMudTableSortLabel_2<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Func<T, global::System.Object> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::MudBlazor.MudTableSortLabel<T>>(seq);
        __builder.AddAttribute(__seq0, "SortBy", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateMudTableSortLabel_3<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Func<T, global::System.Object> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::MudBlazor.MudTableSortLabel<T>>(seq);
        __builder.AddAttribute(__seq0, "SortBy", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateMudTableSortLabel_4<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Func<T, global::System.Object> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::MudBlazor.MudTableSortLabel<T>>(seq);
        __builder.AddAttribute(__seq0, "SortBy", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateMudTableSortLabel_5<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::MudBlazor.SortDirection __arg0, int __seq1, global::System.Func<T, global::System.Object> __arg1, int __seq2, global::Microsoft.AspNetCore.Components.RenderFragment __arg2)
        {
        __builder.OpenComponent<global::MudBlazor.MudTableSortLabel<T>>(seq);
        __builder.AddAttribute(__seq0, "InitialDirection", __arg0);
        __builder.AddAttribute(__seq1, "SortBy", __arg1);
        __builder.AddAttribute(__seq2, "ChildContent", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateMudTextField_6<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Boolean __arg0, int __seq1, T __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg2)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Required", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateMudTextField_7<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Boolean __arg0, int __seq1, T __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg2)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Required", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateMudTextField_8<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Boolean __arg0, int __seq1, T __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg2)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Required", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591