namespace Cars.Models
{
    public class Vehicles
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int ProducedYear { get; set; }
        public string Engine { get; set; }

        public int BodyTypeID { get; set; }
        public BodyType BodyType { get; set; }
        public List<Images> Images { get; set; }
        public  List<VehicleTags> VehicleTags { get; set; }
         public List<VehicleColors> VehicleColors { get; set; }

    }
}
