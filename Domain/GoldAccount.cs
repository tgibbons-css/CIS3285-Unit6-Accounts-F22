using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    internal class GoldAccount : AccountBase
    {
        public override int CalculateRewardPoints(decimal amount)
        {
            return (int)decimal.Floor((Balance / GoldBalanceCostPerPoint) + (amount / GoldTransactionCostPerPoint));
        }

        private const int GoldTransactionCostPerPoint = 5;
        private const int GoldBalanceCostPerPoint = 2000;
    }
}
