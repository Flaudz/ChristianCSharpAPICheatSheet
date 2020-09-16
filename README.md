# This is a C# Api CheatSheet for my classmate

### Links
[Json To C# Properties](https://json2csharp.com)

*Husk at fjerne alt undtaget det første resultat i json*

### Eksempel
```{
   "page":1,
   "total_results":4,
   "total_pages":1,
   "results":[
      {
         "popularity":1.783,
         "vote_count":7,
         "video":false,
         "poster_path":"\/M7nCUXO0ktZSggHcB1blaiuezc.jpg",
         "id":10505,
         "adult":false,
         "backdrop_path":"\/iuT3GuWJKx7eh3zSW1sotwglKnS.jpg",
         "original_language":"de",
         "original_title":"Lauf um Dein Leben - Vom Junkie zum Ironman",
         "genre_ids":[
            99,
            18
         ],
         "title":"Run for Your Life!",
         "vote_average":5.2,
         "overview":"He lived the junkie's life as a heroin addict. Triathlon transformed him. Biopic of the record breaking Ironman Andreas Niedrig.",
         "release_date":"2008-04-24"
      },
      {
         "popularity":1.211,
         "id":471645,
         "video":false,
         "vote_count":0,
         "vote_average":0,
         "title":"Jakoman and Tetsu",
         "release_date":"1964-02-08",
         "original_language":"ja",
         "original_title":"ジャコ萬と鉄",
         "genre_ids":[
            18
         ],
         "backdrop_path":"\/xqDiPe68EESDmAZOqBpMR4CJr1Z.jpg",
         "adult":false,
         "overview":"In a village subsisting on its herring fishery, a one-eyed criminal named Jakoman terrorizes the inhabitants. One of them, the son of the head of one of the fish companies by the name of Tetsu, decides to overthrow Jakoman and his cohorts.",
         "poster_path":"\/2nclcpSBpbsMJg30GCNE4kBP6U6.jpg"
      },
      {
         "popularity":5.009,
         "vote_count":58,
         "video":false,
         "poster_path":"\/rMgCueGP8Qg24FWhS5AUn8ht2Ik.jpg",
         "id":470360,
         "adult":false,
         "backdrop_path":"\/jgjLLWyW4qF3kkX6wVFHSwna3fy.jpg",
         "original_language":"pl",
         "original_title":"Najlepszy",
         "genre_ids":[
            18
         ],
         "title":"Breaking the Limits",
         "vote_average":8,
         "overview":"Based on true events. In 1980s Poland, Jerzy Górski is a young man who finds the determination to struggle against his drug addiction through athletic training, with the aim of competing in the US Ironman Triathlon.",
         "release_date":"2017-11-17"
      },
      {
         "popularity":11.776,
         "vote_count":292,
         "video":false,
         "poster_path":"\/zeoILvZbBIdxDSRguP2UuZXCHOy.jpg",
         "id":41428,
         "adult":false,
         "backdrop_path":"\/yaiPcHyLzP1hQRmInJ87yRaaS4b.jpg",
         "original_language":"ja",
         "original_title":"鉄男",
         "genre_ids":[
            27,
            878
         ],
         "title":"Tetsuo: The Iron Man",
         "vote_average":6.9,
         "overview":"A \"metal fetishist\", driven mad by the maggots wriggling in the wound he's made to embed metal into his flesh, runs out into the night and is accidentally run down by a Japanese businessman and his girlfriend. The pair dispose of the corpse in hopes of quietly moving on with their lives. However, the businessman soon finds that he is now plagued by a vicious curse that transforms his flesh into iron.",
         "release_date":"1989-07-01"
      }
   ]
}```

Så skriv det sådan her:
```{
   "page":1,
   "total_results":4,
   "total_pages":1,
   "results":[
      {
         "popularity":1.783,
         "vote_count":7,
         "video":false,
         "poster_path":"\/M7nCUXO0ktZSggHcB1blaiuezc.jpg",
         "id":10505,
         "adult":false,
         "backdrop_path":"\/iuT3GuWJKx7eh3zSW1sotwglKnS.jpg",
         "original_language":"de",
         "original_title":"Lauf um Dein Leben - Vom Junkie zum Ironman",
         "genre_ids":[
            99,
            18
         ],
         "title":"Run for Your Life!",
         "vote_average":5.2,
         "overview":"He lived the junkie's life as a heroin addict. Triathlon transformed him. Biopic of the record breaking Ironman Andreas Niedrig.",
         "release_date":"2008-04-24"
      }
   ]
}```
