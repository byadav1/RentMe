using RentMe.DAL;
using RentMe.Model;
using System.Collections.Generic;
using System.Linq;

namespace RentMe.Controller
{
    /// <summary>
    /// This class serves as the controller,
    /// mediator between the RentMe application
    /// and the FurnitureRentalDAL.
    /// </summary>
    public class FurnitureRentController
    {
        /// <summary>
        /// Adds the furnitures to rent.
        /// </summary>
        /// <param name="rentFurnitureList">The rent furniture list.</param>
        public void AddFurnituresToRent(List<RentFurniture> rentFurnitureList)
        {
            if (rentFurnitureList.Any())
            {
                FurnitureRentalDAL.AddRentalItems(rentFurnitureList);
            }
        }      

    }

    

}
