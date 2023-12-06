using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace TechStyle
{
    class Catalog : ContentPage
    {
        public Catalog()
        {
            Label header = new Label
            {
                Text = "Каталог",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };
            Label label = new Label
            {
                Text = "Xamarin.Forms позволяет создавать " +
            "пользовательские интерфейсы, являющиеся " +
            "общими для платворм Android и iOS",
                FontSize = Device.GetNamedSize(NamedSize.Large,
            typeof(Label)),
                VerticalOptions = LayoutOptions.CenterAndExpand,
                Margin = new Thickness(10, 0)
            };

            Button nextPageButton = new Button
            {
                Text = "Перейти к просмотру Мастеров",
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            nextPageButton.Clicked += NextPage;
            Button previousPageButton = new Button
            {
                Text = "Вернуться на Главную",
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            previousPageButton.Clicked += PrevPage;
            // Построение страницы
            Title = "Label Demo";
            Content = new StackLayout
            {
                Children =
 {
 header,
 label,
 nextPageButton,
 previousPageButton
 }
            };
            async void NextPage(object sender, EventArgs e)
            {
                await Navigation.PushAsync(new Master());
            }
            async void PrevPage(object sender, EventArgs e)
            {
                await Navigation.PopAsync();
            }
        }
    }
}
