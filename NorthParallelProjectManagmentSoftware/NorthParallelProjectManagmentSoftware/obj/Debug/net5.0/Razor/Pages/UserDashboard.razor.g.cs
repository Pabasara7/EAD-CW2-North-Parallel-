#pragma checksum "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\UserDashboard.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ddb15e52459cb0188ac5e9674a68f7d30af4f874"
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
#line 7 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\UserDashboard.razor"
using NorthParallelProjectManagmentSoftware.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/userdashboard")]
    public partial class UserDashboard : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<NorthParallelProjectManagmentSoftware.Shared.NavMenu>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", " head");
            __builder.AddAttribute(4, "b-17i0xwllxl");
            __builder.OpenElement(5, "button");
            __builder.AddAttribute(6, "type", "button");
            __builder.AddAttribute(7, "class", "btn btn-success");
            __builder.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\UserDashboard.razor"
                                                             createUser

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "b-17i0xwllxl");
            __builder.AddContent(10, "+ Create User");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n\r\n    ");
            __builder.AddMarkupContent(12, "<h2 class=\"heading\" b-17i0xwllxl>Users</h2>");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "form-group");
            __builder.AddAttribute(16, "b-17i0xwllxl");
            __builder.AddMarkupContent(17, "<label for=\"ticketDescription\" class=\"control-label\" b-17i0xwllxl>Select Company</label>\r\n\r\n    ");
            __builder.OpenElement(18, "select");
            __builder.AddAttribute(19, "name", "compaines");
            __builder.AddAttribute(20, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 20 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\UserDashboard.razor"
                                         OnSelectProject

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "id", "companyDropdown");
            __builder.AddAttribute(22, "b-17i0xwllxl");
#nullable restore
#line 21 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\UserDashboard.razor"
         if (company is null)
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(23, "<p b-17i0xwllxl><em b-17i0xwllxl>Loading... !</em></p>");
#nullable restore
#line 24 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\UserDashboard.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(24, "option");
            __builder.AddAttribute(25, "value");
            __builder.AddAttribute(26, "disabled");
            __builder.AddAttribute(27, "selected");
            __builder.AddAttribute(28, "b-17i0xwllxl");
            __builder.AddContent(29, "Select Project");
            __builder.CloseElement();
            __builder.OpenElement(30, "option");
            __builder.AddAttribute(31, "value", "all");
            __builder.AddAttribute(32, "b-17i0xwllxl");
            __builder.AddContent(33, "All Projects");
            __builder.CloseElement();
#nullable restore
#line 31 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\UserDashboard.razor"
             foreach (var prj in projects)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(34, "option");
            __builder.AddAttribute(35, "value", 
#nullable restore
#line 33 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\UserDashboard.razor"
                                prj.ProjectName

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(36, "b-17i0xwllxl");
            __builder.AddContent(37, 
#nullable restore
#line 33 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\UserDashboard.razor"
                                                  prj.ProjectName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 34 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\UserDashboard.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\UserDashboard.razor"
             
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n    ");
            __builder.AddMarkupContent(39, "<label for=\"ticketDescription\" class=\"control-label\" b-17i0xwllxl>Select Company</label>\r\n\r\n    ");
            __builder.OpenElement(40, "select");
            __builder.AddAttribute(41, "name", "compaines");
            __builder.AddAttribute(42, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 39 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\UserDashboard.razor"
                                         OnSelectCompany

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(43, "id", "companyDropdown");
            __builder.AddAttribute(44, "b-17i0xwllxl");
#nullable restore
#line 40 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\UserDashboard.razor"
         if (company is null)
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(45, "<p b-17i0xwllxl><em b-17i0xwllxl>Loading... !</em></p>");
#nullable restore
#line 43 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\UserDashboard.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(46, "option");
            __builder.AddAttribute(47, "value");
            __builder.AddAttribute(48, "disabled");
            __builder.AddAttribute(49, "selected");
            __builder.AddAttribute(50, "b-17i0xwllxl");
            __builder.AddContent(51, "Select Company");
            __builder.CloseElement();
            __builder.OpenElement(52, "option");
            __builder.AddAttribute(53, "value", "all");
            __builder.AddAttribute(54, "b-17i0xwllxl");
            __builder.AddContent(55, "All Companies");
            __builder.CloseElement();
#nullable restore
#line 50 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\UserDashboard.razor"
             foreach (var cmp in company)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(56, "option");
            __builder.AddAttribute(57, "value", 
#nullable restore
#line 52 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\UserDashboard.razor"
                                cmp.CompanyName

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(58, "b-17i0xwllxl");
            __builder.AddContent(59, 
#nullable restore
#line 52 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\UserDashboard.razor"
                                                  cmp.CompanyName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 53 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\UserDashboard.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\UserDashboard.razor"
             
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 57 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\UserDashboard.razor"
 if (users is null && userSession is null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(60, "<p b-17i0xwllxl><em b-17i0xwllxl>Loading... !</em></p>");
#nullable restore
#line 60 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\UserDashboard.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(61, "table");
            __builder.AddAttribute(62, "class", "table table-striped");
            __builder.AddAttribute(63, "b-17i0xwllxl");
            __builder.AddMarkupContent(64, @"<thead class=""table-primary"" b-17i0xwllxl><tr b-17i0xwllxl><th b-17i0xwllxl>User Id</th>
                <th b-17i0xwllxl>User Name</th>
                <th b-17i0xwllxl>User Email</th>
                <th b-17i0xwllxl>User Authority Level</th>
                <th b-17i0xwllxl>User Project</th>
                <th b-17i0xwllxl>User Company</th>
                <th b-17i0xwllxl>User State</th></tr></thead>
        ");
            __builder.OpenElement(65, "tbody");
            __builder.AddAttribute(66, "b-17i0xwllxl");
#nullable restore
#line 76 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\UserDashboard.razor"
             foreach (var usr in users)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(67, "tr");
            __builder.AddAttribute(68, "b-17i0xwllxl");
            __builder.OpenElement(69, "td");
            __builder.AddAttribute(70, "b-17i0xwllxl");
            __builder.AddContent(71, 
#nullable restore
#line 79 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\UserDashboard.razor"
                     usr.UserId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n                ");
            __builder.OpenElement(73, "a");
            __builder.AddAttribute(74, "href", "viewUser/" + (
#nullable restore
#line 80 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\UserDashboard.razor"
                                   usr.UserId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(75, "b-17i0xwllxl");
            __builder.OpenElement(76, "td");
            __builder.AddAttribute(77, "b-17i0xwllxl");
            __builder.AddContent(78, 
#nullable restore
#line 82 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\UserDashboard.razor"
                     usr.UserName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n                ");
            __builder.OpenElement(80, "td");
            __builder.AddAttribute(81, "b-17i0xwllxl");
            __builder.AddContent(82, 
#nullable restore
#line 84 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\UserDashboard.razor"
                     usr.UserEmail

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n                ");
            __builder.OpenElement(84, "td");
            __builder.AddAttribute(85, "b-17i0xwllxl");
            __builder.AddContent(86, 
#nullable restore
#line 85 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\UserDashboard.razor"
                     usr.UserAuthorityLevel

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 86 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\UserDashboard.razor"
                 if (usr.UserAssignedProjects != null)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(87, "td");
            __builder.AddAttribute(88, "b-17i0xwllxl");
            __builder.AddContent(89, 
#nullable restore
#line 88 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\UserDashboard.razor"
                         usr.UserAssignedProjects.ProjectName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 89 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\UserDashboard.razor"
                }
                else
                {


#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(90, "<td b-17i0xwllxl>\"Not Assigned to project\"</td>");
#nullable restore
#line 94 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\UserDashboard.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 96 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\UserDashboard.razor"
                 if (usr.UserAssignedCompany != null)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(91, "td");
            __builder.AddAttribute(92, "b-17i0xwllxl");
            __builder.AddContent(93, 
#nullable restore
#line 98 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\UserDashboard.razor"
                         usr.UserAssignedCompany.CompanyName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 99 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\UserDashboard.razor"
                }
                else
                {


#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(94, "<td b-17i0xwllxl>\"Not Assigned to company\"</td>");
#nullable restore
#line 104 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\UserDashboard.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(95, "td");
            __builder.AddAttribute(96, "b-17i0xwllxl");
            __builder.AddContent(97, 
#nullable restore
#line 105 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\UserDashboard.razor"
                     usr.UserState

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 108 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\UserDashboard.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 111 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\UserDashboard.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 114 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\UserDashboard.razor"
       

    public User userSession;
    Company newCompany = new Company();
    Project newProject = new Project();
    private string selectedString;
    List<Company> company;
    List<User> users;
    List<User> user;
    List<Project> projects;


    protected override async Task OnInitializedAsync()
    {
        userSession = await session.GetItemAsync<User>("SessionUser");

        users = await Task.Run(() => userServices.GetUserMCompanyAsync(userSession.MainCompany));
        user = await Task.Run(() => userServices.GetUserMCompanyAsync(userSession.MainCompany));

        company = await Task.Run(() => companyServices.GetCompanyByMCompanyAsync(userSession.MainCompany));
        projects = await Task.Run(() => projectServices.GetProjectByMainCompanyAsync(userSession.MainCompany));
    }





    public void createUser()
    {

        NavigationManager.NavigateTo("createUser");
    }


    async void OnSelectProject(ChangeEventArgs e)
    {


        selectedString = e.Value.ToString();

        if (selectedString.Equals("all"))
        {
            users = user;

        }
        else
        {
            users = user.Where(f => f.UserAssignedProjects.ProjectName.Equals(selectedString)).ToList();
        }

    }

    async void OnSelectCompany(ChangeEventArgs e)
    {


        selectedString = e.Value.ToString();

        if (selectedString.Equals("all"))
        {
            users = user;

        }
        else
        {
            users = user.Where(f => f.UserAssignedCompany.CompanyName.Equals(selectedString)).ToList();
        }

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProjectServices projectServices { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserServices userServices { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CompanyServices companyServices { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISessionStorageService session { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591