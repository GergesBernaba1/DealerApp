using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DealerPlusApp.Data.Repositories;

namespace DealerPlusApp.Data.IRepositories
{
   public interface IMarketRepository : IGenericRepository<Market>
    {

        Market GetByID(long Id);
        bool AddMarket(Market market);
        bool DeleteMarket(Market market);
        bool UpdateMarket(Market market);
       IEnumerable<Market> GetAllMarkets();
       IEnumerable<Market> SearchMarkets(string keyword);
       int IsMarketNameExist(string marketName,long id);
       int IsMarketPhoneExist(string marketPhone,long id);
    }
}
