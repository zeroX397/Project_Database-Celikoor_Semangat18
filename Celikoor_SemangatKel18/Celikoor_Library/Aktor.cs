using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celikoor_Library
{
    internal class Aktor
    {
        #region DATAMEMBERS
        private string name;
        private DateTime birthdate;
        private string nationality;
        private string filmography;
        #endregion

        #region CONSTRUCTORS
        public Aktor(string name, DateTime birthdate, string nationality, string filmography)
        {
            this.Name = name;
            this.Birthdate = birthdate;
            this.Nationality = nationality;
            this.Filmography = filmography;
        }
        #endregion

        #region PROPERTIES
        public string Name { get => name; set => name = value; }
        public DateTime Birthdate { get => birthdate; set => birthdate = value; }
        public string Nationality { get => nationality; set => nationality = value; }
        public string Filmography { get => filmography; set => filmography = value; }
        #endregion

        #region METHODS

        #endregion
    }
}
