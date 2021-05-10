using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinAnime.ViewModels;

namespace XamarinAnime
{
    public partial class MainPage : ContentPage
    {
        private MainViewModel mainViewModel;

        public MainPage()
        {
            InitializeComponent();            
            
            mainViewModel = new MainViewModel();
            BindingContext = mainViewModel;

            DataObject();

        }   

        private async void DataObject()
        {
            try
            {
                await mainViewModel.GetAnime();
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "OK");
            }
        }
    }
}
