using DealerPlusApp.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealerPlusApp.Data.IRepositories
{
    public interface IStoreRepository : IGenericRepository<Store>
    {
        Store GetByID(long Id);
        bool AddStore(Store store);
        bool DeleteStore(Store store);
        bool UpdateStore(Store store);
        IEnumerable<Store> GetAllStores(long MarketId);
        IEnumerable<Store> SearchStores(string keyword, long MarketId);
        int IsStoreNameExist(string storeName,long id);
        int IsStorePhoneExist(string storePhone, long id);
    }
}
