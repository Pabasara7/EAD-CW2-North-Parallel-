#pragma checksum "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\CreateEmpTicket.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c924ec65f26e0767f6791806b29b13d7ca841e3b"
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
#line 8 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\CreateEmpTicket.razor"
using NorthParallelProjectManagmentSoftware.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\CreateEmpTicket.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/createEmpTicket")]
    public partial class CreateEmpTicket : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 11 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\CreateEmpTicket.razor"
 if (user != null)
{



#line default
#line hidden
#nullable disable
            __builder.OpenComponent<NorthParallelProjectManagmentSoftware.Shared.NavMenuEmp>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\r\n    ");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "createForm");
            __builder.AddAttribute(4, "b-wn8c76zxij");
            __builder.AddMarkupContent(5, "<div class=\"instructions\" b-wn8c76zxij><h2 b-wn8c76zxij>Create Ticket</h2>\r\n            <p b-wn8c76zxij>*Fill the below form to create ticket</p></div>\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "form");
            __builder.AddAttribute(8, "b-wn8c76zxij");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(9);
            __builder.AddAttribute(10, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 22 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\CreateEmpTicket.razor"
                              ticket

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(12);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\r\n                ");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "row");
                __builder2.AddAttribute(16, "b-wn8c76zxij");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "col-md-8");
                __builder2.AddAttribute(19, "b-wn8c76zxij");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", "form-group");
                __builder2.AddAttribute(22, "b-wn8c76zxij");
                __builder2.AddMarkupContent(23, "<label for=\"ticketName\" class=\"control-label\" b-wn8c76zxij>Ticket Name</label>\r\n                            ");
                __builder2.OpenElement(24, "input");
                __builder2.AddAttribute(25, "form", "ticketName");
                __builder2.AddAttribute(26, "placeholder", "Enter Ticket Name");
                __builder2.AddAttribute(27, "class", "form-control");
                __builder2.AddAttribute(28, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 28 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\CreateEmpTicket.razor"
                                                                                                                  ticket.TicketName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(29, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => ticket.TicketName = __value, ticket.TicketName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddAttribute(30, "b-wn8c76zxij");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n                            ");
                __Blazor.NorthParallelProjectManagmentSoftware.Pages.CreateEmpTicket.TypeInference.CreateValidationMessage_0(__builder2, 32, 33, 
#nullable restore
#line 29 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\CreateEmpTicket.razor"
                                                      () => ticket.TicketName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\r\n\r\n                        \r\n                       \r\n\r\n                        ");
                __builder2.OpenElement(35, "div");
                __builder2.AddAttribute(36, "class", "form-group");
                __builder2.AddAttribute(37, "b-wn8c76zxij");
                __builder2.AddMarkupContent(38, "<label for=\"ticketDescription\" class=\"control-label\" b-wn8c76zxij>Ticket Description</label>\r\n                            ");
                __builder2.OpenElement(39, "input");
                __builder2.AddAttribute(40, "form", "ticketDescription");
                __builder2.AddAttribute(41, "placeholder", "Enter Company Description");
                __builder2.AddAttribute(42, "class", "form-control");
                __builder2.AddAttribute(43, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 37 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\CreateEmpTicket.razor"
                                                                                                                                 ticket.TicketDescription

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(44, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => ticket.TicketDescription = __value, ticket.TicketDescription));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddAttribute(45, "b-wn8c76zxij");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n                            ");
                __Blazor.NorthParallelProjectManagmentSoftware.Pages.CreateEmpTicket.TypeInference.CreateValidationMessage_1(__builder2, 47, 48, 
#nullable restore
#line 38 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\CreateEmpTicket.razor"
                                                      () => ticket.TicketDescription

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\r\n\r\n                        ");
                __builder2.OpenElement(50, "div");
                __builder2.AddAttribute(51, "class", "form-group");
                __builder2.AddAttribute(52, "b-wn8c76zxij");
                __builder2.AddMarkupContent(53, "<label for=\"UserState\" class=\"control-label\" b-wn8c76zxij>Ticeket Progress</label>\r\n                            ");
                __builder2.OpenElement(54, "select");
                __builder2.AddAttribute(55, "class", "form-control");
                __builder2.AddAttribute(56, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 43 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\CreateEmpTicket.razor"
                                            ticket.TicketProgress

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(57, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => ticket.TicketProgress = __value, ticket.TicketProgress));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddAttribute(58, "b-wn8c76zxij");
                __builder2.OpenElement(59, "option");
                __builder2.AddAttribute(60, "value");
                __builder2.AddAttribute(61, "b-wn8c76zxij");
                __builder2.AddContent(62, "Select Ticket Progress");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(63, "\r\n                                ");
                __builder2.OpenElement(64, "option");
                __builder2.AddAttribute(65, "value", "0% - Initiated");
                __builder2.AddAttribute(66, "b-wn8c76zxij");
                __builder2.AddContent(67, "0% - Initiated");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(68, "\r\n                                ");
                __builder2.OpenElement(69, "option");
                __builder2.AddAttribute(70, "value", "25% - Started");
                __builder2.AddAttribute(71, "b-wn8c76zxij");
                __builder2.AddContent(72, "25% - Started");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(73, "\r\n                                ");
                __builder2.OpenElement(74, "option");
                __builder2.AddAttribute(75, "value", "50% - Halfway");
                __builder2.AddAttribute(76, "b-wn8c76zxij");
                __builder2.AddContent(77, "50% - Halfway");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(78, "\r\n                                ");
                __builder2.OpenElement(79, "option");
                __builder2.AddAttribute(80, "value", "75% - Almost Completed");
                __builder2.AddAttribute(81, "b-wn8c76zxij");
                __builder2.AddContent(82, "75% - Almost Completed");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(83, "\r\n                                ");
                __builder2.OpenElement(84, "option");
                __builder2.AddAttribute(85, "value", "100% - Completed");
                __builder2.AddAttribute(86, "b-wn8c76zxij");
                __builder2.AddContent(87, "100% - Completed");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(88, "\r\n                            ");
                __Blazor.NorthParallelProjectManagmentSoftware.Pages.CreateEmpTicket.TypeInference.CreateValidationMessage_2(__builder2, 89, 90, 
#nullable restore
#line 51 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\CreateEmpTicket.razor"
                                                      () => ticket.TicketProgress

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(91, "\r\n\r\n                        ");
                __builder2.OpenElement(92, "div");
                __builder2.AddAttribute(93, "class", "form-group");
                __builder2.AddAttribute(94, "b-wn8c76zxij");
                __builder2.AddMarkupContent(95, "<label for=\"ticketDescription\" class=\"control-label\" b-wn8c76zxij>Ticket Current State Update</label>\r\n                            ");
                __builder2.OpenElement(96, "input");
                __builder2.AddAttribute(97, "form", "ticketDescription");
                __builder2.AddAttribute(98, "class", "form-control");
                __builder2.AddAttribute(99, "placeholder", "Eg: Working on bug fixes");
                __builder2.AddAttribute(100, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 56 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\CreateEmpTicket.razor"
                                                                                                                                ticket.TicketCurrentStateUpdate

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(101, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => ticket.TicketCurrentStateUpdate = __value, ticket.TicketCurrentStateUpdate));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddAttribute(102, "b-wn8c76zxij");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(103, "\r\n                            ");
                __Blazor.NorthParallelProjectManagmentSoftware.Pages.CreateEmpTicket.TypeInference.CreateValidationMessage_3(__builder2, 104, 105, 
#nullable restore
#line 57 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\CreateEmpTicket.razor"
                                                      () => ticket.TicketCurrentStateUpdate

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(106, "\r\n\r\n                ");
                __builder2.OpenElement(107, "div");
                __builder2.AddAttribute(108, "class", "row");
                __builder2.AddAttribute(109, "b-wn8c76zxij");
                __builder2.OpenElement(110, "div");
                __builder2.AddAttribute(111, "class", "col-md-4");
                __builder2.AddAttribute(112, "b-wn8c76zxij");
                __builder2.OpenElement(113, "div");
                __builder2.AddAttribute(114, "class", "form-group");
                __builder2.AddAttribute(115, "b-wn8c76zxij");
                __builder2.OpenElement(116, "input");
                __builder2.AddAttribute(117, "type", "submit");
                __builder2.AddAttribute(118, "class", "btn btn-primary");
                __builder2.AddAttribute(119, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 65 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\CreateEmpTicket.razor"
                                                                                    createTicket

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(120, "value", "Create Ticket");
                __builder2.AddAttribute(121, "b-wn8c76zxij");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(122, "\r\n                            ");
                __builder2.OpenElement(123, "input");
                __builder2.AddAttribute(124, "type", "button");
                __builder2.AddAttribute(125, "class", "btn btn-danger");
                __builder2.AddAttribute(126, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 66 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\CreateEmpTicket.razor"
                                                                                   Cancel

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(127, "value", "  Back  ");
                __builder2.AddAttribute(128, "b-wn8c76zxij");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 74 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\CreateEmpTicket.razor"
          }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 78 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\CreateEmpTicket.razor"
       

    public User user;

    public User users =new User();
    public Project project;
    public Company company;
    public string selectedUserString;
    Tickets ticket = new Tickets();


    protected override async Task OnInitializedAsync()
    {
        user = await session.GetItemAsync<User>("SessionUser");
        users = await Task.Run(() => userServices.GetUserAsync(Convert.ToInt32(user.UserId)));
        project = await Task.Run(() => projectServices.GetProjectByuserId(user.UserId));

        company = await Task.Run(() => companyServices.GetcompanyByuserId(user.UserId));
    }

    protected async void createTicket()
    {
        ticket.TicketStartDate = DateTime.Now;
        ticket.MainCompany = user.MainCompany;
        ticket.TicketAssignedUser = users;
        ticket.TicketCompany = company;
        ticket.TicketProject = project;
        await ticketServices.InsertTicketAsync(ticket);
        NavigationManager.NavigateTo("ticketdashboard");



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
namespace __Blazor.NorthParallelProjectManagmentSoftware.Pages.CreateEmpTicket
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
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
