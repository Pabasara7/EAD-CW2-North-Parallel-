#pragma checksum "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\Home.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c24f14b5a7df1ce16299d4c1d4894ac6d7823b03"
// <auto-generated/>
#pragma warning disable 1591
namespace NorthParallelProjectManagmentSoftware.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\_Imports.razor"
using NorthParallelProjectManagmentSoftware;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\_Imports.razor"
using NorthParallelProjectManagmentSoftware.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\Home.razor"
using NorthParallelProjectManagmentSoftware.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/home")]
    public partial class Home : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 8 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\Home.razor"
 if (user != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "body");
            __builder.AddAttribute(1, "b-eypod7j6la");
#nullable restore
#line 12 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\Home.razor"
     if (@user.UserAuthorityLevel.Equals("Administrator"))
    {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<NorthParallelProjectManagmentSoftware.Shared.NavMenu>(2);
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n        ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "grid");
            __builder.AddAttribute(6, "b-eypod7j6la");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col1");
            __builder.AddAttribute(9, "b-eypod7j6la");
            __builder.OpenElement(10, "p");
            __builder.AddAttribute(11, "b-eypod7j6la");
            __builder.AddMarkupContent(12, "Welcome to North Parallel<br b-eypod7j6la> ");
            __builder.AddContent(13, 
#nullable restore
#line 17 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\Home.razor"
                                                    user.UserName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n\r\n            ");
            __builder.AddMarkupContent(15, "<div class=\"col3\" b-eypod7j6la><a href=\"projectReport\" b-eypod7j6la><p b-eypod7j6la>Get Report On Project<span id=\"icon\" class=\"oi oi-chevron-right\" b-eypod7j6la></span></p></a></div>\r\n            ");
            __builder.AddMarkupContent(16, "<div class=\"col4\" b-eypod7j6la><a href=\"predictionReport\" b-eypod7j6la><p b-eypod7j6la>Get Prediction Report<span id=\"icon\" class=\"oi oi-chevron-right\" b-eypod7j6la></span></p></a></div>");
            __builder.CloseElement();
#nullable restore
#line 27 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\Home.razor"

    }
    else
    {


      

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\Home.razor"
       if (user != null) {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<NorthParallelProjectManagmentSoftware.Shared.NavMenuEmp>(17);
            __builder.CloseComponent();
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "grid");
            __builder.AddAttribute(21, "b-eypod7j6la");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "col1");
            __builder.AddAttribute(24, "b-eypod7j6la");
            __builder.OpenElement(25, "p");
            __builder.AddAttribute(26, "b-eypod7j6la");
            __builder.AddMarkupContent(27, "Welcome to North Parallel<br b-eypod7j6la> ");
            __builder.AddContent(28, 
#nullable restore
#line 37 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\Home.razor"
                                                    user.UserName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n\r\n          \r\n            ");
            __builder.AddMarkupContent(30, "<div class=\"col3\" b-eypod7j6la><p class=\"quote\" b-eypod7j6la>\"HARD WORK BEATS<br b-eypod7j6la> TALENT WHEN TALENT <br b-eypod7j6la>DOESNT WORK HARD.\"</p></div>");
            __builder.CloseElement();
#nullable restore
#line 46 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\Home.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\Home.razor"
         
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 50 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\Home.razor"
        }
        else
        {


#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(31, "<p b-eypod7j6la>Loading....</p>");
#nullable restore
#line 55 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\Home.razor"
        }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 60 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\Home.razor"
           

public User user;
    List<Tickets> ticket;
    List<Tickets> userTicket;
    public string projName;


    protected override async Task OnInitializedAsync()
    {
        user = await session.GetItemAsync<User>("SessionUser");
      
    }


    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProjectServices projectService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TicketServices ticketService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISessionStorageService session { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
