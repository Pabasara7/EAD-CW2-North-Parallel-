#pragma checksum "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\ViewProject.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53b576de453cfe67c439f4a47311bb368d9ddada"
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
#line 10 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\ViewProject.razor"
using NorthParallelProjectManagmentSoftware.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/viewProject/{Id}")]
    public partial class ViewProject : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<NorthParallelProjectManagmentSoftware.Shared.NavMenu>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\r\n");
            __builder.OpenElement(2, "body");
            __builder.AddAttribute(3, "b-9m0pg0djh5");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col1");
            __builder.AddAttribute(6, "b-9m0pg0djh5");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "head");
            __builder.AddAttribute(9, "b-9m0pg0djh5");
            __builder.OpenElement(10, "button");
            __builder.AddAttribute(11, "type", "button");
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\ViewProject.razor"
                                            editPage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "class", "btn btn-primary");
            __builder.AddAttribute(14, "b-9m0pg0djh5");
            __builder.AddContent(15, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n            ");
            __builder.OpenElement(17, "button");
            __builder.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\ViewProject.razor"
                                () => { showModal = true; }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "class", "btn btn-danger");
            __builder.AddAttribute(20, "b-9m0pg0djh5");
            __builder.AddContent(21, "Delete");
            __builder.CloseElement();
#nullable restore
#line 20 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\ViewProject.razor"
             if (showModal)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "modal fade show");
            __builder.AddAttribute(24, "id", "myModal");
            __builder.AddAttribute(25, "style", " display: block;");
            __builder.AddAttribute(26, "b-9m0pg0djh5");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "modal-dialog");
            __builder.AddAttribute(29, "b-9m0pg0djh5");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "modal-content");
            __builder.AddAttribute(32, "b-9m0pg0djh5");
            __builder.AddMarkupContent(33, "<div class=\"modal-header\" b-9m0pg0djh5><h4 class=\"modal-title\" b-9m0pg0djh5>Project Deletion</h4>\r\n                                <button type=\"button\" class=\"close\" data-dismiss=\"modal\" b-9m0pg0djh5>&times;</button></div>\r\n                            ");
            __builder.AddMarkupContent(34, "<div class=\"modal-body\" b-9m0pg0djh5>\r\n                                Are you sure you want to delete this Project?\r\n\r\n                            </div>\r\n                            ");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "modal-footer");
            __builder.AddAttribute(37, "b-9m0pg0djh5");
            __builder.OpenElement(38, "button");
            __builder.AddAttribute(39, "type", "button");
            __builder.AddAttribute(40, "class", "btn btn-danger");
            __builder.AddAttribute(41, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\ViewProject.razor"
                                                                                        deleteProject

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(42, "b-9m0pg0djh5");
            __builder.AddContent(43, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                                ");
            __builder.OpenElement(45, "button");
            __builder.AddAttribute(46, "type", "button");
            __builder.AddAttribute(47, "class", "btn btn-primary");
            __builder.AddAttribute(48, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\ViewProject.razor"
                                                                                          () => { showModal = false; }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(49, "b-9m0pg0djh5");
            __builder.AddContent(50, "Close");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n                <div class=\"modal-backdrop fade show\" b-9m0pg0djh5></div>");
#nullable restore
#line 46 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\ViewProject.razor"

            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n\r\n        ");
            __builder.OpenElement(53, "h3");
            __builder.AddAttribute(54, "b-9m0pg0djh5");
            __builder.AddContent(55, 
#nullable restore
#line 52 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\ViewProject.razor"
             project.ProjectName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n        <br b-9m0pg0djh5>\r\n        ");
            __builder.OpenElement(57, "p");
            __builder.AddAttribute(58, "b-9m0pg0djh5");
            __builder.AddContent(59, "Project Id : ");
            __builder.AddContent(60, 
#nullable restore
#line 54 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\ViewProject.razor"
                         project.ProjectId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n        ");
            __builder.OpenElement(62, "p");
            __builder.AddAttribute(63, "b-9m0pg0djh5");
            __builder.AddContent(64, "Company  : ");
            __builder.AddContent(65, 
#nullable restore
#line 55 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\ViewProject.razor"
                       compName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n        ");
            __builder.OpenElement(67, "p");
            __builder.AddAttribute(68, "b-9m0pg0djh5");
            __builder.AddContent(69, "Description : ");
            __builder.AddContent(70, 
#nullable restore
#line 56 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\ViewProject.razor"
                          project.ProjectDescription

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n        ");
            __builder.OpenElement(72, "p");
            __builder.AddAttribute(73, "b-9m0pg0djh5");
            __builder.AddContent(74, "Start Date : ");
            __builder.AddContent(75, 
#nullable restore
#line 57 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\ViewProject.razor"
                         project.ProjectStartDate.ToString("dd-MM-yyyy")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n        ");
            __builder.OpenElement(77, "p");
            __builder.AddAttribute(78, "b-9m0pg0djh5");
            __builder.AddContent(79, "End Date : ");
            __builder.AddContent(80, 
#nullable restore
#line 58 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\ViewProject.razor"
                       project.ProjectEndDate.ToString("dd-MM-yyyy")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 64 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\ViewProject.razor"
       

    [Parameter]
    public string Id { get; set; }

    public string compName;
    bool showModal = false;
    Project project = new Project();


    List<User> user;

    protected override async Task OnInitializedAsync()
    {
        project = await Task.Run(() => projectServices.GetProjectAsync(Convert.ToInt32(Id)));
        compName = project.ProjectCompany.CompanyName.ToString();

    }



    protected async void deleteProject()
    {
        await projectServices.DeleteProjectAsync(project);
        NavigationManager.NavigateTo("projectdashboard");
    }
    void editPage()
    {
        NavigationManager.NavigateTo("editProject/" + Id);
    }
    void Cancel()
    {
        NavigationManager.NavigateTo("projectdashboard");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IModalService Modal { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserServices userServices { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProjectServices projectServices { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CompanyServices companyServices { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISessionStorageService session { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
