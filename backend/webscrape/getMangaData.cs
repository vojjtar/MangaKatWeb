using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using System.IO;

using HtmlAgilityPack;
using System.Net.Http;

using backend.ViewModels;

namespace backend.webscrape
{

    public class getMangaInfo
    {
        public static string mangaTitle()
        {
            

            string refer = "";

            //creating new httpclient
            var httpsClient = new HttpClient();
            //requesting <HTML>
            var html = await httpsClient.GetStringAsync(url);


            var htmlDocument = new HtmlAgilityPack.HtmlDocument();
            htmlDocument.LoadHtml(html);

            var title = doc.DocumentNode.SelectSingleNode("/html/body/div[1]/div[2]/div[1]/div[3]/ul/li[1]/h1");
            Console.WriteLine(title.InnerText);

            return (title.InnerText).ToString();
        }


    }
}