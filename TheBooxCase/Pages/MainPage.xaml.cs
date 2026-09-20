using TheBooxCase.Models;
using TheBooxCase.PageModels;

namespace TheBooxCase.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageModel model)
        {
            InitializeComponent();
            BindingContext = model;
        }
    }
}