using NETBrowser.Class;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ListView;

namespace NETBrowser
{
    public partial class NETBrowser : Form
    {
        
     
        #region Zmienne
        int widthHistory = 248;
      
        #endregion

        #region Konstruktor
        public NETBrowser()
        {
            InitializeComponent();
            gb_history.Visible = false;

            Read read = new Read();
            read.ReadHistory();
            webBrowser.Navigate(@"https://www.google.pl");
            b_remove.Enabled = false;
            ActualHistory();
     
        }
        #endregion

        #region Metody

        public void ActualHistory()
        {
            foreach (var item in History.records)
            {
                AddToListView(item);
            }
        }
        public void AddToListView(Record record)
        {
            ListViewItem listViewItem = new ListViewItem();
            listViewItem.SubItems[0].Text=record.Link.ToString();
            listViewItem.SubItems.Add ( record.Time.ToShortDateString());
            lv_history.Items.Add(listViewItem);
        }
        private void ShowHistory(bool visible)
        {
            gb_history.Visible = !visible;

            if (!visible)
            {
                webBrowser.Width -= widthHistory;
                gb_history.Width = widthHistory;
            }
            else
            {
                webBrowser.Width += widthHistory;
                gb_history.Width = 0;
            }

        }

        private void Buttons()
        {
            
            b_back.Enabled = (webBrowser.CanGoBack == false) ? false : true;
            b_next.Enabled = (webBrowser.CanGoForward == false) ? false : true;
        }

        private void Add(string url)
        {

            if (url != "")
            {
                if (cb_link.Items.Contains(url) == false)
                {
                    cb_link.Items.Add(url);
                }
            }

        }

        private void Page(string link)
        {

            if (link != "")
            {

                webBrowser.Navigate(link);
                Add(link);
               AddToListView(History.AddRecord(link));

            }
        }
        #endregion

        #region Zdarzenia


#region Historia

private void historiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowHistory(gb_history.Visible);

        }

        private void b_remove_Click(object sender, EventArgs e)
        {
            if (lv_history.SelectedItems.Count > 0)
            {
                Record record;
                for (int i = 0; i < lv_history.SelectedItems.Count; i++)
                {
                    string link = lv_history.SelectedItems[i].SubItems[0].Text;
                    string date = lv_history.SelectedItems[i].SubItems[1].Text;
                    record = new Record(History.records.FirstOrDefault(x => x.Link.Equals(link) && x.Time.ToShortDateString().Equals(date)));
                    History.records.Remove(record);
                    lv_history.Items.Remove(lv_history.SelectedItems[i]);
                }        

            }


        }

        private void b_removeall_Click(object sender, EventArgs e)
        {
            History.records.Clear();
            lv_history.Items.Clear();
        }

        private void lv_history_Click(object sender, EventArgs e)
        {
            if (lv_history.SelectedItems.Count > 0)
            {
                b_remove.Enabled = true;
            }
            else
            {
                b_remove.Enabled = true;
            }

        }

        private void lv_history_DoubleClick(object sender, EventArgs e)
        {
            if (lv_history.SelectedItems.Count > 0)
            {
                string link = lv_history.SelectedItems[0].SubItems[0].Text;
                Page(link);
            }
        }
        #endregion

        #region Opcje
        private void drukujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser.ShowPrintDialog();
        }

        private void ustawieniaDrukuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser.ShowPageSetupDialog();
        }

        private void podglądWydrukuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser.ShowPrintPreviewDialog();
        }

        private void zapiszStronęToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser.ShowSaveAsDialog();
        }

        private void właściwościStronyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser.ShowPropertiesDialog();
        }
        #endregion

        #region Okno
        private void b_back_Click(object sender, EventArgs e)
        {
            if (webBrowser.CanGoBack) webBrowser.GoBack();
        }

        private void b_next_Click(object sender, EventArgs e)
        {
            if (webBrowser.CanGoForward) webBrowser.GoForward();
        }

        private void b_refresh_Click(object sender, EventArgs e)
        {
            webBrowser.Refresh(WebBrowserRefreshOption.Completely);
        }

        private void b_go_Click(object sender, EventArgs e)
        {
         
            Page(cb_link.Text);
        }

        private void b_stop_Click(object sender, EventArgs e)
        {
            webBrowser.Stop();
       
        }
        private void informacjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Przlądarka internetowa", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }




        #endregion

        #region webBrowser
        private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

            progresBar.Value = progresBar.Maximum;
            //   Add(webBrowser.Url.ToString());
            statusStrip.Height = 0;
            progresBar.Visible = false;
         
        }


        private void webBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            Buttons();
            cb_link.Text = webBrowser.Url.ToString();
            this.Text = "NETBrowser -" + cb_link.Text;
        }

        private void webBrowser_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            this.Text = "NETBrowser -" + cb_link.Text;
        }

        private void webBrowser_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {

            long stan = Math.Abs(e.CurrentProgress);
            long max = Math.Abs(e.MaximumProgress);
            double number;

            if (max != 0)
            {
                           
                if ((double)max < (double)stan)
                        number = (double)max;
                else
                    number = (double)stan / (double)max;
            }
            else
                number = 0;

            if (number > 1)
                number = 1;


            progresBar.Value = (int)(progresBar.Maximum * number);

            if (progresBar.Value <= progresBar.Maximum - 1)
                progresBar.Visible = true;
        }
        #endregion

        #region Link
        private void cb_link_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 13)
            {
                Page(cb_link.Text);
                e.Handled = true;
            }
        }
        private void cb_link_SelectedIndexChanged(object sender, EventArgs e)
        {
            Page(cb_link.Text);
        }

        #endregion

        private void NETBrowser_FormClosing(object sender, FormClosingEventArgs e)
        {
            Write write = new Write();
            write.WriteHistory();
        }
        #endregion




    }
}
