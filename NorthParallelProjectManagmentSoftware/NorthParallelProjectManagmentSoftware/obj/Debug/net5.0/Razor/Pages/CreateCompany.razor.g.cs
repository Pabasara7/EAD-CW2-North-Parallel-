#pragma checksum "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\CreateCompany.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2aed50031f5b3e7191e4d55f6f962a5af034c599"
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
#line 5 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\CreateCompany.razor"
using NorthParallelProjectManagmentSoftware.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\CreateCompany.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/createCompany")]
    public partial class CreateCompany : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<NorthParallelProjectManagmentSoftware.Shared.NavMenu>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "createForm");
            __builder.AddAttribute(4, "b-4o1tkq69u0");
            __builder.AddMarkupContent(5, "<div class=\"instructions\" b-4o1tkq69u0><h2 b-4o1tkq69u0>Create Company</h2>\r\n        <p b-4o1tkq69u0>*Fill the below form to create company</p></div>\r\n    ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "form");
            __builder.AddAttribute(8, "b-4o1tkq69u0");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(9);
            __builder.AddAttribute(10, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 16 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\CreateCompany.razor"
                          company

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(12);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\r\n            ");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "row");
                __builder2.AddAttribute(16, "b-4o1tkq69u0");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "col-md-8");
                __builder2.AddAttribute(19, "b-4o1tkq69u0");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", "form-group");
                __builder2.AddAttribute(22, "b-4o1tkq69u0");
                __builder2.AddMarkupContent(23, "<label for=\"companyName\" class=\"control-label\" b-4o1tkq69u0>Company Name</label>\r\n                        ");
                __builder2.OpenElement(24, "input");
                __builder2.AddAttribute(25, "form", "companyName");
                __builder2.AddAttribute(26, "placeholder", "Enter Company Name");
                __builder2.AddAttribute(27, "class", "form-control");
                __builder2.AddAttribute(28, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 22 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\CreateCompany.razor"
                                                                                                                company.CompanyName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(29, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => company.CompanyName = __value, company.CompanyName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddAttribute(30, "b-4o1tkq69u0");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n                        ");
                __Blazor.NorthParallelProjectManagmentSoftware.Pages.CreateCompany.TypeInference.CreateValidationMessage_0(__builder2, 32, 33, 
#nullable restore
#line 23 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\CreateCompany.razor"
                                                  ()=>company.CompanyName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\r\n\r\n                    ");
                __builder2.OpenElement(35, "div");
                __builder2.AddAttribute(36, "class", "form-group");
                __builder2.AddAttribute(37, "b-4o1tkq69u0");
                __builder2.AddMarkupContent(38, "<label for=\"companyDescription\" class=\"control-label\" b-4o1tkq69u0>Company Description</label>\r\n                        ");
                __builder2.OpenElement(39, "input");
                __builder2.AddAttribute(40, "form", "ticketDescription");
                __builder2.AddAttribute(41, "placeholder", "Enter Company Description");
                __builder2.AddAttribute(42, "class", "form-control");
                __builder2.AddAttribute(43, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 28 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\CreateCompany.razor"
                                                                                                                             company.CompanyDescription

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(44, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => company.CompanyDescription = __value, company.CompanyDescription));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddAttribute(45, "b-4o1tkq69u0");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n                        ");
                __Blazor.NorthParallelProjectManagmentSoftware.Pages.CreateCompany.TypeInference.CreateValidationMessage_1(__builder2, 47, 48, 
#nullable restore
#line 29 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\CreateCompany.razor"
                                                  ()=>company.CompanyDescription

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\r\n\r\n            ");
                __builder2.OpenElement(50, "div");
                __builder2.AddAttribute(51, "class", "row");
                __builder2.AddAttribute(52, "b-4o1tkq69u0");
                __builder2.OpenElement(53, "div");
                __builder2.AddAttribute(54, "class", "col-md-4");
                __builder2.AddAttribute(55, "b-4o1tkq69u0");
                __builder2.OpenElement(56, "div");
                __builder2.AddAttribute(57, "class", "form-group");
                __builder2.AddAttribute(58, "b-4o1tkq69u0");
                __builder2.OpenElement(59, "input");
                __builder2.AddAttribute(60, "type", "submit");
                __builder2.AddAttribute(61, "class", "btn btn-primary");
                __builder2.AddAttribute(62, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\CreateCompany.razor"
                                                                                createcompany

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(63, "value", "Create Company");
                __builder2.AddAttribute(64, "b-4o1tkq69u0");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(65, "\r\n                        ");
                __builder2.OpenElement(66, "input");
                __builder2.AddAttribute(67, "type", "button");
                __builder2.AddAttribute(68, "class", "btn btn-danger");
                __builder2.AddAttribute(69, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\CreateCompany.razor"
                                                                               Cancel

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(70, "value", "  Back  ");
                __builder2.AddAttribute(71, "b-4o1tkq69u0");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 47 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\CreateCompany.razor"
       

    public User user;
    public DateTime joinedDate = DateTime.Now;

    protected override async Task OnInitializedAsync()
    {
        user = await session.GetItemAsync<User>("SessionUser");

    }
    Company company = new Company();

    protected async void createcompany()
    {
            company.CompanyJoinedDate = joinedDate;
            company.MainCompany = user.MainCompany;
            await companyServices.InsertCompanyAsync(company);
            NavigationManager.NavigateTo("companydashboard");
       
    }

    public void Cancel()
    {

        NavigationManager.NavigateTo("companydashboard");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CompanyServices companyServices { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISessionStorageService session { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
namespace __Blazor.NorthParallelProjectManagmentSoftware.Pages.CreateCompany
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
