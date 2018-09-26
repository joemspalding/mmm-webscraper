using HtmlAgilityPack;
using Fizzler.Systems.HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace webscraper
{
    static class HistoryScraper
    {


        public static async Task<List<string>> GetFiguresList(string url)
        {
            var peopleList = new List<String>();
            var httpClient = new HttpClient();
            var html = await httpClient.GetStringAsync(url);

            var htmlDoc = new HtmlDocument();
            var page = htmlDoc.DocumentNode;

            var figures = GetPreferred(page);
            Console.WriteLine(figures.OuterHtml);
            //Data Extraction

            foreach (var catprofile in figures)
            {
                foreach (var tile in catprofile.Descendants())
                {
                    //figure out this xpath shit and why this isnt working
                    var inner = tile.SelectNodes("//a[2]")[0];
                    Console.WriteLine(catprofile.OuterHtml);
                }
            }

            return peopleList;

        }

        private static HtmlNode GetPreferred(HtmlNode html)
        {
            html.QuerySelectorAll("div.container");
            html.QuerySelectorAll("div.content");
            html.QuerySelectorAll("div.container-fluid");
            html.QuerySelectorAll("div.row");
            html.QuerySelectorAll("div.col-md-9 col-sm-9 col-xs-12 main main-right");
            html.QuerySelectorAll("div.fp-sinfo fp-sinfo2");
            html.QuerySelectorAll("div.fp-full_info");
            html.QuerySelectorAll("div.fpf-block");
            html.QuerySelectorAll("div.section");
            html.QuerySelectorAll("div.relatedDiv");
            return html;
        }

    }
}
