using System;
namespace testPro
{
    public class Truck : IVehicle, ICompany
    {
        public bool HasBackTrunk { get; set; }
        public int Height { get; set; }

        public string EngineType { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }
        public int Year { get; set; }
        public string Motto { get; set; }
        public string Logo { get; set; }
    }
}
