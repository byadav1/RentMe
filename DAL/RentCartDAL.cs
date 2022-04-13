using RentMe.Model;

using System.Collections.Generic;
namespace RentMe.DAL
{
    public class RentCartDAL
    {

        private static List<RentFurniture> _rentCartItems = new List<RentFurniture>();


        public static void AddCartItems(List<RentFurniture> itemList)
        {
            _rentCartItems = itemList;
        }
       
        public static List<RentFurniture> GetCartItems()
        {
                    
            return _rentCartItems;

        }
    
    }
}
