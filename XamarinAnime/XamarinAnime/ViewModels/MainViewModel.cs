using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using XamarinAnime.Models;

namespace XamarinAnime.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        #region Properties

        public string ApplicationName { get; set; } = "Xam Anime";

        //private AnimeListObject animeListObject;

        public ObservableCollection<AnimeCollectionObject> animeCollectionObject;
        public ObservableCollection<AnimeCollectionObject> AnimeCollectionObject { get { return animeCollectionObject; } }

        #endregion

        public MainViewModel()
        {
            // Get screen width.
            ScreenWidth = Convert.ToInt32(App.ScreenHeight);

            animeCollectionObject = new ObservableCollection<AnimeCollectionObject>();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public async Task GetAnime()
        {
            try
            {
                IsBusy = true;

                // Var call.
                var animeListObjectData = await App.HttpWebRequest.GetPopularAnime();

                Console.WriteLine(animeListObjectData.data);

                foreach (var item in animeListObjectData.data)
                {
                    animeCollectionObject.Add(new Models.AnimeCollectionObject
                    {
                        slug = item.attributes.slug,
                        canonicalTitle = item.attributes.canonicalTitle,
                        en = item.attributes.titles.en,
                        original = item.attributes.posterImage.original,
                        description = item.attributes.description,
                        averageRating = item.attributes.averageRating,
                        startDate = item.attributes.startDate,
                        popularityRank = item.attributes.popularityRank,
                        ratingRank = item.attributes.ratingRank,
                        youtubeVideoId = item.attributes.youtubeVideoId
                    });
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                IsBusy = false;
            }
        }

        private bool _isBusy;
        public bool IsBusy
        {
            get
            {
                return _isBusy;
            }
            set
            {
                _isBusy = value;
                OnPropertyChanged();
            }
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
