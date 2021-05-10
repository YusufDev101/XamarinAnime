using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace XamarinAnime.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        #region Properties

        public string ApplicationName { get; set; } = "Xam Anime";

        #endregion

        public MainViewModel()
        {
            // Get screen width.
            ScreenWidth = Convert.ToInt32(App.ScreenHeight);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        private int _screenWidth;
        public int ScreenWidth
        {
            get
            {
                return _screenWidth;
            }
            set
            {
                _screenWidth = value;
                OnPropertyChanged();
            }
        }




    }
}
