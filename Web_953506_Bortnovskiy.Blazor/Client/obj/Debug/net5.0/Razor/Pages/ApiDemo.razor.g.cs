#pragma checksum "D:\Новая папка\Web_953506_Bortnovskiy\Web_953506_Bortnovskiy.Blazor\Client\Pages\ApiDemo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c62de6490b09c3bd2e82fb98ae50455184d3bece"
// <auto-generated/>
#pragma warning disable 1591
namespace Web_953506_Bortnovskiy.Blazor.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Новая папка\Web_953506_Bortnovskiy\Web_953506_Bortnovskiy.Blazor\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Новая папка\Web_953506_Bortnovskiy\Web_953506_Bortnovskiy.Blazor\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Новая папка\Web_953506_Bortnovskiy\Web_953506_Bortnovskiy.Blazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Новая папка\Web_953506_Bortnovskiy\Web_953506_Bortnovskiy.Blazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Новая папка\Web_953506_Bortnovskiy\Web_953506_Bortnovskiy.Blazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Новая папка\Web_953506_Bortnovskiy\Web_953506_Bortnovskiy.Blazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Новая папка\Web_953506_Bortnovskiy\Web_953506_Bortnovskiy.Blazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Новая папка\Web_953506_Bortnovskiy\Web_953506_Bortnovskiy.Blazor\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Новая папка\Web_953506_Bortnovskiy\Web_953506_Bortnovskiy.Blazor\Client\_Imports.razor"
using Web_953506_Bortnovskiy.Blazor.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Новая папка\Web_953506_Bortnovskiy\Web_953506_Bortnovskiy.Blazor\Client\_Imports.razor"
using Web_953506_Bortnovskiy.Blazor.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Новая папка\Web_953506_Bortnovskiy\Web_953506_Bortnovskiy.Blazor\Client\_Imports.razor"
using Web_953506_Bortnovskiy.Blazor.Client.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Новая папка\Web_953506_Bortnovskiy\Web_953506_Bortnovskiy.Blazor\Client\Pages\ApiDemo.razor"
using Web_953506_Bortnovskiy.Blazor.Client.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/apidemo")]
    public partial class ApiDemo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.OpenComponent<Web_953506_Bortnovskiy.Blazor.Client.Components.DishesList>(2);
            __builder.AddAttribute(3, "SelectedObjectChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 8 "D:\Новая папка\Web_953506_Bortnovskiy\Web_953506_Bortnovskiy.Blazor\Client\Pages\ApiDemo.razor"
                                       ShowDetails

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "Dishes", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Web_953506_Bortnovskiy.Blazor.Client.Models.ListViewModel>>(
#nullable restore
#line 7 "D:\Новая папка\Web_953506_Bortnovskiy\Web_953506_Bortnovskiy.Blazor\Client\Pages\ApiDemo.razor"
                               Dishes

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "DishesChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Collections.Generic.IEnumerable<Web_953506_Bortnovskiy.Blazor.Client.Models.ListViewModel>>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Collections.Generic.IEnumerable<Web_953506_Bortnovskiy.Blazor.Client.Models.ListViewModel>>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Dishes = __value, Dishes))));
            __builder.CloseComponent();
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.OpenComponent<Web_953506_Bortnovskiy.Blazor.Client.Components.DishDetails>(7);
            __builder.AddAttribute(8, "Dish", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Web_953506_Bortnovskiy.Blazor.Client.Models.DetailsViewModel>(
#nullable restore
#line 9 "D:\Новая папка\Web_953506_Bortnovskiy\Web_953506_Bortnovskiy.Blazor\Client\Pages\ApiDemo.razor"
                             SelectedDish

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "DishChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Web_953506_Bortnovskiy.Blazor.Client.Models.DetailsViewModel>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Web_953506_Bortnovskiy.Blazor.Client.Models.DetailsViewModel>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => SelectedDish = __value, SelectedDish))));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "D:\Новая папка\Web_953506_Bortnovskiy\Web_953506_Bortnovskiy.Blazor\Client\Pages\ApiDemo.razor"
       
    [Parameter]
    public IEnumerable<ListViewModel> Dishes { get; set; }
    protected override async Task OnInitializedAsync()
    {
        Dishes = await
       client.GetFromJsonAsync<IEnumerable<ListViewModel>>("api/dishes");
    }

    [Parameter]
    public DetailsViewModel SelectedDish { get; set; }
    private async Task ShowDetails(int id)
    {
        SelectedDish = await
        client.GetFromJsonAsync<DetailsViewModel>($"api/dishes/{id}");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient client { get; set; }
    }
}
#pragma warning restore 1591
