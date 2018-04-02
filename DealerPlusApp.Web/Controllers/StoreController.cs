using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DealerPlusApp.Data;
using DealerPlusApp.Service.IService;
using Newtonsoft.Json;

namespace DealerPlusApp.Web.Controllers
{
    public class StoreController : Controller
    {
        private IStoreService _storeService;
        private IMarketService _marketService;

        public StoreController(IStoreService storeService,IMarketService marketService)
        {
            _storeService = storeService;
            _marketService = marketService;
        }
        // GET: Store
        public ActionResult Index()
        {
            return View();
        }

        // GET: Store/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Store/Create
        public ActionResult Create()
        {
            List<Market> markets = _marketService.GetAllMarkets().ToList();
            SelectList marketList = new SelectList(markets, "ID", "MarketName");
            ViewBag.marketList = marketList;
            return PartialView();
        }

      

        // POST: Store/Create
        [HttpPost]
        public ActionResult Create(Store store)
        {

            // TODO: Add insert logic here

            _storeService.AddNewStore(store);
            return View("Index");


        }

        // GET: Store/Edit/5
        public ActionResult Edit(long id)
        {
            Store store = _storeService.GetById(id);
            List<Market> markets = _marketService.GetAllMarkets().ToList();
            SelectList marketList = new SelectList(markets, "ID", "MarketName");
            ViewBag.marketList = marketList;
            return PartialView(store);
        }

        // POST: Store/Edit/5
        [HttpPost]
        public ActionResult Edit(Store store)
        {
            _storeService.UpdateStore(store);
            return View("Index");

        }

        // GET: Store/Delete/5
        public ActionResult Delete(int id)
        {
            Store store = _storeService.GetById(id);
            return PartialView(store);
        }

        // POST: Store/Delete/5
        [HttpPost]
        public ActionResult Delete(Store store)
        {
            Store str = _storeService.GetById(store.ID);
            _storeService.DeleteStore(str);
            return View("Index");
            
        }
        [HttpGet]
        public ContentResult GetStoreList(long marketId)
        {
            var result = JsonConvert.SerializeObject(_storeService.GetAllStores(marketId).Where(a => a.IsDeleted != true).ToList(), Formatting.None,
                new JsonSerializerSettings()
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                });

            return Content(result, "application/json");
        }


        [HttpGet]
        public ContentResult SearchStores(string keyword, long marketId)
        {
            var result = JsonConvert.SerializeObject(_storeService.SearchStores(keyword,marketId).ToList(), Formatting.None,
                new JsonSerializerSettings()
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                });

            return Content(result, "application/json");
        }

        [HttpGet]
        public string isStoreNameOrPhoneExist(string storeName, string storePhone,long id)
        {


            return (_storeService.IsStoreNameExist(storeName,id)) + " " + (_storeService.IsStorePhoneExist(storePhone,id));


        }

    }
}
