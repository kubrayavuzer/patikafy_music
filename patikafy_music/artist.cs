﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patikafy_music
{
    public class artist
    {
        public string FullName { get; set; }
        public string MusicGenre { get; set; }
        public int ReleaseYear { get; set; }
        public int AlbumSales { get; set; }

        public artist(string fullname, string musicgenre,  int releaseyear, int albumsales)
        {
            FullName = fullname;
            MusicGenre = musicgenre;
            ReleaseYear = releaseyear;
            AlbumSales = albumsales;

        }

    }
}
