using System;
namespace testPro
{
    public class Suv: IVehicle, ICompany
    {
        public bool SevenSeater { get; set; }
        public bool MiddleSeat { get; set; }

        public string EngineType { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }
        public int Year { get; set; }
        public string Motto { get; set; }
        public string Logo { get; set; }
    }
}
