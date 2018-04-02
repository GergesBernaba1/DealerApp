
using System.Collections.Generic;
using DealerPlusApp.Data;
using DealerPlusApp.Data.IRepositories;
using DealerPlusApp.Service.IService;

namespace DealerPlusApp.Service.Service
{
   public class MarketService : EntityService<Market>, IMarketService
    {

        IUnitOfWork _unitOfWork;
        IMarketRepository _marketRepository;

        public MarketService(IUnitOfWork unitOfWork, IMarketRepository marketRepository)
            : base(unitOfWork, marketRepository)
        {
            _unitOfWork = unitOfWork;
            _marketRepository = marketRepository;
        }


       
        public Market GetById(long Id)
        {
            return _marketRepository.GetByID(Id);
        }

        public  IEnumerable<Market> GetAllMarkets()
        {

            return _marketRepository.GetAllMarkets();
        }

       public bool AddNewMarket(Market market)
       {
            _marketRepository.AddMarket(market);
            return true;
       }


       public bool DeleteMarket(Market market)
       {

           return _marketRepository.DeleteMarket(market);
       }

       public bool UpdateMarket(Market market)
       {
           return _marketRepository.UpdateMarket(market);
       }

       public IEnumerable<Market> SearchMarkets(string keyword)
       {
           return _marketRepository.SearchMarkets(keyword);
       }


       public int IsMarketNameExist(string marketName, long id)
       {
           return _marketRepository.IsMarketNameExist(marketName,id);
       }


       public int IsMarketPhoneExist(string marketPhone,long id)
       {
           return _marketRepository.IsMarketPhoneExist(marketPhone,id);
           
       }

    }
}
