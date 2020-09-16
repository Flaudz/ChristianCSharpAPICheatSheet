﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ChristianCSharpAPICheatSheet
{
    public class Movie
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
        public class Result
        {
            public double popularity { get; set; }
            public int vote_count { get; set; }
            public bool video { get; set; }
            public string poster_path { get; set; }
            public int id { get; set; }
            public bool adult { get; set; }
            public string backdrop_path { get; set; }
            public string original_language { get; set; }
            public string original_title { get; set; }
            public List<int> genre_ids { get; set; }
            public string title { get; set; }
            public double vote_average { get; set; }
            public string overview { get; set; }
            public string release_date { get; set; }
        }

        public class Root
        {
            public int page { get; set; }
            public int total_results { get; set; }
            public int total_pages { get; set; }
            public List<Result> results { get; set; }
        }


    }
}
