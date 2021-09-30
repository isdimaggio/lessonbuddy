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
    public partial class RedirectToLogin : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 3 "F:\MRBACKSLASH\lessonbuddy\lessonbuddy.mrbackslash.it\Shared\RedirectToLogin.razor"
       

	[CascadingParameter]
	private Task<AuthenticationState> AuthenticationStateTask { get; set; }

	protected override async Task OnInitializedAsync()
	{
		var authenticationState = await AuthenticationStateTask;
		
		if (authenticationState?.User?.Identity is null || !authenticationState.User.Identity.IsAuthenticated)
		{
			var returrnUrl = Navigation.ToBaseRelativePath(Navigation.Uri);

			if (string.IsNullOrWhiteSpace(returrnUrl))
			{
				Navigation.NavigateTo("/Identity/Account/Login", true);
			}
			else
			{
				Navigation.NavigateTo($"/Identity/Account/Login?returnUrl={returrnUrl}", true);
			}
		}
	}



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigation { get; set; }
    }
}
#pragma warning restore 1591
