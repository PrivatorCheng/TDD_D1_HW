using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD_D1_HW_Prod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_D1_HW_Prod.Tests
{
    [TestClass()]
    public class MerchandiseUtilityTests
    {
        [TestMethod()]
        public void GetCostSumGroupBy3MerchandiseTest()
        {
            //arrange
            MerchandiseUtility mu = new MerchandiseUtility();
            List<int> expectedCostList = new List<int> { 6, 15, 24, 21 };

            //act
            List<int> actualCostList = mu.GetCostSumGroupBy3Merchandise();

            //assert
            CollectionAssert.AreEqual(expectedCostList, actualCostList);
        }

        [TestMethod()]
        public void GetRevenueSumGroupBy4MerchandiseTest()
        {
            //arrange
            MerchandiseUtility mu = new MerchandiseUtility();
            List<int> expectedRevenueList = new List<int> { 50, 66, 60 };

            //act
            List<int> actualRevenueList = mu.GetRevenueSumGroupBy4Merchandise();

            //assert
            CollectionAssert.AreEqual(expectedRevenueList, actualRevenueList);
        }


    }
}