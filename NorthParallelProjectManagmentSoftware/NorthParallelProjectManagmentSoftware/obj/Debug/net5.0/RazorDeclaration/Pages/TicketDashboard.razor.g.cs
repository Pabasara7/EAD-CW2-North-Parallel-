// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 7 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\TicketDashboard.razor"
using NorthParallelProjectManagmentSoftware.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ticketdashboard")]
    public partial class TicketDashboard : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 132 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\TicketDashboard.razor"
       

    public User user;

    private string selectedString;

    List<Tickets> tickets;
    List<Tickets> ticket;
    List<Project> project;

    List<Tickets> userTicket;
    List<Project> projects;


    protected override async Task OnInitializedAsync()
    {
        user = await session.GetItemAsync<User>("SessionUser");
        project = await Task.Run(() => projectServices.GetProjectByMainCompanyAsync(user.MainCompany));
        tickets = await Task.Run(() => ticketServices.GetTicketByMCompanyAsync(user.MainCompany));
        ticket = await Task.Run(() => ticketServices.GetTicketByMCompanyAsync(user.MainCompany));

        userTicket = await Task.Run(() => ticketServices.GetTicketByMuserAsync(user.UserName));
    }


    public void createTicket()
    {

        NavigationManager.NavigateTo("createTicket");
    }
    public void createEmpTicket()
    {

        NavigationManager.NavigateTo("createEmpTicket");
    }
    async void OnSelect(ChangeEventArgs e)
    {


        selectedString = e.Value.ToString();

        if (selectedString.Equals("all"))
        {
            projects = project;

        }
        else
        {
            tickets = ticket.Where(f => f.TicketProject.ProjectName.ToString().Equals(selectedString)).ToList();
        }

    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TicketServices ticketServices { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProjectServices projectServices { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CompanyServices companyServices { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISessionStorageService session { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591