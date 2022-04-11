using RentMe.DAL;
using RentMe.Model;
using RentMe.Model.Validators;
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
       

        public void AddFurnituresToRent(List<RentFurniture> rentFurnitureList)
        {
            if (rentFurnitureList.Any())
            {
                FurnitureRentalDAL.AddRentalItems(rentFurnitureList);
            }

        }


        public List<RentFurniture> GetRentItem(Member rentMember)
        {
          
               return  FurnitureRentalDAL.GetCartItems(rentMember);
        }

    }

    

}
