using RentMe.Model;
using System.Collections.Generic;
using System.Linq;

namespace RentMe.DAL
{
    /// <summary>
    /// This class serves as the Data Access Layer
    /// for the in memory data to hold cart rental items.
    /// </summary>
    public class RentCartDAL
    {
        private static List<RentFurniture> _rentCartItems;
        /// <summary>
        /// Adds the cart items.
        /// </summary>
        /// <param name="itemList">The item list.</param>
        public static void AddCartItems(List<RentFurniture> itemList)
        {
            if (_rentCartItems == null)
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
        /// <summary>
        /// Gets the cart items.
        /// </summary>
        /// <param name="member">The member.</param>
        /// <returns>List<RentFurniture> items to rents</returns>
        public static List<RentFurniture> GetCartItems(Member member)
        {
            if (_rentCartItems == null)
            {
                return _rentCartItems = new List<RentFurniture>();
            }
            return _rentCartItems.FindAll(s => s.FurnitureRentMemberID == (member.MemberID));

        }

        /// <summary>
        /// Updates the cart items.
        /// </summary>
        /// <param name="member">The member.</param>
        public static void UpdateCartItems(Member member)
        {
            if (_rentCartItems.Any())
            {
                _rentCartItems.RemoveAll(s => s.FurnitureRentMemberID == member.MemberID);
            }

        }

        /// <summary>
        /// Removes the cart item.
        /// </summary>
        /// <param name="index">The index.</param>
        public static void RemoveCartItem(int index)
        {
            if (_rentCartItems.Any())
            {
                _rentCartItems.RemoveAt(index);
            }
        }


        /// <summary>
        /// Removes the cart item.
        /// </summary>
        /// <param name="index">The index.</param>
        public static void UpdateCartItem(int index, RentFurniture updateFurniture)
        {
            if (_rentCartItems.Any())
            {
                _rentCartItems[index] = updateFurniture; // replace the value


            }

        }

    }
}
