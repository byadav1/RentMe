using RentMe.Model;

using System.Collections.Generic;
using System.Linq;

namespace RentMe.DAL
{
    public class RentCartDAL
    {

        private static List<RentFurniture> _rentCartItems;

        public RentCartDAL()
        {
            
        }


        public static void AddCartItems(List<RentFurniture> itemList)
        {

            if (_rentCartItems==null)
            {
                _rentCartItems = new List<RentFurniture>();
                _rentCartItems = itemList;
            }
            else if (_rentCartItems.Any())
            {
                _rentCartItems.AddRange(itemList); ;
                return;
            }
           


        }
       
        public static List<RentFurniture> GetCartItems()
        {
                    
            return _rentCartItems;

        }
    
    }
}
