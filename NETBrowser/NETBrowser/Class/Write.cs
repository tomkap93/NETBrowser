using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NETBrowser.Class
{
    class Write : History
    {
       public void WriteHistory()

        {
            FileMode tryb = (File.Exists(historia) == false) ? FileMode.CreateNew : FileMode.Create;


            try
            {
                using (FileStream stream = new FileStream(historia, tryb))
                using (StreamWriter sw = new StreamWriter(stream))
                {
                    foreach (var item in records)
                    {

                        string record = item.Link + ";" + item.Time.ToLongDateString();
                        sw.WriteLine(record);
                    }
                }
            }
            catch (IOException)
            {

                MessageBox.Show("Wystąpił błąd podczas zapisu historii", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
