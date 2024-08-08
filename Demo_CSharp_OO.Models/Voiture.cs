using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_CSharp_OO.Models
{
    public class Voiture
    {
        #region Champs
        private string _Marque;
        private string _Modele;
        private Pilote _Pilote;
        #endregion

        #region Propriétés -> Encapsulation
        public string Marque
        {
            get {  return _Marque;}
            set { _Marque = value.Trim(); }
        }
        public string Modele
        {
            get { return _Modele; }
            set { _Modele = value.Trim(); }
        }
        public Pilote Pilote
        {
            get { return _Pilote; }
            set { _Pilote = value; }
        }
        public int Numero { get; set; } // Auto-props

        public string Desc 
        {
            get { return Marque + " " + Modele; }
        }
        #endregion
    }
}
