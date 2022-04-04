namespace RentMe.Model
{
    /// <summary>
    /// This class models a RentMe Furniture item.
    /// </summary>
    public class Furniture
    {       
        /// <summary>
        /// Furniture properties.
        /// </summary>
        public int FurnitureID { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Style { get; set; }
        public string Description { get; set; }
        public float DailyRentalRate { get; set; }
        public int Quantity { get; set; }
    }
}
