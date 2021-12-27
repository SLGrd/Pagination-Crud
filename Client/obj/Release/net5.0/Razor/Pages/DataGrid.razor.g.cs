#pragma checksum "D:\Tutorials\Paging\Client\Pages\DataGrid.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2643fe0edc87e356616c25fbb3a5d5fc0462a16"
// <auto-generated/>
#pragma warning disable 1591
namespace Client.Pages
{
    #line hidden
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Tutorials\Paging\Client\_Imports.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Tutorials\Paging\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Tutorials\Paging\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Tutorials\Paging\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Tutorials\Paging\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Tutorials\Paging\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Tutorials\Paging\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Tutorials\Paging\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Tutorials\Paging\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Tutorials\Paging\Client\_Imports.razor"
using System.Net.Http.Headers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Tutorials\Paging\Client\_Imports.razor"
using Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Tutorials\Paging\Client\_Imports.razor"
using Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\Tutorials\Paging\Client\_Imports.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Tutorials\Paging\Client\Pages\DataGrid.razor"
using Client.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Tutorials\Paging\Client\Pages\DataGrid.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Tutorials\Paging\Client\Pages\DataGrid.razor"
using Common.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Tutorials\Paging\Client\Pages\DataGrid.razor"
using static Common.GLB;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/datagrid")]
    public partial class DataGrid : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Client.Shared.TopBanner>(0);
            __builder.AddAttribute(1, "BannerTxt", "Registro de Amigos");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(3, " Admin only");
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 11 "D:\Tutorials\Paging\Client\Pages\DataGrid.razor"
 if ( InitialLoad)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(4, "<h1> Loading ......</h1>");
#nullable restore
#line 14 "D:\Tutorials\Paging\Client\Pages\DataGrid.razor"
}
else
{        

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "container");
            __builder.AddMarkupContent(7, "<div class=\"row\"><div class=\"col-12 d-flex flex-column align-items-center justify-content-center m-0 p-0\"><h2>Amigos List</h2></div></div>\r\n\r\n        ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "row");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "col-12 d-flex flex-row justify-content-end");
            __builder.OpenElement(12, "button");
            __builder.AddAttribute(13, "type", "button");
            __builder.AddAttribute(14, "class", "btn btn-labeled btn-danger btn-sm mb-1");
            __builder.AddAttribute(15, "data-bs-toggle", "modal");
            __builder.AddAttribute(16, "data-bs-target", "#myModal ");
            __builder.AddAttribute(17, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "D:\Tutorials\Paging\Client\Pages\DataGrid.razor"
                                                                                                            AddNew

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(18, " Add New ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n\r\n                    \r\n                    ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "col-12 d-flex flex-row justify-contents-center");
            __builder.OpenElement(22, "table");
            __builder.AddAttribute(23, "class", "table table-striped table-bordered table-secondary table-hover");
            __builder.AddMarkupContent(24, @"<thead><tr><th>Id</th>
                                                                <th>Name</th>
                                                                <th>Address</th>
                                                                <th>Email</th>
                                                                <th>Phone</th>
                                                                <th style=""text-align:center"">Action</th></tr></thead>
                                            ");
            __builder.OpenElement(25, "tbody");
#nullable restore
#line 46 "D:\Tutorials\Paging\Client\Pages\DataGrid.razor"
                                                         foreach ( AmigoModel a in Amigos)
                                                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(26, "tr");
            __builder.OpenElement(27, "td");
#nullable restore
#line 49 "D:\Tutorials\Paging\Client\Pages\DataGrid.razor"
__builder.AddContent(28, a.RowId);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                                                                        ");
            __builder.OpenElement(30, "td");
#nullable restore
#line 50 "D:\Tutorials\Paging\Client\Pages\DataGrid.razor"
__builder.AddContent(31, a.Nome);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                                                                        ");
            __builder.OpenElement(33, "td");
#nullable restore
#line 51 "D:\Tutorials\Paging\Client\Pages\DataGrid.razor"
__builder.AddContent(34, a.Address);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                                                                        ");
            __builder.OpenElement(36, "td");
#nullable restore
#line 52 "D:\Tutorials\Paging\Client\Pages\DataGrid.razor"
__builder.AddContent(37, a.Email);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                                                                        ");
            __builder.OpenElement(39, "td");
#nullable restore
#line 53 "D:\Tutorials\Paging\Client\Pages\DataGrid.razor"
__builder.AddContent(40, a.Phone);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                                                                        ");
            __builder.OpenElement(42, "td");
            __builder.AddAttribute(43, "style", "text-align:center");
            __builder.OpenElement(44, "button");
            __builder.AddAttribute(45, "type", "button");
            __builder.AddAttribute(46, "class", "btn btn-labeled btn-primary btn-sm");
            __builder.AddAttribute(47, "data-bs-toggle", "modal");
            __builder.AddAttribute(48, "data-bs-target", "#myModal ");
            __builder.AddAttribute(49, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 57 "D:\Tutorials\Paging\Client\Pages\DataGrid.razor"
                                                                                                    () => Update( a)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(50, " Update ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n                                                                                ");
            __builder.OpenElement(52, "button");
            __builder.AddAttribute(53, "type", "button");
            __builder.AddAttribute(54, "class", "btn btn-labeled btn-primary btn-sm");
            __builder.AddAttribute(55, "data-bs-toggle", "modal");
            __builder.AddAttribute(56, "data-bs-target", "#myModal ");
            __builder.AddAttribute(57, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 59 "D:\Tutorials\Paging\Client\Pages\DataGrid.razor"
                                                                                                    () => Delete( a)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(58, " Delete ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 62 "D:\Tutorials\Paging\Client\Pages\DataGrid.razor"
                                                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n\r\n        ");
            __builder.OpenElement(60, "div");
            __builder.AddAttribute(61, "class", "row");
            __builder.OpenElement(62, "div");
            __builder.AddAttribute(63, "class", "col-2 d-flex flex-column justify-content-end");
            __builder.AddMarkupContent(64, "<label style=\"font-size:12px;margin-bottom:0;margin-top:16px\">Current page number</label>\r\n                        ");
            __builder.OpenElement(65, "input");
            __builder.AddAttribute(66, "class", "form-control");
            __builder.AddAttribute(67, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 71 "D:\Tutorials\Paging\Client\Pages\DataGrid.razor"
                                                                CurrentPageNumber

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(68, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => CurrentPageNumber = __value, CurrentPageNumber));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "       \r\n                \r\n                ");
            __builder.OpenElement(70, "div");
            __builder.AddAttribute(71, "class", "col-2 d-flex flex-column justify-content-end");
            __builder.AddMarkupContent(72, "<label style=\"font-size:12px;margin-bottom:0;margin-top:16px\">Number of Rows Per Page</label>          \r\n                        ");
            __builder.OpenElement(73, "input");
            __builder.AddAttribute(74, "type", "number");
            __builder.AddAttribute(75, "class", "form-control");
            __builder.AddAttribute(76, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 76 "D:\Tutorials\Paging\Client\Pages\DataGrid.razor"
                                                                              RecsPerPage

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(77, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => RecsPerPage = __value, RecsPerPage, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n\r\n                <div class=\"col-4 d-flex flex-column justify-content-end\"></div>\r\n\r\n                ");
            __builder.OpenElement(79, "div");
            __builder.AddAttribute(80, "class", "col-2 d-flex flex-column justify-content-end");
            __builder.AddAttribute(81, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 81 "D:\Tutorials\Paging\Client\Pages\DataGrid.razor"
                                                                                   GetPreviousPage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(82, "<button type=\"button\" class=\"btn btn-labeled btn-primary btn-sm\"> Previous </button>");
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n                ");
            __builder.OpenElement(84, "div");
            __builder.AddAttribute(85, "class", "col-2 d-flex flex-column justify-content-end");
            __builder.AddAttribute(86, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 84 "D:\Tutorials\Paging\Client\Pages\DataGrid.razor"
                                                                                   GetNextPage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(87, "<button type=\"button\" class=\"btn btn-labeled btn-primary btn-sm\">   Next   </button>");
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "       \r\n        \r\n                ");
            __builder.OpenElement(89, "div");
            __builder.AddAttribute(90, "class", "col-12 mt-3");
            __builder.OpenElement(91, "textarea");
            __builder.AddAttribute(92, "rows", "1");
            __builder.AddAttribute(93, "style", "width:100%");
#nullable restore
#line 89 "D:\Tutorials\Paging\Client\Pages\DataGrid.razor"
__builder.AddContent(94, Msg);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 93 "D:\Tutorials\Paging\Client\Pages\DataGrid.razor"
}

#line default
#line hidden
#nullable disable
            __builder.OpenElement(95, "div");
            __builder.AddAttribute(96, "id", "myModal");
            __builder.AddAttribute(97, "class", "modal fade");
            __builder.AddAttribute(98, "style", "background-color:transparent");
            __builder.OpenElement(99, "div");
            __builder.AddAttribute(100, "class", "modal-dialog modal-md modal-dialog-centered");
            __builder.AddAttribute(101, "style", "background-color:transparent;");
            __builder.OpenElement(102, "div");
            __builder.AddAttribute(103, "class", "modal-content");
            __builder.AddAttribute(104, "style", "background-color:transparent");
            __builder.OpenElement(105, "div");
            __builder.AddAttribute(106, "class", "modal-body my-0 p-0");
            __builder.OpenComponent<Client.Shared.RegisterForm>(107);
            __builder.AddAttribute(108, "amg", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Common.Models.AmigoModel>(
#nullable restore
#line 103 "D:\Tutorials\Paging\Client\Pages\DataGrid.razor"
                                                                      amg

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(109, "FormAction", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 103 "D:\Tutorials\Paging\Client\Pages\DataGrid.razor"
                                                                                        Action

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(110, "Refresh", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 103 "D:\Tutorials\Paging\Client\Pages\DataGrid.razor"
                                                                                                          Refresh

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 109 "D:\Tutorials\Paging\Client\Pages\DataGrid.razor"
       
        bool InitialLoad = true;
        int CurrentPageNumber = 1;
        int RecsPerPage = 5;
        string Msg = "teste de conteudo";

        private string Action;
        private AmigoModel amg = new();
        List<AmigoModel> Amigos = new();

        protected async override Task OnInitializedAsync()
        {
                Amigos = await GetAllAmigosAsync( CurrentPageNumber, RecsPerPage);  
        
                await base.OnInitializedAsync().ConfigureAwait(false);
                // Avoids Loading message for empty search results 
                InitialLoad = false;
        }

        public async void GetPreviousPage()
        {
                if ( CurrentPageNumber > 1) { CurrentPageNumber--;}
                Amigos = await GetAllAmigosAsync( CurrentPageNumber, RecsPerPage);
                this.StateHasChanged();
        }

        public async void GetNextPage()
        {        
                Amigos = await GetAllAmigosAsync( ++CurrentPageNumber, RecsPerPage);   
                this.StateHasChanged();
        }

        public async void RefreshCurrentPage()
        {        
                Amigos = await GetAllAmigosAsync( CurrentPageNumber, RecsPerPage);   
                this.StateHasChanged();
        }

        protected async Task<List<AmigoModel>> GetAllAmigosAsync( int curPageNumber, int recsPerPage)
        {    
                List<AmigoModel> amg = new();
                try
                {            
                        using ( HttpClient h = new())
                        {
                                h.DefaultRequestHeaders.Clear();
                                h.DefaultRequestHeaders.ConnectionClose = true;
                                //  Define o modo de recebimento dos dados (JSON) . Poderia ser XML por ex;;
                                //  Aqui tem um bom tutorial de JSON : https://www.tutorialspoint.com/json/json_quick_guide.htm
                                h.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                                //  Informa o endereço base (parte fixa) da API
                                h.BaseAddress =  new Uri(  BaseAddress); // Exemplo : https://localhost:44301/

                                //  Envia o request (getasync) com o URI universal resource identifier
                                using (HttpResponseMessage m = await h.GetAsync($"api/Amigos/Gumbo/{curPageNumber}&{recsPerPage}"))
                                {
                                        if (m.IsSuccessStatusCode)
                                        {
                                                //  Recebe a resposta com os dados requisitados e converte no Amigos Model
                                                var dados = await m.Content.ReadAsStringAsync();
                                                amg = Newtonsoft.Json.JsonConvert.DeserializeObject<List<AmigoModel>>(dados);                       
                            
                                                Msg = (amg.Count == 0) ? "Status " + $"{m.StatusCode} - " +"No records found"  
                                                                                          : "Status " + $"{m.StatusCode} - {amg.Count} record(s) to show";
                                        }
                                        else
                                                Msg = "Status " + $"{m.StatusCode} - " + m.ReasonPhrase + BaseAddress;                        
                                }
                        }
                }
                catch (Exception ex) 
                {       
                        Msg = ex.Message + BaseAddress; 
                }  
                //  Send result back
                return amg;
        }

        public void AddNew()
        {
                amg = new AmigoModel();
                Action = "A";
        }

        public void Update( AmigoModel a)
        {
                amg = a;
                Action = "U";
        }
        public void Delete( AmigoModel a)
        {
                amg = a;       
                Action = "D";
        }

        public void Refresh()
        {
                RefreshCurrentPage( );   
                this.StateHasChanged();
        }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591