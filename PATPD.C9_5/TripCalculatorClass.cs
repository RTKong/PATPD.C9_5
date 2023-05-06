using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PATPD.C9_5
{
    public class TripCalculatorClass
    {
        //data fields
        private string destination;
        private double miles;
        private double gallons;

        //constructors
        public TripCalculatorClass()
        { }

        public TripCalculatorClass(string destination, double miles, double gallons)
        {
            this.destination = destination;
            this.miles = miles;
            this.gallons = gallons;
        }


        //accessors and mutator properties
        public string Destination
        {
            get => destination;
            set => destination = value;
        }

        public double Miles
        {
            get => miles;
            set => miles = value;
        }

        public double Gallons
        {
            get => gallons;
            set => gallons = value;
        }

        //methods

        public double MilesPerGallon()
        {
            return miles / gallons;
        }

        public override string ToString()
        {
            return destination +
                "\n"+miles+"\n"+
                gallons+"\n"+
                MilesPerGallon().ToString("N2");
        }

    }
}
