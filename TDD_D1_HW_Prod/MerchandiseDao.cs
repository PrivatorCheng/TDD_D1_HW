using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_D1_HW_Prod
{
    internal class MerchandiseDao
    {
        internal List<MerchandiseModel> GetAllMerchandise()
        {
            return new List<MerchandiseModel>()
            {
                new MerchandiseModel {Id=1, Cost = 1, Revenue = 11, SellPrice = 21 },
                new MerchandiseModel {Id=2, Cost = 2, Revenue = 12, SellPrice = 22 },
                new MerchandiseModel {Id=3, Cost = 3, Revenue = 13, SellPrice = 23 },
                new MerchandiseModel {Id=4, Cost = 4, Revenue = 14, SellPrice = 24 },
                new MerchandiseModel {Id=5, Cost = 5, Revenue = 15, SellPrice = 25 },
                new MerchandiseModel {Id=6, Cost = 6, Revenue = 16, SellPrice = 26 },
                new MerchandiseModel {Id=7, Cost = 7, Revenue = 17, SellPrice = 27 },
                new MerchandiseModel {Id=8, Cost = 8, Revenue = 18, SellPrice = 28 },
                new MerchandiseModel {Id=9, Cost = 9, Revenue = 19, SellPrice = 29 },
                new MerchandiseModel {Id=10, Cost = 10, Revenue = 20, SellPrice = 30 },
                new MerchandiseModel {Id=11, Cost = 11, Revenue = 21, SellPrice = 31 }
            };
        } 
    }
}
