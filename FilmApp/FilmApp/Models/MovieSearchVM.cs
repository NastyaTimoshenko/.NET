using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace FilmApp.Models
{
    public class MovieSearchVM
    {

        public List<Movie> Movies;
        public SelectList Genres;
        public string MovieGenre { get; set; }
        public string SearchString {get; set;}

        public string Stars { get; set; }

    }
}
