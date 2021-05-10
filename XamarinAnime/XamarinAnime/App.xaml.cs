using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinAnime.HttpHelpers;

namespace XamarinAnime
{
    public partial class App : Application
    {
        public static int ScreenHeight { get; set; }
        public static int ScreenWidth { get; set; }

        public static HttpWebRequest HttpWebRequest { get; private set; }

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
