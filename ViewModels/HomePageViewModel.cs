using HtmlAgilityPack;
using riff.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Windows.Controls;

namespace riff.ViewModels
{
    class HomePageViewModel
    {
        public ObservableCollection<AlbumModel> NewSongList { get; set; } = new ObservableCollection<AlbumModel>();
        public ObservableCollection<AlbumModel> HotSongList { get; set; } = new ObservableCollection<AlbumModel>();
        public ObservableCollection<AlbumModel> OriginalSongList { get; set; } = new ObservableCollection<AlbumModel>();
        public ObservableCollection<AlbumModel> AlbumList { get; set; } = new ObservableCollection<AlbumModel>();

        //public async Task<string> GetMusicData()
        //{
        //    var url = "https://app.c.nf.migu.cn/column/column-info/h5/v2.0?columnId=75577835";
        //    var json = await _client.GetStringAsync(url);
        //    return json;
        //}
        public void Init()
        {
            for (int i = 1; i < 12; i++)
            {
                if((i % 2) == 1)
                {
                    AlbumList.Add(new AlbumModel
                    {
                        Id = "90625796",
                        Title = "小小的我",
                        Cover = "https://d.musicapp.migu.cn/data/oss/column/00/1w/y6/be320a3b4fa3497ca9624132b378d688.webp",
                        Author = "罗云熙",
                        TragetUrl = "",
                        Index = i
                    });
                    NewSongList.Add(new AlbumModel
                    {
                        Id = "90494921",
                        Title = "Falling 4 U",
                        Cover = "https://d.musicapp.migu.cn/data/oss/column/00/1w/y8/d24887f701284f48a1c7b37864ca226c.webp",
                        Author = "Mr.岑",
                        TragetUrl = "",
                        Index= i
                    });
                    HotSongList.Add(new AlbumModel
                    {
                        Id = "90625796",
                        Title = "小小的我",
                        Cover = "https://d.musicapp.migu.cn/data/oss/column/00/1w/y6/be320a3b4fa3497ca9624132b378d688.webp",
                        Author = "罗云熙",
                        TragetUrl = "",
                        Index = i
                    });
                    OriginalSongList.Add(new AlbumModel
                    {
                        Id = "90625796",
                        Title = "小小的我",
                        Cover = "https://d.musicapp.migu.cn/data/oss/column/00/1w/y6/be320a3b4fa3497ca9624132b378d688.webp",
                        Author = "罗云熙",
                        TragetUrl = "",
                        Index = i
                    });
                }
                else
                {
                    AlbumList.Add(new AlbumModel
                    {
                        Id = "90494921",
                        Title = "Falling 4 U",
                        Cover = "https://d.musicapp.migu.cn/data/oss/column/00/1w/y8/d24887f701284f48a1c7b37864ca226c.webp",
                        Author = "Mr.岑",
                        TragetUrl = "",
                        Index = i
                    });
                    NewSongList.Add(new AlbumModel
                    {
                        Id = "90625796",
                        Title = "小小的我",
                        Cover = "https://d.musicapp.migu.cn/data/oss/column/00/1w/y6/be320a3b4fa3497ca9624132b378d688.webp",
                        Author = "罗云熙",
                        TragetUrl = "",
                        Index = i
                    });
                    HotSongList.Add(new AlbumModel
                    {
                        Id = "90494921",
                        Title = "Falling 4 U",
                        Cover = "https://d.musicapp.migu.cn/data/oss/column/00/1w/y8/d24887f701284f48a1c7b37864ca226c.webp",
                        Author = "Mr.岑",
                        TragetUrl = "",
                        Index = i
                    });
                    OriginalSongList.Add(new AlbumModel
                    {
                        Id = "90494921",
                        Title = "Falling 4 U",
                        Cover = "https://d.musicapp.migu.cn/data/oss/column/00/1w/y8/d24887f701284f48a1c7b37864ca226c.webp",
                        Author = "Mr.岑",
                        TragetUrl = "",
                        Index = i
                    });
                }
            }
        }
        public HomePageViewModel()
        {
            Init();
        }
    }
}
