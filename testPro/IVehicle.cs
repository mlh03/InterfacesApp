using System;
namespace testPro
{
    public interface IVehicle
    {
        public string EngineType { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }
        public int Year { get; set; }
    }
}
