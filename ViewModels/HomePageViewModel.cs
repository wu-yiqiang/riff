using HtmlAgilityPack;
using riff.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Net;
using System.Text;

namespace riff.ViewModels
{
    class HomePageViewModel
    {
        public ObservableCollection<AlbumModel> AlbumList { get; set; } = new ObservableCollection<AlbumModel>();

        public HomePageViewModel()
        {
            WebClient wc = new WebClient();
            wc.Encoding = Encoding.UTF8;
            string htmlStr = wc.DownloadString("https://music.migu.cn/v5/#/musicLibrary");
            HtmlDocument htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(htmlStr);
            //HtmlNodeCollection liNode = htmlDoc.DocumentNode.SelectNodes("//div[@class='thumb]");
            //Debug.WriteLine(htmlStr);
             
            //if (liNode != null && liNode.Count > 0)
            //{
            //    for (int i = 0; i < 10; i++)
            //    {
            //        var node = liNode[i].ChildNodes[1];
            //        var a = node.ChildNodes[1];
            //        var img = node.ChildNodes[1];
            //        var src = img.Attributes["data-src"].Value;

            //        node = liNode[i].ChildNodes[3];
            //        var name = node.ChildNodes[1].ChildNodes[1].InnerText;
            //        var author = node.ChildNodes[3].ChildNodes[1].InnerText;
            //        var id = node.ChildNodes[5].Attributes["data-id"].Value;
            //        AlbumList.Add(new AlbumModel
            //        {
            //            Id= id,
            //            Cover="https://"+src,
            //            Author= author,
            //            Title=name
            //        });

            //    }
            //}
        }
    }
}
