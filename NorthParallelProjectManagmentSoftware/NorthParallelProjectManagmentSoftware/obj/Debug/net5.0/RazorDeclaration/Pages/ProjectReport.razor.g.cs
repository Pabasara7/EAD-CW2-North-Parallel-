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
#line 9 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\ProjectReport.razor"
using NorthParallelProjectManagmentSoftware.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/projectReport")]
    public partial class ProjectReport : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 147 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\ProjectReport.razor"
       
    [Parameter]
    public string Id { get; set; }
    public string selectedString;
    public string output;
    public string confPassword;
    public int completedTickets = 0;
    public int noOfTickets;
    public int pendingTickets = 0;
    public User userSession;
    public string selectedProjectString;
    User user = new User();
    List<Company> company;
    List<Project> project;
    public bool report = false;
    List<Project> projects;
    public DateTime toDate;
    public int noOfUsers;
    public DateTime fromDate=DateTime.Now;
    List<User> projectUsers;
    List<Tickets> projectTickets;

    List<Tickets> projectTicket;
    List<User> projectUser;

    protected override async Task OnInitializedAsync()
    {

        userSession = await session.GetItemAsync<User>("SessionUser");
        company = await Task.Run(() => companyServices.GetCompanyByMCompanyAsync(userSession.MainCompany));

        projectUsers = await Task.Run(() => userservices.GetUserMCompanyAsync(userSession.MainCompany));
        projectUser = await Task.Run(() => userservices.GetUserMCompanyAsync(userSession.MainCompany));

        project = await Task.Run(() => projectServices.GetProjectByMainCompanyAsync(userSession.MainCompany));
        projects = await Task.Run(() => projectServices.GetProjectByMainCompanyAsync(userSession.MainCompany));

        projectTickets = await Task.Run(() => ticketServices.GetTicketByMCompanyAsync(userSession.MainCompany));
        projectTicket = await Task.Run(() => ticketServices.GetTicketByMCompanyAsync(userSession.MainCompany));
    }

    protected async void generateReport()

    {
        report = true;
        getProjectDetails();
        getTicketDetails();
       
    }

    public void getProjectDetails()
    {
        projectUser = projectUsers.Where(f => f.UserAssignedProjects.ProjectName.Equals(selectedProjectString)).ToList();
        noOfUsers = projectUser.Count();
    }

    public void getTicketDetails()
    {

        projectTicket = projectTickets.Where(f => f.TicketProject.ProjectName.Equals(selectedProjectString)).ToList();
        noOfTickets = projectTicket.Count();
        foreach (var prjtkt in projectTicket)
        {

            if (prjtkt.TicketProgress == "100 % -Completed")
            {

                completedTickets = completedTickets + 1;

            }
            else
            {

                pendingTickets = pendingTickets + 1;
            }
        }

    }
    async void OnSelect(ChangeEventArgs e)
    {
        selectedString = e.Value.ToString();

        foreach (var cmp in company)
        {

            if (cmp.CompanyName == selectedString)
            {

                user.UserAssignedCompany = cmp;
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

                user.UserAssignedProjects = prj;
            }
        }
    }

    void Cancel()
    {
        NavigationManager.NavigateTo("home");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProjectServices projectServices { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CompanyServices companyServices { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TicketServices ticketServices { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserServices userservices { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISessionStorageService session { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591