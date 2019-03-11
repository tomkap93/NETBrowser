using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NETBrowser.Class
{
    class Read : History
    {
     public   void ReadHistory()
        {
           
            if (File.Exists(historia) == true)
            {

                try
                {


                    using (FileStream stream = new FileStream(historia, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                    using (StreamReader sw = new StreamReader(stream))
                    {
                        while (sw.EndOfStream == false)
                        {
                            string record = sw.ReadLine();
                            string[] splitRecord = record.Split(';');
                  

                            string link = splitRecord[0];
                            DateTime dateTime = Convert.ToDateTime(splitRecord[1]);

                            records.Add(new Record(link, dateTime));
                        }
                    }
                }
                catch (IOException)
                {

                    MessageBox.Show("Wystąpił błąd podczas odczytu historii", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }
        }
    }
}
