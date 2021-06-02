using Xamarin.Forms;
using XamarinUnitTesting.ViewModels;

namespace XamarinUnitTesting
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel();
        }
    }
}
