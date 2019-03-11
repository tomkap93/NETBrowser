using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETBrowser.Class
{
    class History
    {
       static public  List<Record> records = new List<Record>();
       protected string historia = Environment.CurrentDirectory + "\\historia.txt";

       static public Record AddRecord(string link)
        {
            DateTime time = DateTime.Now;

            Record record = new Record(link,time);
            records.Add(record);
            return record;
        }
    }
}
