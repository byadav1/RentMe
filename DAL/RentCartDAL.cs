using RentMe.Model;

using System.Collections.Generic;
using System.Linq;

namespace RentMe.DAL
{
    public class RentCartDAL
    {

        private static List<RentFurniture> _rentCartItems;


        public static void AddCartItems(List<RentFurniture> itemList)
        {

            if (_rentCartItems==null)
            {
                _rentCartItems = new List<RentFurniture>();              
            }
            else if (_rentCartItems.Any())
            {
                _rentCartItems.AddRange(itemList); ;
                return;
            }
            _rentCartItems = itemList;
        }
       
        public static List<RentFurniture> GetCartItems(Member member)
        {
            if (_rentCartItems == null)
            {
                return _rentCartItems = new List<RentFurniture>();
            }
            return _rentCartItems.FindAll(s => s.FurnitureRentMemberID == (member.MemberID));
           

        }
    
    }
}
