using DealerPlusApp.Data;
using DealerPlusApp.Service.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace DealerPlusApp.Web.Controllers
{
    public class MarketController : Controller
    {
        IMarketService _marketService;
        // testing kareeem mostafa pull
        public MarketController(IMarketService marketService)
        {
            _marketService = marketService;
        }
        
        // GET: Market
        public ActionResult Index()
        {
           // IEnumerable<Market> markets = _marketService.GetAll();
            return View();
        }

        // GET: Market/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Market/Create
        [HttpGet]
        public ActionResult Create()
        {
            return PartialView();
        }

        // POST: Market/Create
        [HttpPost]
        public ActionResult Create(Market market)
        {

          
                // TODO: Add insert logic here
                //market.IsDeleted = false;
                //market.UpdatedAuditBy = "kareem";
                //market.UpdatedAuditDate = DateTime.Now.Date;
                //market.CreatedAuditBy = "kareem";
                //market.CreatedAuditDate = DateTime.Now.Date;
                _marketService.AddNewMarket(market);
                return View("Index");
            


        }
        
        public ActionResult MarketList()
        {
            ViewBag.count = _marketService.GetAllMarkets().Count();
            return View(_marketService.GetAllMarkets());
        }
        // GET: Market/Edit/5
        public ActionResult Edit(int id)
        {
            Market market = _marketService.GetById(id);
            return PartialView(market);
        }

        // POST: Market/Edit/5
        [HttpPost]
        public ActionResult Edit(Market market)
        {
            _marketService.UpdateMarket(market);
            return View("Index");

        }

        // GET: Market/Delete/5
        public ActionResult Delete(int id)
        {
            Market market = _marketService.GetById(id);
            if (market.Stores.Count != 0)
            {
                ViewBag.hasStores = true;
                
            }
            else
            {
                ViewBag.hasStores = false;
                
            }

            return PartialView(market);
           
        }

        // POST: Market/Delete/5
        [HttpPost]
        public ActionResult Delete(Market market)
        {
          
             Market mrk = _marketService.GetById(market.ID);
            _marketService.DeleteMarket(mrk);
            return View("Index");
        }



  

        [HttpGet]
        public ContentResult SearchMarkets(string keyword)
        {
            // return Json(_marketService.GetById(id).Stores.ToList(), JsonRequestBehavior.AllowGet);
            var result = JsonConvert.SerializeObject(_marketService.SearchMarkets(keyword).ToList(), Formatting.None,
                new JsonSerializerSettings()
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                });

            return Content(result, "application/json");
        }



        [HttpGet]
        public string isMarketNameOrPhoneExist(string marketName,string marketPhone,long id)
        {


            return (_marketService.IsMarketNameExist(marketName,id)) + " " +(_marketService.IsMarketPhoneExist(marketPhone,id));


        }



      
    }
}
