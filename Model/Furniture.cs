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
        int FurnitureID { get; set; }
        string Name { get; set; }
        string Category { get; set; }
        string Style { get; set; }
        string Description { get; set; }
        float DailyRentalRate { get; set; }
        int Quantity { get; set; }

        public Furniture()
        {

        }

    }
}
