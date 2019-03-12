using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionPOO
{
    abstract public class Realty
    {
        // Protected est un modificateur d'accès modifiable depuis classe et/ou enfant
        private int registerNumber;
        protected string location;
        protected int area;
        protected double rent;

        public int RegisterNumber { get; }

        // Constructeur
        public Realty(int _registerNumber, string _location, int _area, double _rent)
        {
            RegisterNumber = _registerNumber;
            this.location = _location;
            area = _area;
            rent = _rent;
        }
        // Surcharge  de ToString via le modificateur override
        public override string ToString()
        {
            return "Numéro d'enregistrement : " + RegisterNumber + " Localisation : " + location + " Surface : " + area + " Loyer : " + rent;
        }
    }
}
