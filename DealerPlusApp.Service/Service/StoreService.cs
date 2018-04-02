using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DealerPlusApp.Data;
using DealerPlusApp.Data.IRepositories;
using DealerPlusApp.Service.IService;

namespace DealerPlusApp.Service.Service
{
      public class StoreService : EntityService<Store>, IStoreService
    {
        
        IUnitOfWork _unitOfWork;
        IStoreRepository _storeRepository;

        public StoreService(IUnitOfWork unitOfWork, IStoreRepository storeRepository)
            : base(unitOfWork, storeRepository)
        {
            _unitOfWork = unitOfWork;
            _storeRepository = storeRepository;
        }


        public Store GetById(long Id)
        {
            return _storeRepository.GetByID(Id);
        }

        public IEnumerable<Store> GetAllStores(long MarketId)
        {

            return _storeRepository.GetAllStores(MarketId);
        }

        public bool AddNewStore(Store store)
        {
            _storeRepository.AddStore(store);
            return true;
        }


        public bool DeleteStore(Store store)
        {

            return _storeRepository.DeleteStore(store);
        }

        public bool UpdateStore(Store store)
        {
            return _storeRepository.UpdateStore(store);
        }

          public IEnumerable<Store> SearchStores(string keyword, long MarketId)
          {
              return _storeRepository.SearchStores(keyword,MarketId);
              
          }


          public int IsStoreNameExist(string storeName,long id)
          {
              return _storeRepository.IsStoreNameExist(storeName,id);
          }


          public int IsStorePhoneExist(string storePhone,long id)
          {
              return _storeRepository.IsStorePhoneExist(storePhone,id);

          }
    }
}



