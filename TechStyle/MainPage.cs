using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace TechStyle
{
    class CreateOrder : ContentPage
    {
        public CreateOrder()
        {
            Label header = new Label
            {
                Text = "Главная",
                FontSize = 40,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };
            Button button1 = new Button
            {
                Text = "Каталог",
                Font = Font.SystemFontOfSize(NamedSize.Large),
                BorderWidth = 1,
                WidthRequest = 400
            };
            button1.Clicked += async (sender, args) =>
            await Navigation.PushAsync(new Catalog());
            Button button2 = new Button
            {
                Text = "Мастера",
                Font = Font.SystemFontOfSize(NamedSize.Large),
                BorderWidth = 1,
                WidthRequest = 400
            };
            button2.Clicked += async (sender, args) =>
            await Navigation.PushAsync(new Master());
            // Построение страницы
            Title = "ТехноСтиль";
            Content = new StackLayout
            {
                Children =
 {
 header,
 new StackLayout
 {
 HorizontalOptions = LayoutOptions.Center,
 Children =
 {
 button1,
 button2
 }
 }
 }
            };
        }
    }
}