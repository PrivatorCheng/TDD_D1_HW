using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_D1_HW_Prod
{
    public class MerchandiseUtility
    {
        private List<MerchandiseModel> mList;
        public MerchandiseUtility()
        {
            mList = GetAllMerchandise();
        }

        public List<int> GetCostSumGroupBy3Merchandise()
        {
            List<int> costSumList = new List<int>();
            int groupCnt = 3;

            int tmpCostSum = 0;
            int tmpGroup = 0;
            foreach (MerchandiseModel m in mList)
            {
                tmpGroup += 1;
                tmpCostSum += m.Cost;
                if (tmpGroup == groupCnt)
                {
                    costSumList.Add(tmpCostSum);
                    tmpGroup = 0;
                    tmpCostSum = 0;
                }
            }
            if (tmpGroup != groupCnt)
            {
                costSumList.Add(tmpCostSum);
            }

            return costSumList;
        }

        public List<int> GetRevenueSumGroupBy4Merchandise()
        {
            List<int> revenueSumList = new List<int>();
            int groupCnt = 4;

            int tmpRevenueSum = 0;
            int tmpGroup = 0;
            foreach (MerchandiseModel m in mList)
            {
                tmpGroup += 1;
                tmpRevenueSum += m.Revenue;
                if (tmpGroup == groupCnt)
                {
                    revenueSumList.Add(tmpRevenueSum);
                    tmpGroup = 0;
                    tmpRevenueSum = 0;
                }
            }
            if (tmpGroup != groupCnt)
            {
                revenueSumList.Add(tmpRevenueSum);
            }
            return revenueSumList;
        }


        private List<MerchandiseModel> GetAllMerchandise()
        {
            MerchandiseDao md = new MerchandiseDao();
            List<MerchandiseModel> mList = md.GetAllMerchandise();

            return mList;
        }
    }
}
