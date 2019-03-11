using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETBrowser.Class
{
  public  class Record
    {
        public string Link { get; set; }
        public DateTime Time { get; set; }

        public Record(string link, DateTime time)
        {
            Link = link;
            Time = time;
        }

        public Record(Record record)
        {
            
            Link = record.Link;
            Time = record.Time;
        }

    }
}
