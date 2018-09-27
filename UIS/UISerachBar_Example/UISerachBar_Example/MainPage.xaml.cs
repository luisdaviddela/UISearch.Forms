using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace UISerachBar_Example
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}
        //protected override void OnAppearing()
        //{
        //    var page = new ContentPage { Title = "Title" };
        //    NavigationPage.SetHasNavigationBar(page, false);
        //    var navigationPage = new NavigationPage(page);
        //    base.OnAppearing();
        //}
        void RefButtonClicked(object sender, EventArgs e)
        {
            //Navigation.PopModalAsync(true);
            DisplayAlert("Pop Up", "Message", "Ok");
        }
    }
}
