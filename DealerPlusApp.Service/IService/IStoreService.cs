using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DealerPlusApp.Data;

namespace DealerPlusApp.Service.IService
{
   public interface IStoreService : IEntityService<Store>
    {
        Store GetById(long Id);
        IEnumerable<Store> GetAllStores(long MarketId);
        bool AddNewStore(Store str);
        bool DeleteStore(Store str);
        bool UpdateStore(Store str);
        IEnumerable<Store> SearchStores(string keyword, long MarketId);
        int IsStoreNameExist(string storeName,long id);
        int IsStorePhoneExist(string storePhone, long id);
    }
}
