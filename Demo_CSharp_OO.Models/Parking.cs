using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_CSharp_OO.Models
{
    public class Parking_Old
    {
        public string Nom { get; set; }
        Dictionary<string, Voiture> voitures = new Dictionary<string, Voiture>();


        public Voiture? GetVoiture(string place)
        {
            Voiture? result = null;
            if (voitures.ContainsKey(place))
            {
                result = voitures[place];
            }
            return result;

            // voitures.TryGetValue(place, out Voiture temp);
            // return temp;
        }

        public void SetVoiture(string place, Voiture? voiture)
        {
            if (voiture is null)
            {
                voitures.Remove(place);
            }
            else if (voitures.ContainsKey(place))
            {
                voitures[place] = voiture;
            }
            else
            {
                voitures.Add(place, voiture);
            }
        }


    }


    public class Parking
    {
        public string Nom { get; set; }
        Dictionary<string, Voiture> voitures = new Dictionary<string, Voiture>();


        public Voiture? this[string place]
        {
            get
            {
                Voiture? result = null;
                if (voitures.ContainsKey(place))
                {
                    result = voitures[place];
                }
                return result;
            }

            set
            {
                if (value is null)
                {
                    voitures.Remove(place);
                }
                else if (voitures.ContainsKey(place))
                {
                    voitures[place] = value;
                }
                else
                {
                    voitures.Add(place, value);
                }
            }
        }

    }

}
