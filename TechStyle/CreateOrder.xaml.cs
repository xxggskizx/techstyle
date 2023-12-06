using Xamarin.Forms;
namespace TechStyle
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        void OnColorChanged(object sender, CheckedChangedEventArgs e)
        {
            RadioButton button = sender as RadioButton;
            colorLabel.Text = $"Ваш любимый цвет: {button.Content }";
        }
        void OnFruitChanged(object sender, CheckedChangedEventArgs e)
        {
            RadioButton button = sender as RadioButton;
            fruitLabel.Text = $"Ваш любимый фрукт: {button.Content }";
        }
    }
}
