namespace Motosalon.Models
{
    /// <summary>
    /// https://en.wikipedia.org/wiki/Motorcycle
    /// </summary>
    public class MotorcycleBaseClass
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public string FuelType { get; set; }
        public virtual int Power { get; }
    }
}
    