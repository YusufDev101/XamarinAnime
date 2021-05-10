using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinAnime.HttpHelpers
{
    public class HttpHelpers
    {
        public static string BaseUrl { get; private set; } = @"https://kitsu.io/api/edge";
        public static string SearchUrl { get; private set; } = @"https://kitsu.io/api/edge/anime?filter[text]=";
        public static string PagingUrl { get; private set; } = "https://kitsu.io/api/edge/anime?page[limit]=5&page[offset]=0";
        public static string ImageUrl { get; private set; } = "https://kitsu.io/api/edge/anime/anime?filter=";
        public static string PopularAnimeUrl { get; private set; } = "https://kitsu.io/api/edge/anime?fields%5Banime%5D=slug%2CcanonicalTitle%2Ctitles%2CposterImage%2Cdescription%2CaverageRating%2CstartDate%2CpopularityRank%2CratingRank%2CyoutubeVideoId&page%5Blimit%5D=20&page%5Boffset%5D=20&sort=-user_count";
        public static string EpisodeUrl { get; private set; } = "https://kitsu.io/api/edge/anime/1/relationships/episodes";
    }
}
