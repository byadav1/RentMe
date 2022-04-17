using RentMe.DAL;
using RentMe.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentMe.Controller
{
    public class ReturnTransactionController
    {
        private ReturnTransactionDAL returnTransactionSource;

        public ReturnTransactionController()
        {
            this.returnTransactionSource = new ReturnTransactionDAL();
        }

        /// <summary>
        /// Add return furniture to database
        /// </summary>
        /// <param name="returnFurniture"></param>
        public void AddReturnFurniture(ReturnTransaction returnTransaction)
        {
            if (returnTransaction == null)
            {
                throw new ArgumentException("returnTransaction can't be null");
            }

            this.returnTransactionSource.AddReturnFurniture(returnTransaction);

        }

    }
}
