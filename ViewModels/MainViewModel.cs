using riff.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace riff.ViewModels
{
    public class MainViewModel
    {
        public ObservableCollection<SongSheetModel> SList { get; set; } = new ObservableCollection<SongSheetModel>();
        public MainViewModel()
        {
            SList.Add(new SongSheetModel()
            {
                Header = "默认菜单",
                Icon = "\ue668"
            });
            SList.Add(new SongSheetModel()
            {
                Header = "本地音乐",
                Icon = "\ue668"
            });
        }
    }
}
