using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celikoor_Library
{
    public class Aktor
    {
        #region DATAMEMBERS
        private string name;
        private DateTime birthdate;
        private string nationality;
        private string filmography;//histori aktor main di film apa
        #endregion

        #region CONSTRUCTOR
        public Aktor(string name, DateTime birthDate, string nationality, string filmography)
        {
            Name = name;
            Birthdate = birthDate;
            Nationality = nationality;
            Filmography = filmography;
        }
        #endregion

        #region PROPERTIES
        public string Name { get => name; set => name = value; }

        public string Nationality { get => nationality; set => nationality = value; }
        public string Filmography { get => filmography; set => filmography = value; }
        public DateTime Birthdate { get => birthdate; set => birthdate = value; }
        #endregion

        #region METHODS

        #endregion
    }
}
