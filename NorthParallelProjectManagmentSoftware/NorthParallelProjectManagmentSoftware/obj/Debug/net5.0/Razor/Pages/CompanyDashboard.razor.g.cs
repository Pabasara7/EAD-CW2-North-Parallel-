#pragma checksum "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\CompanyDashboard.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a331f7cda40fd785eb2a1282831410f4a31d11c"
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
#line 7 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\CompanyDashboard.razor"
using NorthParallelProjectManagmentSoftware.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/companydashboard")]
    public partial class CompanyDashboard : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 9 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\CompanyDashboard.razor"
 if (@user != null)
{
    

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<NorthParallelProjectManagmentSoftware.Shared.NavMenu>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\r\n        ");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", " head");
            __builder.AddAttribute(4, "b-n2o5ud4bjs");
            __builder.OpenElement(5, "button");
            __builder.AddAttribute(6, "type", "button");
            __builder.AddAttribute(7, "class", "btn btn-success");
            __builder.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\CompanyDashboard.razor"
                                                                     createCompany

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "b-n2o5ud4bjs");
            __builder.AddContent(10, "+ Create Company");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n\r\n            ");
            __builder.AddMarkupContent(12, "<h2 class=\"heading\" b-n2o5ud4bjs>Companies</h2>");
            __builder.CloseElement();
#nullable restore
#line 22 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\CompanyDashboard.razor"
         if (company is null )
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(13, "<p b-n2o5ud4bjs><em b-n2o5ud4bjs>Loading... !</em></p>");
#nullable restore
#line 25 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\CompanyDashboard.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(14, "table");
            __builder.AddAttribute(15, "class", "table table-striped");
            __builder.AddAttribute(16, "b-n2o5ud4bjs");
            __builder.AddMarkupContent(17, @"<thead class=""table-primary"" b-n2o5ud4bjs><tr b-n2o5ud4bjs><th b-n2o5ud4bjs>Company Id</th>
                        <th b-n2o5ud4bjs>Compnay Name</th>
                        <th b-n2o5ud4bjs>Compnay Description</th>
                        <th b-n2o5ud4bjs>Company Joined Date</th></tr></thead>
                ");
            __builder.OpenElement(18, "tbody");
            __builder.AddAttribute(19, "b-n2o5ud4bjs");
#nullable restore
#line 38 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\CompanyDashboard.razor"
                     foreach (var cmp in company)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(20, "tr");
            __builder.AddAttribute(21, "b-n2o5ud4bjs");
            __builder.OpenElement(22, "td");
            __builder.AddAttribute(23, "b-n2o5ud4bjs");
            __builder.AddContent(24, 
#nullable restore
#line 41 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\CompanyDashboard.razor"
                                 cmp.CompanyId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                            ");
            __builder.OpenElement(26, "a");
            __builder.AddAttribute(27, "href", "viewCompany/" + (
#nullable restore
#line 42 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\CompanyDashboard.razor"
                                                  cmp.CompanyId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "b-n2o5ud4bjs");
            __builder.OpenElement(29, "td");
            __builder.AddAttribute(30, "b-n2o5ud4bjs");
            __builder.AddContent(31, 
#nullable restore
#line 44 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\CompanyDashboard.razor"
                                 cmp.CompanyName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n\r\n                            ");
            __builder.OpenElement(33, "td");
            __builder.AddAttribute(34, "b-n2o5ud4bjs");
            __builder.AddContent(35, 
#nullable restore
#line 47 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\CompanyDashboard.razor"
                                 cmp.CompanyDescription

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                            ");
            __builder.OpenElement(37, "td");
            __builder.AddAttribute(38, "b-n2o5ud4bjs");
            __builder.AddContent(39, 
#nullable restore
#line 48 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\CompanyDashboard.razor"
                                 cmp.CompanyJoinedDate.ToString("dd-MM-yyyy")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 51 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\CompanyDashboard.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 54 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\CompanyDashboard.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\CompanyDashboard.razor"
         
    //}

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 76 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\CompanyDashboard.razor"
       
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 80 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\CompanyDashboard.razor"
       

    public User user = new User();
    public User users = new User();

    private string selectedString;
    public Project userProject;
    public string userAuthLevel;
    List<Company> company;
    public Company usersCompany;
    public int compId;
    List<Project> projects;


    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            user = await session.GetItemAsync<User>("SessionUser");

            users.MainCompany = user.MainCompany;

            company = await Task.Run(() => companyServices.GetCompanyByMCompanyAsync(users.MainCompany));
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 104 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\CompanyDashboard.razor"
                                                                                           

            StateHasChanged();
        }
    }


    public void createCompany()
    {

        NavigationManager.NavigateTo("createCompany");
    }

    public void home()
    {

        NavigationManager.NavigateTo("home");
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserServices userServices { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProjectServices projectServices { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CompanyServices companyServices { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISessionStorageService session { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
