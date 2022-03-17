using HtmlAgilityPack;
using HtmlAgilityPack.CssSelectors.NetCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Nutrition_App.Services.Scraping
{
    class Scraper
    {
        public async Task<List<string>> GetProducts(int number, string ProductSearch, int PageNumber)
        {
            List<string> list = new List<string>(); // Output list

            var web = new HtmlWeb();

            var document = await web.LoadFromWebAsync("http://www.ilewazy.pl/produkty/page/" + PageNumber + "/q/" + ProductSearch + "/");

            var ProductsAmount = document.QuerySelectorAll(".span3").Count - 2; // Products amount by class name

            if (number >= ProductsAmount)
            {
                return list;
            }

            if (ProductsAmount > 17)
            {
                if (number == 4 || number == 17)
                { number += 1; }
            }
            else
            {
                if (number == 4)
                { number += 1; }
            }

            string Name = document.QuerySelector($"#thumbnails > li:nth-child({number}) > div.subtitle").InnerText;

            string GRow = document.QuerySelector($"#thumbnails > li:nth-child({number}) > div.product-params > div > div > span").InnerText;
            string KcalRow = document.QuerySelector($"#thumbnails > li:nth-child({number}) > div.product-params > div > ul > li:nth-child(1)").InnerText;
            string BRow = document.QuerySelector($"#thumbnails > li:nth-child({number}) > div.product-params > div > ul > li:nth-child(2)").InnerText;
            string TRow = document.QuerySelector($"#thumbnails > li:nth-child({number}) > div.product-params > div > ul > li:nth-child(3)").InnerText;
            string WRow = document.QuerySelector($"#thumbnails > li:nth-child({number}) > div.product-params > div > ul > li:nth-child(4)").InnerText;

            list.Add(Name);
            list.Add(KcalRow);
            list.Add(GRow);
            list.Add(BRow);
            list.Add(TRow);
            list.Add(WRow);

            return list;
        }

    }
}
