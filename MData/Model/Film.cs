using System;
using System.Collections.Generic;
using System.Text;

namespace MData.Model
{
    public class Film
    {
        public int FilmId { get; set; }
        public string FilmName { get; set; }
        public int FilmTypeId { get; set; }
        public int Episode { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public string FilmLink { get; set; }
        public string FilmStatus { get; set; }
    }
}
