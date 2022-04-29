using RentMe.DAL;
using RentMe.Model;
using RentMe.Model.Validators;
using System.Collections.Generic;

namespace RentMe.Controller
{
    /// <summary>
    /// This class serves as the controller,
    /// mediator between the RentMe application
    /// and the FurnitureDAL.
    /// </summary>
    public class FurnitureController
    {
        /// <summary>
        /// Return furniture using search input.
        /// </summary>
        /// <param name="furniture"></param>
        /// <returns>Searched furniture</returns>
        public List<Furniture> GetFurnitureDetails(Furniture furniture)
        {
            FurnitureValidator.ValidateFurnitureNotNull(furniture);
            return FurnitureDAL.GetFurniture(furniture);
        }

        /// <summary>
        /// Return furniture styles
        /// </summary>      
        /// <returns>List of styles</returns>
        public List<string> GetFurnituresStyle()
        {
            return FurnitureDAL.GetFurnitureStyles();
        }

        /// <summary>
        /// Return furniture Category
        /// </summary>      
        /// <returns>List of Categories</returns>
        public List<string> GetFurnituresCategory()
        {
            return FurnitureDAL.GetFurnitureCategories();
        }
    }
}
