#pragma checksum "C:\Users\sinoncarol\Source\Repos\Race_To_21_FinalVersion\Race_To_21_FinalVersion\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73aae2de4dc355266f94eafeeaa0eb2c25fb7d35"
// <auto-generated/>
#pragma warning disable 1591
namespace Race_To_21_FinalVersion.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\sinoncarol\Source\Repos\Race_To_21_FinalVersion\Race_To_21_FinalVersion\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sinoncarol\Source\Repos\Race_To_21_FinalVersion\Race_To_21_FinalVersion\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\sinoncarol\Source\Repos\Race_To_21_FinalVersion\Race_To_21_FinalVersion\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\sinoncarol\Source\Repos\Race_To_21_FinalVersion\Race_To_21_FinalVersion\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\sinoncarol\Source\Repos\Race_To_21_FinalVersion\Race_To_21_FinalVersion\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\sinoncarol\Source\Repos\Race_To_21_FinalVersion\Race_To_21_FinalVersion\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\sinoncarol\Source\Repos\Race_To_21_FinalVersion\Race_To_21_FinalVersion\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\sinoncarol\Source\Repos\Race_To_21_FinalVersion\Race_To_21_FinalVersion\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\sinoncarol\Source\Repos\Race_To_21_FinalVersion\Race_To_21_FinalVersion\_Imports.razor"
using Race_To_21_FinalVersion;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\sinoncarol\Source\Repos\Race_To_21_FinalVersion\Race_To_21_FinalVersion\_Imports.razor"
using Race_To_21_FinalVersion.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\sinoncarol\Source\Repos\Race_To_21_FinalVersion\Race_To_21_FinalVersion\Pages\Counter.razor"
using RaceTo21;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/Game")]
    public partial class Counter : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "PageTitle");
            __builder.AddContent(1, "Race To 21/Register/Game");
            __builder.CloseElement();
            __builder.AddMarkupContent(2, "\r\n\r\n");
            __builder.AddMarkupContent(3, @"<style>
    h1 {
        color: #FF7F50;
    }
    h2 {
        color: #D2691E;
    }

    #title-container {
        text-align: center;
    }

    #subtitle {
        text-align: right;
    }

        #subtitle h2 {
            font-size: 16px;
        }

    .my-button {
        background-color: #008B8B;
        color: white;
        border: none;
        padding: 10px 20px;
        font-size: 16px;
        cursor: pointer;
    }

        .my-button:hover, .my-button.hover {
            background-color: #00FFFF;
        }

    .red-button {
        background-color: #FF8C00;
        color: white;
    }

    .green-button {
        background-color: #006400;
        color: white;
    }
    body {
        background-image: url(""https://i.pinimg.com/564x/24/65/19/24651955c72e896dcf08173589fba6a2.jpg"");
        background-size: cover;
        background-position: center center;
        background-attachment: fixed;
    }
</style>

");
            __builder.AddMarkupContent(4, "<div id=\"title-container\"><h1>Let\'s start</h1></div>");
#nullable restore
#line 63 "C:\Users\sinoncarol\Source\Repos\Race_To_21_FinalVersion\Race_To_21_FinalVersion\Pages\Counter.razor"
 if (Game.players.Count > 0)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "form");
#nullable restore
#line 66 "C:\Users\sinoncarol\Source\Repos\Race_To_21_FinalVersion\Race_To_21_FinalVersion\Pages\Counter.razor"
         foreach (var player in Game.players)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "card");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "card-body");
            __builder.OpenElement(10, "h5");
            __builder.AddAttribute(11, "class", "card-title");
#nullable restore
#line 70 "C:\Users\sinoncarol\Source\Repos\Race_To_21_FinalVersion\Race_To_21_FinalVersion\Pages\Counter.razor"
__builder.AddContent(12, player.name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "h6");
            __builder.AddContent(15, "Point: ");
#nullable restore
#line 71 "C:\Users\sinoncarol\Source\Repos\Race_To_21_FinalVersion\Race_To_21_FinalVersion\Pages\Counter.razor"
__builder.AddContent(16, player.point);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n\r\n                    ");
            __builder.OpenElement(18, "p");
            __builder.AddContent(19, "Status: ");
#nullable restore
#line 73 "C:\Users\sinoncarol\Source\Repos\Race_To_21_FinalVersion\Race_To_21_FinalVersion\Pages\Counter.razor"
__builder.AddContent(20, player.status);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 74 "C:\Users\sinoncarol\Source\Repos\Race_To_21_FinalVersion\Race_To_21_FinalVersion\Pages\Counter.razor"
                     if (player.status == PlayerStatus.active)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(21, "<p>How many cards you want to draw?</p>\r\n                        ");
            __builder.OpenElement(22, "input");
            __builder.AddAttribute(23, "type", "text");
            __builder.AddAttribute(24, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 77 "C:\Users\sinoncarol\Source\Repos\Race_To_21_FinalVersion\Race_To_21_FinalVersion\Pages\Counter.razor"
                                                        player.NumOfCard

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => player.NumOfCard = __value, player.NumOfCard));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                        <div class=\"text-center\"></div>\r\n                       ");
            __builder.OpenElement(27, "button");
            __builder.AddAttribute(28, "type", "button");
            __builder.AddAttribute(29, "class", "red-button");
            __builder.AddAttribute(30, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 81 "C:\Users\sinoncarol\Source\Repos\Race_To_21_FinalVersion\Race_To_21_FinalVersion\Pages\Counter.razor"
                                                                          () => DrawCards(player)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(31, "Draw");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                       ");
            __builder.OpenElement(33, "button");
            __builder.AddAttribute(34, "type", "button");
            __builder.AddAttribute(35, "class", "green-button");
            __builder.AddAttribute(36, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 82 "C:\Users\sinoncarol\Source\Repos\Race_To_21_FinalVersion\Race_To_21_FinalVersion\Pages\Counter.razor"
                                                                            () => Stay(player)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(37, "Stay");
            __builder.CloseElement();
#nullable restore
#line 83 "C:\Users\sinoncarol\Source\Repos\Race_To_21_FinalVersion\Race_To_21_FinalVersion\Pages\Counter.razor"

                    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(38, "<p>Hand:</p>");
#nullable restore
#line 86 "C:\Users\sinoncarol\Source\Repos\Race_To_21_FinalVersion\Race_To_21_FinalVersion\Pages\Counter.razor"
                     foreach (var card in player.cards)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(39, "img");
            __builder.AddAttribute(40, "src", 
#nullable restore
#line 88 "C:\Users\sinoncarol\Source\Repos\Race_To_21_FinalVersion\Race_To_21_FinalVersion\Pages\Counter.razor"
                                   card.ImgUrl

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(41, "alt", 
#nullable restore
#line 88 "C:\Users\sinoncarol\Source\Repos\Race_To_21_FinalVersion\Race_To_21_FinalVersion\Pages\Counter.razor"
                                                      card.ImgUrl

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                        ");
            __builder.OpenElement(43, "p");
#nullable restore
#line 89 "C:\Users\sinoncarol\Source\Repos\Race_To_21_FinalVersion\Race_To_21_FinalVersion\Pages\Counter.razor"
__builder.AddContent(44, card.displayName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 90 "C:\Users\sinoncarol\Source\Repos\Race_To_21_FinalVersion\Race_To_21_FinalVersion\Pages\Counter.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(45, "p");
            __builder.AddContent(46, "Player\'s Score: ");
#nullable restore
#line 91 "C:\Users\sinoncarol\Source\Repos\Race_To_21_FinalVersion\Race_To_21_FinalVersion\Pages\Counter.razor"
__builder.AddContent(47, player.score);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 94 "C:\Users\sinoncarol\Source\Repos\Race_To_21_FinalVersion\Race_To_21_FinalVersion\Pages\Counter.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 97 "C:\Users\sinoncarol\Source\Repos\Race_To_21_FinalVersion\Race_To_21_FinalVersion\Pages\Counter.razor"
}

#line default
#line hidden
#nullable disable
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "d-flex justify-content-between");
            __builder.OpenElement(50, "button");
            __builder.AddAttribute(51, "class", "my-button" + " " + (
#nullable restore
#line 100 "C:\Users\sinoncarol\Source\Repos\Race_To_21_FinalVersion\Race_To_21_FinalVersion\Pages\Counter.razor"
                               (isHovering ? "hover" : "")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(52, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 100 "C:\Users\sinoncarol\Source\Repos\Race_To_21_FinalVersion\Race_To_21_FinalVersion\Pages\Counter.razor"
                                                                         () => NavigationManager.NavigateTo("/Register")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(53, "onmouseover", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 101 "C:\Users\sinoncarol\Source\Repos\Race_To_21_FinalVersion\Race_To_21_FinalVersion\Pages\Counter.razor"
                          () => isHovering = true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(54, "onmouseout", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 102 "C:\Users\sinoncarol\Source\Repos\Race_To_21_FinalVersion\Race_To_21_FinalVersion\Pages\Counter.razor"
                         () => isHovering = false

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(55, "\r\n        Back\r\n    ");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 107 "C:\Users\sinoncarol\Source\Repos\Race_To_21_FinalVersion\Race_To_21_FinalVersion\Pages\Counter.razor"
       
    private bool isHovering = false; //Control button's color when mouse entered

    public void DrawCards(Player player)
    {
        int numOfCards = player.NumOfCard;
        for (int i = 0; i < numOfCards; i++)
        {
            Card card = Game.deck.DealTopCard();//get the last card in the deck

            player.cards.Add(card);//add that card to player's hand
        }
        player.score = Game.ScoreHand(player);
        if (player.score > 21)
        {
            player.status = PlayerStatus.bust;
            CheckWinners();
        }
        else if (player.score == 21)
        {
            player.status = PlayerStatus.win;
            player.point += player.score;
            JSRuntime.InvokeVoidAsync("alert", "Player " + player.name + " has won the game!");
            NavigationManager.NavigateTo("/TakeARest"); //navigate to the next page
        }
        else
        {
            CheckWinners();
        }
    }

    public void Stay(Player player)
    {
        player.status = PlayerStatus.stay;
        CheckWinners();
    }

    private void CheckWinners()
    {
        bool allBust = true;
        bool allStay = true;
        Player winner = null;

        foreach (var player in Game.players)
        {
            if (player.status == PlayerStatus.active)
            {
                allStay = false;
            }

            if (player.status == PlayerStatus.bust)
            {
                continue;
            }

            if (player.score <= 21)
            {
                allBust = false;

                if (winner == null || player.score > winner.score)
                {
                    winner = player;
                }
            }
        }

        if (allBust)
        {
            JSRuntime.InvokeVoidAsync("alert", "All players have busted! There is no winner.");
            NavigationManager.NavigateTo("/GameEnd"); //navigate to the next page
        }
        else if (allStay)
        {
            winner.point += winner.score;
            JSRuntime.InvokeVoidAsync("alert", "Congratulation! The winner is Player " + (Game.players.IndexOf(winner) + 1) + " with a score of " + winner.score + "!");
            NavigationManager.NavigateTo("/GameEnd"); //navigate to the next page
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591