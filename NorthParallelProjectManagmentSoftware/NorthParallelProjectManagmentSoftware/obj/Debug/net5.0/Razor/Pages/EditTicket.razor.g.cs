#pragma checksum "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\EditTicket.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d90b4d5bd92318e501c1a1015ecc92712917cc65"
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
#line 6 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\EditTicket.razor"
using NorthParallelProjectManagmentSoftware.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/editTicket/{Id}")]
    public partial class EditTicket : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<NorthParallelProjectManagmentSoftware.Shared.NavMenu>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\r\n");
            __builder.AddMarkupContent(2, "<div class=\"head\" b-ins21zxu29><h2 b-ins21zxu29>Edit Ticket Details</h2></div>\r\n\r\n");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "editForm");
            __builder.AddAttribute(5, "b-ins21zxu29");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(6);
            __builder.AddAttribute(7, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 14 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\EditTicket.razor"
                      ticket

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(9);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(10, "\r\n        ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "row");
                __builder2.AddAttribute(13, "b-ins21zxu29");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "col-md-8");
                __builder2.AddAttribute(16, "b-ins21zxu29");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "form-group");
                __builder2.AddAttribute(19, "b-ins21zxu29");
                __builder2.AddMarkupContent(20, "<label for=\"ticketName\" class=\"control-label\" b-ins21zxu29>ticket Name</label>\r\n                    ");
                __builder2.OpenElement(21, "input");
                __builder2.AddAttribute(22, "form", "ticketName");
                __builder2.AddAttribute(23, "class", "form-control");
                __builder2.AddAttribute(24, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 20 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\EditTicket.razor"
                                                                          ticket.TicketName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => ticket.TicketName = __value, ticket.TicketName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddAttribute(26, "b-ins21zxu29");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n                    ");
                __Blazor.NorthParallelProjectManagmentSoftware.Pages.EditTicket.TypeInference.CreateValidationMessage_0(__builder2, 28, 29, 
#nullable restore
#line 21 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\EditTicket.razor"
                                              ()=>ticket.TicketName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n\r\n                ");
                __builder2.OpenElement(31, "div");
                __builder2.AddAttribute(32, "class", "form-group");
                __builder2.AddAttribute(33, "b-ins21zxu29");
                __builder2.AddMarkupContent(34, "<label for=\"ticketDescription\" class=\"control-label\" b-ins21zxu29>Ticket Description</label>\r\n                    ");
                __builder2.OpenElement(35, "input");
                __builder2.AddAttribute(36, "form", "ticketDescription");
                __builder2.AddAttribute(37, "class", "form-control");
                __builder2.AddAttribute(38, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 26 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\EditTicket.razor"
                                                                                 ticket.TicketDescription

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(39, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => ticket.TicketDescription = __value, ticket.TicketDescription));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddAttribute(40, "b-ins21zxu29");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n\r\n                    ");
                __Blazor.NorthParallelProjectManagmentSoftware.Pages.EditTicket.TypeInference.CreateValidationMessage_1(__builder2, 42, 43, 
#nullable restore
#line 28 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\EditTicket.razor"
                                              ()=>ticket.TicketDescription

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n\r\n                ");
                __builder2.OpenElement(45, "div");
                __builder2.AddAttribute(46, "class", "form-group");
                __builder2.AddAttribute(47, "b-ins21zxu29");
                __builder2.AddMarkupContent(48, "<label for=\"UserState\" class=\"control-label\" b-ins21zxu29>Ticeket Progress</label>\r\n                    ");
                __builder2.OpenElement(49, "select");
                __builder2.AddAttribute(50, "class", "form-control");
                __builder2.AddAttribute(51, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 33 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\EditTicket.razor"
                                    ticket.TicketProgress

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(52, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => ticket.TicketProgress = __value, ticket.TicketProgress));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddAttribute(53, "b-ins21zxu29");
                __builder2.OpenElement(54, "option");
                __builder2.AddAttribute(55, "value");
                __builder2.AddAttribute(56, "b-ins21zxu29");
                __builder2.AddContent(57, "Select Ticket Progress");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\r\n                        ");
                __builder2.OpenElement(59, "option");
                __builder2.AddAttribute(60, "value", "0% - Initiated");
                __builder2.AddAttribute(61, "b-ins21zxu29");
                __builder2.AddContent(62, "0% - Initiated");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(63, "\r\n                        ");
                __builder2.OpenElement(64, "option");
                __builder2.AddAttribute(65, "value", "25% - Started");
                __builder2.AddAttribute(66, "b-ins21zxu29");
                __builder2.AddContent(67, "25% - Started");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(68, "\r\n                        ");
                __builder2.OpenElement(69, "option");
                __builder2.AddAttribute(70, "value", "50% - Halfway");
                __builder2.AddAttribute(71, "b-ins21zxu29");
                __builder2.AddContent(72, "50% - Halfway");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(73, "\r\n                        ");
                __builder2.OpenElement(74, "option");
                __builder2.AddAttribute(75, "value", "75% - Almost Completed");
                __builder2.AddAttribute(76, "b-ins21zxu29");
                __builder2.AddContent(77, "75% - Almost Completed");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(78, "\r\n                        ");
                __builder2.OpenElement(79, "option");
                __builder2.AddAttribute(80, "value", "100% - Completed");
                __builder2.AddAttribute(81, "b-ins21zxu29");
                __builder2.AddContent(82, "100% - Completed");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(83, "\r\n\r\n                ");
                __builder2.OpenElement(84, "div");
                __builder2.AddAttribute(85, "class", "form-group");
                __builder2.AddAttribute(86, "b-ins21zxu29");
                __builder2.AddMarkupContent(87, "<label for=\"ticketDescription\" class=\"control-label\" b-ins21zxu29>Ticket Current State Update</label>\r\n                    ");
                __builder2.OpenElement(88, "input");
                __builder2.AddAttribute(89, "form", "ticketDescription");
                __builder2.AddAttribute(90, "class", "form-control");
                __builder2.AddAttribute(91, "placeholder", "Eg: Working on bug fixes");
                __builder2.AddAttribute(92, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 45 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\EditTicket.razor"
                                                                                                                        ticket.TicketCurrentStateUpdate

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(93, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => ticket.TicketCurrentStateUpdate = __value, ticket.TicketCurrentStateUpdate));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddAttribute(94, "b-ins21zxu29");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(95, "\r\n\r\n        ");
                __builder2.OpenElement(96, "div");
                __builder2.AddAttribute(97, "class", "row");
                __builder2.AddAttribute(98, "b-ins21zxu29");
                __builder2.OpenElement(99, "div");
                __builder2.AddAttribute(100, "class", "col-md-4");
                __builder2.AddAttribute(101, "b-ins21zxu29");
                __builder2.OpenElement(102, "div");
                __builder2.AddAttribute(103, "class", "form-group");
                __builder2.AddAttribute(104, "b-ins21zxu29");
                __builder2.OpenElement(105, "input");
                __builder2.AddAttribute(106, "type", "button");
                __builder2.AddAttribute(107, "class", "btn btn-primary");
                __builder2.AddAttribute(108, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 53 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\EditTicket.razor"
                                                                            updateTicket

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(109, "value", "Update Ticket");
                __builder2.AddAttribute(110, "b-ins21zxu29");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(111, "\r\n                    ");
                __builder2.OpenElement(112, "input");
                __builder2.AddAttribute(113, "type", "button");
                __builder2.AddAttribute(114, "class", "btn btn-primary");
                __builder2.AddAttribute(115, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 54 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\EditTicket.razor"
                                                                            Cancel

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(116, "value", "Cancel");
                __builder2.AddAttribute(117, "b-ins21zxu29");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 61 "C:\Users\ratna\source\repos\NorthParallelProjectManagmentSoftware\NorthParallelProjectManagmentSoftware\Pages\EditTicket.razor"
       

    [Parameter]
    public string Id { get; set; }
    Tickets ticket = new Tickets();

    protected override async Task OnInitializedAsync()
    {
        ticket = await Task.Run(() => ticketServices.GetTicketAsync(Convert.ToInt32(Id)));
    }
    protected async void updateTicket()
    {
        await ticketServices.UpdateTicketAsync(ticket);
        NavigationManager.NavigateTo("viewTicket/"+Id);
    }
    void Cancel()
    {
        NavigationManager.NavigateTo("viewTicket/" + Id);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TicketServices ticketServices { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProjectServices projectServices { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISessionStorageService session { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
namespace __Blazor.NorthParallelProjectManagmentSoftware.Pages.EditTicket
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
