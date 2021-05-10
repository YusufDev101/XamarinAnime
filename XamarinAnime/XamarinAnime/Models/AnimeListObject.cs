using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinAnime.Models
{
    public class AnimeListObject
    {
        public Datum[] data { get; set; }
        public Meta meta { get; set; }
        public Links links { get; set; }

        public class Meta
        {
            public int count { get; set; }
        }

        public class Links
        {
            public string first { get; set; }
            public string prev { get; set; }
            public string next { get; set; }
            public string last { get; set; }
        }

        public class Datum
        {
            public string id { get; set; }
            public string type { get; set; }
            public Links1 links { get; set; }
            public Attributes attributes { get; set; }
        }

        public class Links1
        {
            public string self { get; set; }
        }

        public class Attributes
        {
            public string slug { get; set; }
            public string canonicalTitle { get; set; }
            public Titles titles { get; set; }
            public Posterimage posterImage { get; set; }
            public string description { get; set; }
            public string averageRating { get; set; }
            public string startDate { get; set; }
            public int popularityRank { get; set; }
            public int ratingRank { get; set; }
            public string youtubeVideoId { get; set; }
        }

        public class Titles
        {
            public string en { get; set; }
            public string en_jp { get; set; }
            public string ja_jp { get; set; }
            public string en_us { get; set; }
        }

        public class Posterimage
        {
            public string tiny { get; set; }
            public string small { get; set; }
            public string medium { get; set; }
            public string large { get; set; }
            public string original { get; set; }
            public Meta1 meta { get; set; }
        }

        public class Meta1
        {
            public Dimensions dimensions { get; set; }
        }

        public class Dimensions
        {
            public Tiny tiny { get; set; }
            public Small small { get; set; }
            public Medium medium { get; set; }
            public Large large { get; set; }
        }

        public class Tiny
        {
            public int width { get; set; }
            public int height { get; set; }
        }

        public class Small
        {
            public int width { get; set; }
            public int height { get; set; }
        }

        public class Medium
        {
            public int width { get; set; }
            public int height { get; set; }
        }

        public class Large
        {
            public int width { get; set; }
            public int height { get; set; }
        }

    }
}
