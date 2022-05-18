namespace Motosalon.Models
{
    /// <summary>
    /// https://en.wikipedia.org/wiki/Motorcycle
    /// </summary>
    public abstract class MotorcycleBaseClass
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string FuelType { get; set; }
        public abstract int Power { get; }
    }
}
    