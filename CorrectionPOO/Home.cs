using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionPOO
{
    public class Home : Realty
    {
        private int rooms;
        private int floor;

        public Home(int _registerNumber, string _location, int _area, double _rent, int _rooms) : base(_registerNumber, _location, _area, _rent)
        {
            rooms = _rooms;
        }
        public override string ToString()
        {
            return base.ToString() + "Nombre de pièces : " + rooms;
        }
    }
}
