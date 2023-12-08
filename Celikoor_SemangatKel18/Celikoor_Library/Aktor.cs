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
<<<<<<< Updated upstream
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
=======
        private DateTime birthDate;
        private string nationality;
        private string filmography; //histori aktor main di film apa
        #endregion

        #region CONSTRUCTOR
        public Aktor(string name, DateTime birthDate, string nationality, string filmography)
        {
            Name = name;
            BirthDate = birthDate;
            Nationality = nationality;
            Filmography = filmography;
>>>>>>> Stashed changes
        }
        #endregion

        #region PROPERTIES
        public string Name { get => name; set => name = value; }
<<<<<<< Updated upstream
        public DateTime Birthdate { get => birthdate; set => birthdate = value; }
=======
        public DateTime BirthDate { get => birthDate; set => birthDate = value; }
>>>>>>> Stashed changes
        public string Nationality { get => nationality; set => nationality = value; }
        public string Filmography { get => filmography; set => filmography = value; }
        #endregion

        #region METHODS

        #endregion
    }
}
