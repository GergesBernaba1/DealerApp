using System.Runtime.Remoting.Messaging;
using DealerPlusApp.Data.IRepositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealerPlusApp.Data.Repositories
{
    public class StoreRepository : GenericRepository<Store>, IStoreRepository
    {
        public StoreRepository(DbContext context)
            : base(context)
        {

        }


        public Store GetByID(long Id)
        {
            return _dbset.Where(x => x.ID == Id).FirstOrDefault();
        }

        public bool AddStore(Store store)
        {
            try
            {
                if (store == null)
                {
                    throw new ArgumentNullException("entity");
                }

                _dbset.Add(store);
                this.SaveEntity();
                return true;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool DeleteStore(Store store)
        {
            try
            {
                store.IsDeleted = true;
                _entities.Entry<Store>(store).State = EntityState.Modified;
                this.SaveEntity();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool UpdateStore(Store store)
        {
            try
            {
                _entities.Entry<Store>(store).State = EntityState.Modified;
                this.SaveEntity();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IEnumerable<Store> GetAllStores(long MarketId)
        {
            return _entities.Set<Store>().Where(a => a.IsDeleted != true && a.MarketID == MarketId).AsEnumerable();

        }



        public IEnumerable<Store> SearchStores(string keyword, long MarketId)
        {
            if (keyword != null)
            {
                return _entities.Set<Store>().Where(a => a.StoreName.ToLower().Contains(keyword.ToLower()) && a.IsDeleted != true && a.MarketID == MarketId).AsEnumerable();
            }

            return GetAllStores(MarketId);
        }



        public int IsStoreNameExist(string storeName,long id)
        {

            Store store = id != -1
              ? _dbset.FirstOrDefault(a => a.StoreName.ToLower() == storeName.ToLower() && a.ID != id)
              : _dbset.FirstOrDefault(a => a.StoreName.ToLower() == storeName.ToLower());
            if (store != null)
            {
                return 1;
            }

            return 0;
        }


        public int IsStorePhoneExist(string storePhone,long id)
        {
            Store store = id != -1
              ? _dbset.FirstOrDefault(a => a.PhoneNumber == storePhone && a.ID != id)
              : _dbset.FirstOrDefault(a => a.PhoneNumber.ToLower() == storePhone.ToLower());
            if (store != null)
            {
                return 1;
            }

            return 0;
        }
    }
}