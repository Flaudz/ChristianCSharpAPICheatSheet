using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Net;
using System.Text;
using static ChristianCSharpAPICheatSheet.Movie;

namespace ChristianCSharpAPICheatSheet
{
    public class ApiRequest
    {
        public Root GetMovies()
        {
            string json = new WebClient().DownloadString(@"https://api.themoviedb.org/3/search/movie?api_key=0a34d1c5f077444133ab367be386561a&language=en-US&query=Iron-Man&page=1&include_adult=false");
            Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(json);
            return myDeserializedClass;
        }
    }
}
