using RentMe.DAL;
using RentMe.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentMe.Controller
{
    public class RentCartController
    {


        public void AddFurnituresToRent(List<RentFurniture> rentFurnitureList)
        {
            if (rentFurnitureList.Any())
            {
                RentCartDAL.AddCartItems(rentFurnitureList);
            }

        }


        public List<RentFurniture> GetRentItem(Member memberID)
        {

            return RentCartDAL.GetCartItems(memberID);
        }


        public void UpdateRentalCart(Member member)
        {
            RentCartDAL.UpdateCartItems(member);

        }

        public void DeleteCartItem(int index)
        {
            RentCartDAL.RemoveCartItem(index);

        }
    }
}
