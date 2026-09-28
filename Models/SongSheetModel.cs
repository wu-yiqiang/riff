using System;
using System.Collections.Generic;
using System.Text;

namespace riff.Models
{
    public class SongSheetModel
    {
        public string Header { get; set; }
        public string Icon { get; set; }
        public List<SongModel> Songs { get; set; } = new List<SongModel>();

    }
}
