namespace Cars.Models
{
    public class Images
    {
        public int ID { get; set; }
        public string ImageURL { get; set; }
        public bool IsPrimary { get; set; }
        public int VehiclesID { get; set; }
        public Vehicles Vehicles { get; set; }
    }
}
