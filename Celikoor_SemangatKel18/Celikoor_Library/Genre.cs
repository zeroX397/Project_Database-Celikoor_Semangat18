using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celikoor_Library
{
    public class Genre
    {
        #region DATAMEMBERS
        private string title;
        private string director;
        private DateTime releaseYear;
        private string category;
        private int runtime;//durasi
        #endregion

        #region CONSTRUCTORS
        public Genre(string title, string director, DateTime releaseYear, string category, int runtime)
        {
            this.Title = title;
            this.Director = director;
            this.ReleaseYear = releaseYear;
            this.Category = category;
            this.Runtime = runtime;
        }
        #endregion

        #region PROPERTIES

        public string Title { get => title; set => title = value; }
        public string Director { get => director; set => director = value; }
        public DateTime ReleaseYear { get => releaseYear; set => releaseYear = value; }
        public string Category { get => category; set => category = value; }
        public int Runtime { get => runtime; set => runtime = value; }
        #endregion

        #region METHODS

        #endregion
    }
}
