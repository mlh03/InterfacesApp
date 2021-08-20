using System;
namespace testPro
{
    public class Car : IVehicle, ICompany
    {
        public bool TwoDoor { get; set; }
        public string FiveSeat { get; set; }

        public string EngineType { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }
        public int Year { get; set; }
        public string Motto { get; set; }
        public string Logo { get; set; }
    }
}
