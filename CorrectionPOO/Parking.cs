using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionPOO
{
    public class Parking : Realty
    {
        public Parking(int _registerNumber, string _location, int _area, double _rent) : base(_registerNumber, _location, _area, _rent)
        {
        }
    }
}
