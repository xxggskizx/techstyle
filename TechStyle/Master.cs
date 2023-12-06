using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace TechStyle
{
    class Master : ContentPage
    {
        public Master()
        {
            Label header = new Label
            {
                Text = "Мастера",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };
            BoxView boxView = new BoxView
            {
                Color = Color.Orange,
                WidthRequest = 200,
                HeightRequest = 200,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            Button previousPageButton = new Button
            {
                Text = "Вернуться к Каталогу",
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            previousPageButton.Clicked += PrevPage;
            // Построение страницы
            Title = "BoxView Demo";
            Content = new StackLayout
            {
                Children =
 {
 header,
 boxView,
 previousPageButton
 }
            };
            async void PrevPage(object sender, EventArgs e)
            {
                await Navigation.PopAsync();
            }
        }
    }
}