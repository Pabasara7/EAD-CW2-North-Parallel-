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
#line 8 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\CreateTicket.razor"
using NorthParallelProjectManagmentSoftware.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\CreateTicket.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/createTicket")]
    public partial class CreateTicket : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 132 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\CreateTicket.razor"
       

    public User user;

    public string selectedProjectString;
    public string selectedString;

    public string selectedUserString;
    Tickets ticket = new Tickets();

    List<Company> company;
    List<Project> project;
    List<User> users;
    List<User> usersList;
    List<Project> projects;

    protected override async Task OnInitializedAsync()
    {
        user = await session.GetItemAsync<User>("SessionUser");

        company = await Task.Run(() => companyServices.GetCompanyByMCompanyAsync(user.MainCompany));
        project = await Task.Run(() => projectServices.GetProjectByMainCompanyAsync(user.MainCompany));
        projects = await Task.Run(() => projectServices.GetProjectByMainCompanyAsync(user.MainCompany));
        users = await Task.Run(() => userServices.GetUserMCompanyAsync(user.MainCompany));
        usersList = await Task.Run(() => userServices.GetUserMCompanyAsync(user.MainCompany));

    }

    protected async void createTicket()
    {
        ticket.TicketStartDate = DateTime.Now;
        ticket.MainCompany = user.MainCompany;
        await ticketServices.InsertTicketAsync(ticket);
        NavigationManager.NavigateTo("ticketdashboard");

    }

    async void OnSelect(ChangeEventArgs e)
    {
        selectedString = e.Value.ToString();

        foreach (var cmp in company)
        {

            if (cmp.CompanyName == selectedString)
            {

                ticket.TicketCompany = cmp;
            }
        }
        project = projects.Where(f => f.ProjectCompany.CompanyName.Equals(selectedString)).ToList();
    }

    async void OnSelectProject(ChangeEventArgs e)
    {
        selectedProjectString = e.Value.ToString();

        foreach (var prj in project)
        {

            if (prj.ProjectName == selectedProjectString)
            {

                ticket.TicketProject = prj;
            }
        }
        users = usersList.Where(f => f.UserAssignedProjects.ProjectName.ToString().Equals(selectedProjectString)).ToList();
    }

    async void OnSelectUser(ChangeEventArgs e)
    {
        selectedUserString = e.Value.ToString();

        foreach (var usr in users)
        {

            if (usr.UserName == selectedUserString)
            {

                ticket.TicketAssignedUser = usr;
            }
        }
    }
    public void Cancel()
    {

        NavigationManager.NavigateTo("ticketdashboard");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserServices userServices { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProjectServices projectServices { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TicketServices ticketServices { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CompanyServices companyServices { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISessionStorageService session { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
