using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_CSharp_OO.Models
{
    public class Pilote
    {
        #region Champs
        private string _Firstname;
        private string _Lastname;
        private string? _Pseudo;
        #endregion

        #region Getter/Setter -> Encapsulation 
        public string GetFirstname()
        {
            return _Firstname;
        }
        public void SetFirstname(string value)
        {
            _Firstname = value.Trim();
        }

        public string GetLastname()
        {
            return _Lastname;
        }
        public void SetLastname(string value)
        {
            _Lastname = value.Trim();
        }

        public string GetPseudo()
        {
            return _Pseudo ?? GetFirstname() + " " + GetLastname();
        }
        public void SetPseudo(string? value)
        {
            _Pseudo = value;
        }
        #endregion
    }
}
