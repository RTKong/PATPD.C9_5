
using System.Globalization;

namespace PATPD.C4_6
{
    public class Trip
    {
        //fields
        private string destination;
        private double distanceTravelled;
        private double costOfGasoline;
        private double totalGallonsConsumed;

        //properties
        public string Destination
        {
            set => destination = value;
            get => destination;
        }

        public double DistanceTravelled
        {
            set => distanceTravelled = value;
            get => distanceTravelled;
        }

        public double CostOfGasoline
        {
            set => costOfGasoline = value;
            get => costOfGasoline;
        }

        public double TotalGallonsConsumed
        {
            set => totalGallonsConsumed = value;
            get => totalGallonsConsumed;
        }

        //constructors
        //default
        public Trip()
        {}

        //constructor with all arguments
        public Trip(string dest, double distance, double gascost, double gallonsused)
        {
            destination = dest;
            distanceTravelled = distance;
            costOfGasoline = gascost;
            totalGallonsConsumed = gallonsused;
        }

        //methods
        public double CalculateMilesPerGallon()
        {
            return distanceTravelled / costOfGasoline;
        }

        public double CostPerMile()
        {
            return costOfGasoline / totalGallonsConsumed;
        }

        public override string ToString()
        {
            return "Destination: "+destination+
                "\nDistance Travelled: "+distanceTravelled+" miles"+
                "\nCost of Gas: "+costOfGasoline.ToString("C")+
                "\nGallons Used: "+totalGallonsConsumed+" gallons"+
                "\nMiles Per Gallon: "+CalculateMilesPerGallon().ToString("F2")+
                "\nCost per Mile: "+CostPerMile().ToString("C");
        }

    }
}
