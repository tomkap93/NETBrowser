namespace NETBrowser
{
    partial class NETBrowser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NETBrowser));
            this.cb_link = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drukujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ustawieniaDrukuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.podglądWydrukuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.zapiszStronęToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.właściwościStronyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.drukujToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszStronęToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.właściwościStronyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.progresBar = new System.Windows.Forms.ToolStripProgressBar();
            this.lv_history = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gb_history = new System.Windows.Forms.GroupBox();
            this.b_removeall = new System.Windows.Forms.Button();
            this.b_remove = new System.Windows.Forms.Button();
            this.b_stop = new System.Windows.Forms.Button();
            this.b_refresh = new System.Windows.Forms.Button();
            this.b_next = new System.Windows.Forms.Button();
            this.b_back = new System.Windows.Forms.Button();
            this.b_go = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.gb_history.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_link
            // 
            this.cb_link.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_link.FormattingEnabled = true;
            this.cb_link.Location = new System.Drawing.Point(179, 26);
            this.cb_link.Name = "cb_link";
            this.cb_link.Size = new System.Drawing.Size(694, 21);
            this.cb_link.TabIndex = 0;
            this.cb_link.SelectedIndexChanged += new System.EventHandler(this.cb_link_SelectedIndexChanged);
            this.cb_link.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_link_KeyPress);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcjeToolStripMenuItem,
            this.historiaToolStripMenuItem,
            this.informacjeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(987, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcjeToolStripMenuItem
            // 
            this.opcjeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drukujToolStripMenuItem,
            this.ustawieniaDrukuToolStripMenuItem,
            this.podglądWydrukuToolStripMenuItem,
            this.toolStripMenuItem1,
            this.zapiszStronęToolStripMenuItem,
            this.właściwościStronyToolStripMenuItem});
            this.opcjeToolStripMenuItem.Name = "opcjeToolStripMenuItem";
            this.opcjeToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.opcjeToolStripMenuItem.Text = "Opcje";
            // 
            // drukujToolStripMenuItem
            // 
            this.drukujToolStripMenuItem.Name = "drukujToolStripMenuItem";
            this.drukujToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.drukujToolStripMenuItem.Text = "Drukuj";
            this.drukujToolStripMenuItem.Click += new System.EventHandler(this.drukujToolStripMenuItem_Click);
            // 
            // ustawieniaDrukuToolStripMenuItem
            // 
            this.ustawieniaDrukuToolStripMenuItem.Name = "ustawieniaDrukuToolStripMenuItem";
            this.ustawieniaDrukuToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.ustawieniaDrukuToolStripMenuItem.Text = "Ustawienia druku";
            this.ustawieniaDrukuToolStripMenuItem.Click += new System.EventHandler(this.ustawieniaDrukuToolStripMenuItem_Click);
            // 
            // podglądWydrukuToolStripMenuItem
            // 
            this.podglądWydrukuToolStripMenuItem.Name = "podglądWydrukuToolStripMenuItem";
            this.podglądWydrukuToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.podglądWydrukuToolStripMenuItem.Text = "Podgląd wydruku";
            this.podglądWydrukuToolStripMenuItem.Click += new System.EventHandler(this.podglądWydrukuToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(171, 6);
            // 
            // zapiszStronęToolStripMenuItem
            // 
            this.zapiszStronęToolStripMenuItem.Name = "zapiszStronęToolStripMenuItem";
            this.zapiszStronęToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.zapiszStronęToolStripMenuItem.Text = "Zapisz stronę";
            this.zapiszStronęToolStripMenuItem.Click += new System.EventHandler(this.zapiszStronęToolStripMenuItem_Click);
            // 
            // właściwościStronyToolStripMenuItem
            // 
            this.właściwościStronyToolStripMenuItem.Name = "właściwościStronyToolStripMenuItem";
            this.właściwościStronyToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.właściwościStronyToolStripMenuItem.Text = "Właściwości strony";
            this.właściwościStronyToolStripMenuItem.Click += new System.EventHandler(this.właściwościStronyToolStripMenuItem_Click);
            // 
            // historiaToolStripMenuItem
            // 
            this.historiaToolStripMenuItem.Name = "historiaToolStripMenuItem";
            this.historiaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.historiaToolStripMenuItem.Text = "Historia";
            this.historiaToolStripMenuItem.Click += new System.EventHandler(this.historiaToolStripMenuItem_Click);
            // 
            // informacjeToolStripMenuItem
            // 
            this.informacjeToolStripMenuItem.Name = "informacjeToolStripMenuItem";
            this.informacjeToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.informacjeToolStripMenuItem.Text = "Informacje";
            this.informacjeToolStripMenuItem.Click += new System.EventHandler(this.informacjeToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drukujToolStripMenuItem1,
            this.zapiszStronęToolStripMenuItem1,
            this.właściwościStronyToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(175, 70);
            // 
            // drukujToolStripMenuItem1
            // 
            this.drukujToolStripMenuItem1.Name = "drukujToolStripMenuItem1";
            this.drukujToolStripMenuItem1.Size = new System.Drawing.Size(174, 22);
            this.drukujToolStripMenuItem1.Text = "Drukuj";
            this.drukujToolStripMenuItem1.Click += new System.EventHandler(this.drukujToolStripMenuItem_Click);
            // 
            // zapiszStronęToolStripMenuItem1
            // 
            this.zapiszStronęToolStripMenuItem1.Name = "zapiszStronęToolStripMenuItem1";
            this.zapiszStronęToolStripMenuItem1.Size = new System.Drawing.Size(174, 22);
            this.zapiszStronęToolStripMenuItem1.Text = "Zapisz stronę";
            this.zapiszStronęToolStripMenuItem1.Click += new System.EventHandler(this.zapiszStronęToolStripMenuItem_Click);
            // 
            // właściwościStronyToolStripMenuItem1
            // 
            this.właściwościStronyToolStripMenuItem1.Name = "właściwościStronyToolStripMenuItem1";
            this.właściwościStronyToolStripMenuItem1.Size = new System.Drawing.Size(174, 22);
            this.właściwościStronyToolStripMenuItem1.Text = "Właściwości strony";
            this.właściwościStronyToolStripMenuItem1.Click += new System.EventHandler(this.właściwościStronyToolStripMenuItem_Click);
            // 
            // webBrowser
            // 
            this.webBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser.ContextMenuStrip = this.contextMenuStrip1;
            this.webBrowser.Location = new System.Drawing.Point(1, 53);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(984, 511);
            this.webBrowser.TabIndex = 8;
            this.webBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser_DocumentCompleted);
            this.webBrowser.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowser_Navigated);
            this.webBrowser.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.webBrowser_Navigating);
            this.webBrowser.ProgressChanged += new System.Windows.Forms.WebBrowserProgressChangedEventHandler(this.webBrowser_ProgressChanged);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progresBar});
            this.statusStrip.Location = new System.Drawing.Point(0, 567);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(987, 22);
            this.statusStrip.TabIndex = 9;
            this.statusStrip.Text = "statusStrip";
            // 
            // progresBar
            // 
            this.progresBar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.progresBar.Maximum = 10000;
            this.progresBar.Name = "progresBar";
            this.progresBar.Size = new System.Drawing.Size(200, 16);
            // 
            // lv_history
            // 
            this.lv_history.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lv_history.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lv_history.Location = new System.Drawing.Point(6, 19);
            this.lv_history.Name = "lv_history";
            this.lv_history.Size = new System.Drawing.Size(236, 462);
            this.lv_history.TabIndex = 10;
            this.lv_history.UseCompatibleStateImageBehavior = false;
            this.lv_history.View = System.Windows.Forms.View.Details;
            this.lv_history.Click += new System.EventHandler(this.lv_history_Click);
            this.lv_history.DoubleClick += new System.EventHandler(this.lv_history_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Adres";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Data";
            // 
            // gb_history
            // 
            this.gb_history.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_history.Controls.Add(this.b_removeall);
            this.gb_history.Controls.Add(this.b_remove);
            this.gb_history.Controls.Add(this.lv_history);
            this.gb_history.Location = new System.Drawing.Point(737, 53);
            this.gb_history.Name = "gb_history";
            this.gb_history.Size = new System.Drawing.Size(248, 510);
            this.gb_history.TabIndex = 11;
            this.gb_history.TabStop = false;
            this.gb_history.Text = "Historia";
            // 
            // b_removeall
            // 
            this.b_removeall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.b_removeall.Image = global::NETBrowser.Properties.Resources.usunwszystkomin;
            this.b_removeall.Location = new System.Drawing.Point(127, 483);
            this.b_removeall.Name = "b_removeall";
            this.b_removeall.Size = new System.Drawing.Size(115, 23);
            this.b_removeall.TabIndex = 12;
            this.b_removeall.UseVisualStyleBackColor = true;
            this.b_removeall.Click += new System.EventHandler(this.b_removeall_Click);
            // 
            // b_remove
            // 
            this.b_remove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.b_remove.Image = global::NETBrowser.Properties.Resources.usunmin;
            this.b_remove.Location = new System.Drawing.Point(6, 483);
            this.b_remove.Name = "b_remove";
            this.b_remove.Size = new System.Drawing.Size(115, 23);
            this.b_remove.TabIndex = 11;
            this.b_remove.UseVisualStyleBackColor = true;
            this.b_remove.Click += new System.EventHandler(this.b_remove_Click);
            // 
            // b_stop
            // 
            this.b_stop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_stop.Image = global::NETBrowser.Properties.Resources.stopmin;
            this.b_stop.Location = new System.Drawing.Point(936, 25);
            this.b_stop.Name = "b_stop";
            this.b_stop.Size = new System.Drawing.Size(49, 23);
            this.b_stop.TabIndex = 5;
            this.b_stop.UseVisualStyleBackColor = true;
            this.b_stop.Click += new System.EventHandler(this.b_stop_Click);
            // 
            // b_refresh
            // 
            this.b_refresh.Image = global::NETBrowser.Properties.Resources.refreshmin;
            this.b_refresh.Location = new System.Drawing.Point(120, 25);
            this.b_refresh.Name = "b_refresh";
            this.b_refresh.Size = new System.Drawing.Size(53, 23);
            this.b_refresh.TabIndex = 4;
            this.b_refresh.UseVisualStyleBackColor = true;
            this.b_refresh.Click += new System.EventHandler(this.b_refresh_Click);
            // 
            // b_next
            // 
            this.b_next.Image = global::NETBrowser.Properties.Resources.nextmin;
            this.b_next.Location = new System.Drawing.Point(61, 25);
            this.b_next.Name = "b_next";
            this.b_next.Size = new System.Drawing.Size(53, 23);
            this.b_next.TabIndex = 3;
            this.b_next.UseVisualStyleBackColor = true;
            this.b_next.Click += new System.EventHandler(this.b_next_Click);
            // 
            // b_back
            // 
            this.b_back.Image = ((System.Drawing.Image)(resources.GetObject("b_back.Image")));
            this.b_back.Location = new System.Drawing.Point(2, 25);
            this.b_back.Name = "b_back";
            this.b_back.Size = new System.Drawing.Size(53, 23);
            this.b_back.TabIndex = 2;
            this.b_back.UseVisualStyleBackColor = true;
            this.b_back.Click += new System.EventHandler(this.b_back_Click);
            // 
            // b_go
            // 
            this.b_go.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_go.Image = global::NETBrowser.Properties.Resources.okmin;
            this.b_go.Location = new System.Drawing.Point(879, 25);
            this.b_go.Name = "b_go";
            this.b_go.Size = new System.Drawing.Size(51, 23);
            this.b_go.TabIndex = 1;
            this.b_go.UseVisualStyleBackColor = true;
            this.b_go.Click += new System.EventHandler(this.b_go_Click);
            // 
            // NETBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(987, 589);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.gb_history);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.b_stop);
            this.Controls.Add(this.b_refresh);
            this.Controls.Add(this.b_next);
            this.Controls.Add(this.b_back);
            this.Controls.Add(this.b_go);
            this.Controls.Add(this.cb_link);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "NETBrowser";
            this.Text = "NETBrowser";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NETBrowser_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.gb_history.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_link;
        private System.Windows.Forms.Button b_go;
        private System.Windows.Forms.Button b_next;
        private System.Windows.Forms.Button b_refresh;
        private System.Windows.Forms.Button b_stop;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drukujToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ustawieniaDrukuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem podglądWydrukuToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem zapiszStronęToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem właściwościStronyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historiaToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripProgressBar progresBar;
        private System.Windows.Forms.Button b_back;
        private System.Windows.Forms.ToolStripMenuItem informacjeToolStripMenuItem;
        private System.Windows.Forms.ListView lv_history;
        private System.Windows.Forms.GroupBox gb_history;
        private System.Windows.Forms.Button b_removeall;
        private System.Windows.Forms.Button b_remove;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ToolStripMenuItem drukujToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem zapiszStronęToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem właściwościStronyToolStripMenuItem1;
    }
}

