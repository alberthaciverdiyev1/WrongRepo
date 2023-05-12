namespace Cars.Models
{
    public class BodyType
    {
        public int ID { get; set; }
        public string Body { get; set; }
        List<Vehicles> Vehicles { get; set; }
    }
}
