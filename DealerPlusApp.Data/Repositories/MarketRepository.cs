using DealerPlusApp.Data.IRepositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealerPlusApp.Data.Repositories
{
    public class MarketRepository : GenericRepository<Market>, IMarketRepository
    {
        public MarketRepository(DbContext context)
            : base(context)
        {

        }

        public Market GetByID(long Id)
        {
            return _dbset.FirstOrDefault(x => x.ID == Id);

        }

        public bool AddMarket(Market market)
        {
            try
            {
                if (market == null)
                {
                    throw new ArgumentNullException("entity");
                }

                _dbset.Add(market);
                this.SaveEntity();
                return true;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool DeleteMarket(Market market)
        {
            try
            {
                market.IsDeleted = true;
                _entities.Entry<Market>(market).State = EntityState.Modified;
                this.SaveEntity();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool UpdateMarket(Market market)
        {
            try
            {
                _entities.Entry<Market>(market).State = EntityState.Modified;
                this.SaveEntity();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }



        public IEnumerable<Market> GetAllMarkets()
        {
            return _entities.Set<Market>().Where(a => a.IsDeleted != true).AsEnumerable();

        }

        public IEnumerable<Market> SearchMarkets(string keyword)

        {
            if (keyword != null)
            {
                return
                    _entities.Set<Market>()
                        .Where(a => a.MarketName.ToLower().Contains(keyword.ToLower()) && a.IsDeleted != true)
                        .AsEnumerable();
            }

            return GetAllMarkets();
        }



        public int IsMarketNameExist(string marketName, long id)
        {
            Market market = id != -1
                ? _dbset.FirstOrDefault(a => a.MarketName.ToLower() == marketName.ToLower() && a.ID != id)
                : _dbset.FirstOrDefault(a => a.MarketName.ToLower() == marketName.ToLower());
            if (market != null)
            {
                return 1;
            }

            return 0;
        }


        public int IsMarketPhoneExist(string marketPhone, long id)
        {
            Market market = id != -1
                ? _dbset.FirstOrDefault(a => a.PhoneNumber.ToLower() == marketPhone.ToLower() && a.ID != id)
                : _dbset.FirstOrDefault(a => a.PhoneNumber.ToLower() == marketPhone.ToLower());
            if (market != null)
            {
                return 1;
            }

            return 0;


        }
    }
}
