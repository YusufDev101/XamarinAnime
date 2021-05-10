using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinAnime.Models
{
   public class AnimeCollectionObject
    {
        public string slug { get; set; }
        public string canonicalTitle { get; set; }
        public string en { get; set; }
        public string original { get; set; }
        public string description { get; set; }
        public string averageRating { get; set; }
        public string startDate { get; set; }
        public int popularityRank { get; set; }
        public int ratingRank { get; set; }
        public string youtubeVideoId { get; set; }
    }
}
