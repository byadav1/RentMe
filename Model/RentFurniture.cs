using System;

namespace RentMe.Model
{
    /// <summary>
    /// This class models a RentMe Furniture rental item.
    /// </summary>
    public class RentFurniture
    {       
        /// <summary>
        /// Furniture Renting properties.
        /// </summary>
        public int FurnitureID { get; set; }
        public int FurnitureRentQuantity { get; set; }
        public int FurnitureRentEmployeeID { get; set; }
        public int FurnitureRentMemberID { get; set; }
        public DateTime DueDate { get; set; }
        
        public string Name { get; set; }
        public string Category { get; set; }
        public string Style { get; set; }
        public string Description { get; set; }
        public float RentalAmount { get; set; }
        

    }
}
