using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DealerPlusApp.Data;

namespace DealerPlusApp.Service.IService
{
    public interface IMarketService : IEntityService<Market>
    {
        Market GetById(long Id);
        IEnumerable<Market> GetAllMarkets();
        bool AddNewMarket(Market mrk);
        bool DeleteMarket(Market mrk);
        bool UpdateMarket(Market mrk);
        IEnumerable<Market> SearchMarkets(string keyword);
        int IsMarketNameExist(string marketName, long id);
        int IsMarketPhoneExist(string marketPhone, long id);

    }
}



