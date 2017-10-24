using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using Demo1.Common;
using Demo1.Model;

namespace Demo1.Hubs
{
    [HubName("stockTickerMini")]
    public class StockTickerHub : Hub
    {
        private readonly StockTicker  _stockTicker;
        public void Hello()
        {
            Clients.All.hello();
        }

        public StockTickerHub() : this(StockTicker.Instance ) { }

        public StockTickerHub (StockTicker stockTicker)
        {
            _stockTicker = stockTicker;
        }

        public IEnumerable<Stock> GetAllStocks()
        {
            return _stockTicker.GetAllStocks();
        }
    }
}