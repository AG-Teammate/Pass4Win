﻿namespace Pass4Win
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.statusPass = new System.Windows.Forms.StatusStrip();
            this.statusTxt = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusPB = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripOffline = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtPassDetail = new System.Windows.Forms.RichTextBox();
            this.passDetailMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyPassDetailMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMakeVisible = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.SystrayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openSystrayMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitSystrayMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSearch = new System.Windows.Forms.ToolStrip();
            this.toolStriptextSearch = new System.Windows.Forms.ToolStripTextBox();
            this.ToolStripbtnAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripbtnQuit = new System.Windows.Forms.ToolStripButton();
            this.toolStripbtnAbout = new System.Windows.Forms.ToolStripButton();
            this.toolStripbtnConfig = new System.Windows.Forms.ToolStripButton();
            this.toolStripbtnKey = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnGenPass = new System.Windows.Forms.ToolStripButton();
            this.toolStripUpdateButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnRestartGpg = new System.Windows.Forms.ToolStripButton();
            this.TextDelay = new System.Windows.Forms.Timer(this.components);
            this.dirTreeView = new System.Windows.Forms.TreeView();
            this.listFileView = new System.Windows.Forms.ListBox();
            this.HTMLShowDetails = new System.Windows.Forms.WebBrowser();
            this.toolStripBtnOpenUrl = new System.Windows.Forms.ToolStripButton();
            this.statusPass.SuspendLayout();
            this.passDetailMenu.SuspendLayout();
            this.dataMenu.SuspendLayout();
            this.SystrayMenu.SuspendLayout();
            this.toolStripSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusPass
            // 
            this.statusPass.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.statusPass.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusTxt,
            this.statusPB,
            this.toolStripOffline,
            this.toolStripStatusLabel1});
            resources.ApplyResources(this.statusPass, "statusPass");
            this.statusPass.Name = "statusPass";
            this.statusPass.SizingGrip = false;
            // 
            // statusTxt
            // 
            this.statusTxt.Name = "statusTxt";
            resources.ApplyResources(this.statusTxt, "statusTxt");
            // 
            // statusPB
            // 
            this.statusPB.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.statusPB.Name = "statusPB";
            resources.ApplyResources(this.statusPB, "statusPB");
            this.statusPB.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // toolStripOffline
            // 
            this.toolStripOffline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.toolStripOffline, "toolStripOffline");
            this.toolStripOffline.ForeColor = System.Drawing.Color.IndianRed;
            this.toolStripOffline.Name = "toolStripOffline";
            this.toolStripOffline.Spring = true;
            this.toolStripOffline.Click += new System.EventHandler(this.ToolStripOfflineClick);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            resources.ApplyResources(this.toolStripStatusLabel1, "toolStripStatusLabel1");
            // 
            // txtPassDetail
            // 
            this.txtPassDetail.ContextMenuStrip = this.passDetailMenu;
            resources.ApplyResources(this.txtPassDetail, "txtPassDetail");
            this.txtPassDetail.Name = "txtPassDetail";
            this.txtPassDetail.ReadOnly = true;
            this.txtPassDetail.Leave += new System.EventHandler(this.TxtPassDetailLeave);
            // 
            // passDetailMenu
            // 
            this.passDetailMenu.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.passDetailMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyPassDetailMenuItem});
            this.passDetailMenu.Name = "passDetailMenu";
            resources.ApplyResources(this.passDetailMenu, "passDetailMenu");
            this.passDetailMenu.Opening += new System.ComponentModel.CancelEventHandler(this.PassDetailMenuOpening);
            // 
            // copyPassDetailMenuItem
            // 
            this.copyPassDetailMenuItem.Name = "copyPassDetailMenuItem";
            resources.ApplyResources(this.copyPassDetailMenuItem, "copyPassDetailMenuItem");
            this.copyPassDetailMenuItem.Click += new System.EventHandler(this.CopyPassDetailMenuItemClick);
            // 
            // dataMenu
            // 
            this.dataMenu.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.dataMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.editToolStripMenuItem,
            this.renameToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.dataMenu.Name = "dataMenu";
            resources.ApplyResources(this.dataMenu, "dataMenu");
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            resources.ApplyResources(this.copyToolStripMenuItem, "copyToolStripMenuItem");
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.CopyToolStripMenuItemClick);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            resources.ApplyResources(this.editToolStripMenuItem, "editToolStripMenuItem");
            this.editToolStripMenuItem.Click += new System.EventHandler(this.EditToolStripMenuItemClick);
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            resources.ApplyResources(this.renameToolStripMenuItem, "renameToolStripMenuItem");
            this.renameToolStripMenuItem.Click += new System.EventHandler(this.RenameToolStripMenuItemClick);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            resources.ApplyResources(this.deleteToolStripMenuItem, "deleteToolStripMenuItem");
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItemClick);
            // 
            // btnMakeVisible
            // 
            resources.ApplyResources(this.btnMakeVisible, "btnMakeVisible");
            this.btnMakeVisible.Name = "btnMakeVisible";
            this.btnMakeVisible.UseVisualStyleBackColor = true;
            this.btnMakeVisible.Click += new System.EventHandler(this.BtnMakeVisibleClick);
            // 
            // notifyIcon1
            // 
            resources.ApplyResources(this.notifyIcon1, "notifyIcon1");
            this.notifyIcon1.ContextMenuStrip = this.SystrayMenu;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon1MouseDoubleClick);
            // 
            // SystrayMenu
            // 
            this.SystrayMenu.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.SystrayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openSystrayMenuItem,
            this.quitSystrayMenuItem});
            this.SystrayMenu.Name = "SystrayMenu";
            resources.ApplyResources(this.SystrayMenu, "SystrayMenu");
            // 
            // openSystrayMenuItem
            // 
            this.openSystrayMenuItem.Name = "openSystrayMenuItem";
            resources.ApplyResources(this.openSystrayMenuItem, "openSystrayMenuItem");
            this.openSystrayMenuItem.Click += new System.EventHandler(this.OpenSystrayMenuItemClick);
            // 
            // quitSystrayMenuItem
            // 
            this.quitSystrayMenuItem.Name = "quitSystrayMenuItem";
            resources.ApplyResources(this.quitSystrayMenuItem, "quitSystrayMenuItem");
            this.quitSystrayMenuItem.Click += new System.EventHandler(this.QuitSystrayMenuItemClick);
            // 
            // toolStripSearch
            // 
            this.toolStripSearch.CanOverflow = false;
            this.toolStripSearch.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.toolStripSearch.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStriptextSearch,
            this.ToolStripbtnAdd,
            this.toolStripbtnQuit,
            this.toolStripbtnAbout,
            this.toolStripbtnConfig,
            this.toolStripbtnKey,
            this.toolStripBtnGenPass,
            this.toolStripUpdateButton,
            this.toolStripBtnRestartGpg,
            this.toolStripBtnOpenUrl});
            this.toolStripSearch.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            resources.ApplyResources(this.toolStripSearch, "toolStripSearch");
            this.toolStripSearch.Name = "toolStripSearch";
            // 
            // toolStriptextSearch
            // 
            resources.ApplyResources(this.toolStriptextSearch, "toolStriptextSearch");
            this.toolStriptextSearch.CausesValidation = false;
            this.toolStriptextSearch.Name = "toolStriptextSearch";
            this.toolStriptextSearch.TextChanged += new System.EventHandler(this.ToolStriptextSearchTextChanged);
            // 
            // ToolStripbtnAdd
            // 
            this.ToolStripbtnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.ToolStripbtnAdd, "ToolStripbtnAdd");
            this.ToolStripbtnAdd.Name = "ToolStripbtnAdd";
            this.ToolStripbtnAdd.Click += new System.EventHandler(this.ToolStripbtnAddClick);
            // 
            // toolStripbtnQuit
            // 
            this.toolStripbtnQuit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripbtnQuit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.toolStripbtnQuit, "toolStripbtnQuit");
            this.toolStripbtnQuit.Name = "toolStripbtnQuit";
            this.toolStripbtnQuit.Click += new System.EventHandler(this.ToolStripbtnQuitClick);
            // 
            // toolStripbtnAbout
            // 
            this.toolStripbtnAbout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripbtnAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.toolStripbtnAbout, "toolStripbtnAbout");
            this.toolStripbtnAbout.Name = "toolStripbtnAbout";
            this.toolStripbtnAbout.Click += new System.EventHandler(this.ToolStripbtnAboutClick);
            // 
            // toolStripbtnConfig
            // 
            this.toolStripbtnConfig.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripbtnConfig.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.toolStripbtnConfig, "toolStripbtnConfig");
            this.toolStripbtnConfig.Name = "toolStripbtnConfig";
            this.toolStripbtnConfig.Click += new System.EventHandler(this.ToolStripbtnConfigClick);
            // 
            // toolStripbtnKey
            // 
            this.toolStripbtnKey.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripbtnKey.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.toolStripbtnKey, "toolStripbtnKey");
            this.toolStripbtnKey.Name = "toolStripbtnKey";
            this.toolStripbtnKey.Click += new System.EventHandler(this.ToolStripbtnKeyClick);
            // 
            // toolStripBtnGenPass
            // 
            this.toolStripBtnGenPass.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.toolStripBtnGenPass, "toolStripBtnGenPass");
            this.toolStripBtnGenPass.Name = "toolStripBtnGenPass";
            this.toolStripBtnGenPass.Click += new System.EventHandler(this.ToolStripBtnGenPassClick);
            // 
            // toolStripUpdateButton
            // 
            this.toolStripUpdateButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripUpdateButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.toolStripUpdateButton, "toolStripUpdateButton");
            this.toolStripUpdateButton.Name = "toolStripUpdateButton";
            this.toolStripUpdateButton.Click += new System.EventHandler(this.ToolStripUpdateButtonClick);
            // 
            // toolStripBtnRestartGpg
            // 
            this.toolStripBtnRestartGpg.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.toolStripBtnRestartGpg, "toolStripBtnRestartGpg");
            this.toolStripBtnRestartGpg.Name = "toolStripBtnRestartGpg";
            this.toolStripBtnRestartGpg.Click += new System.EventHandler(this.ToolStripbtnRestartGpgClick);
            // 
            // TextDelay
            // 
            this.TextDelay.Interval = 500;
            this.TextDelay.Tick += new System.EventHandler(this.TextDelayTick);
            // 
            // dirTreeView
            // 
            this.dirTreeView.HideSelection = false;
            resources.ApplyResources(this.dirTreeView, "dirTreeView");
            this.dirTreeView.Name = "dirTreeView";
            this.dirTreeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.DirTreeViewNodeMouseDoubleClick);
            // 
            // listFileView
            // 
            this.listFileView.ContextMenuStrip = this.dataMenu;
            this.listFileView.FormattingEnabled = true;
            resources.ApplyResources(this.listFileView, "listFileView");
            this.listFileView.Name = "listFileView";
            this.listFileView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListFileViewMouseClick);
            // 
            // HTMLShowDetails
            // 
            this.HTMLShowDetails.AllowNavigation = false;
            this.HTMLShowDetails.AllowWebBrowserDrop = false;
            this.HTMLShowDetails.IsWebBrowserContextMenuEnabled = false;
            resources.ApplyResources(this.HTMLShowDetails, "HTMLShowDetails");
            this.HTMLShowDetails.Name = "HTMLShowDetails";
            this.HTMLShowDetails.WebBrowserShortcutsEnabled = false;
            // 
            // toolStripBtnOpenUrl
            // 
            this.toolStripBtnOpenUrl.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.toolStripBtnOpenUrl, "toolStripBtnOpenUrl");
            this.toolStripBtnOpenUrl.Name = "toolStripBtnOpenUrl";
            this.toolStripBtnOpenUrl.Click += new System.EventHandler(this.ToolStripbtnOpenUrlClick);
            // 
            // FrmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listFileView);
            this.Controls.Add(this.dirTreeView);
            this.Controls.Add(this.toolStripSearch);
            this.Controls.Add(this.btnMakeVisible);
            this.Controls.Add(this.txtPassDetail);
            this.Controls.Add(this.statusPass);
            this.Controls.Add(this.HTMLShowDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMainFormClosing);
            this.Resize += new System.EventHandler(this.FrmMainResize);
            this.statusPass.ResumeLayout(false);
            this.statusPass.PerformLayout();
            this.passDetailMenu.ResumeLayout(false);
            this.dataMenu.ResumeLayout(false);
            this.SystrayMenu.ResumeLayout(false);
            this.toolStripSearch.ResumeLayout(false);
            this.toolStripSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusPass;
        private System.Windows.Forms.ToolStripStatusLabel statusTxt;
        private System.Windows.Forms.ToolStripProgressBar statusPB;
        private System.Windows.Forms.RichTextBox txtPassDetail;
        private System.Windows.Forms.ContextMenuStrip dataMenu;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
        private System.Windows.Forms.Button btnMakeVisible;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripOffline;
        private System.Windows.Forms.ContextMenuStrip SystrayMenu;
        private System.Windows.Forms.ToolStripMenuItem openSystrayMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitSystrayMenuItem;
        private System.Windows.Forms.ToolStrip toolStripSearch;
        private System.Windows.Forms.ToolStripButton ToolStripbtnAdd;
        private System.Windows.Forms.ToolStripButton toolStripbtnKey;
        private System.Windows.Forms.ToolStripButton toolStripbtnConfig;
        private System.Windows.Forms.ToolStripTextBox toolStriptextSearch;
        private System.Windows.Forms.ToolStripButton toolStripbtnAbout;
        private System.Windows.Forms.ToolStripButton toolStripbtnQuit;
        private System.Windows.Forms.Timer TextDelay;
        private System.Windows.Forms.ToolStripButton toolStripBtnGenPass;
        private System.Windows.Forms.ContextMenuStrip passDetailMenu;
        private System.Windows.Forms.ToolStripMenuItem copyPassDetailMenuItem;
        private System.Windows.Forms.TreeView dirTreeView;
        private System.Windows.Forms.ToolStripButton toolStripUpdateButton;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ListBox listFileView;
        private System.Windows.Forms.WebBrowser HTMLShowDetails;
        private System.Windows.Forms.ToolStripButton toolStripBtnRestartGpg;
        private System.Windows.Forms.ToolStripButton toolStripBtnOpenUrl;
    }
}

