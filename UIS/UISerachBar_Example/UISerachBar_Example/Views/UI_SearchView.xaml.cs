using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UISerachBar_Example
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UI_SearchView : ContentPage
    {
        public UI_SearchView()
        {
            InitializeComponent();
            SuggestionListView.IsVisible = false;
        }
        public List<string> busqueda = new List<string>()
        {"Hola","holo","Hielo", "David","Todo","Tacos" };
        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            var keyWord = Serach.Text;
            if (keyWord.Length >= 1)
            {

                var listav = busqueda.Where(c => c.ToString().ToLower().StartsWith(keyWord.ToLower()));
                SuggestionListView.ItemsSource = listav;
                SuggestionListView.IsVisible = true;
            }
            else
            {
                SuggestionListView.IsVisible = false;
            }
        }
    }
}