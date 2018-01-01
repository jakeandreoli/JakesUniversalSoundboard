namespace JakesSoundboard
{
	partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.MMI_AddSoundItem = new System.Windows.Forms.MenuItem();
			this.MMI_RemoveSoundItem = new System.Windows.Forms.MenuItem();
			this.menuItem9 = new System.Windows.Forms.MenuItem();
			this.menuItem11 = new System.Windows.Forms.MenuItem();
			this.menuItem10 = new System.Windows.Forms.MenuItem();
			this.menuItem6 = new System.Windows.Forms.MenuItem();
			this.menuItem7 = new System.Windows.Forms.MenuItem();
			this.menuItem8 = new System.Windows.Forms.MenuItem();
			this.ShowFriendlySoundNames = new System.Windows.Forms.MenuItem();
			this.LoopPlaybackMenuItem = new System.Windows.Forms.MenuItem();
			this.menuItem14 = new System.Windows.Forms.MenuItem();
			this.menuItem15 = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.menuItem12 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			this.contextMenu1 = new System.Windows.Forms.ContextMenu();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.CM_RemoveSound = new System.Windows.Forms.MenuItem();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.trackBar1 = new System.Windows.Forms.TrackBar();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.listView1 = new LucasStuff.ExplorerThemedListView();
			this.LVSoundName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.LVHotKey = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.treeView1 = new LucasStuff.ExplorerThemedTreeView();
			this.PlayQueueList = new LucasStuff.ExplorerThemedListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
			this.tabPage3.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem8,
            this.menuItem15,
            this.menuItem4});
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MMI_AddSoundItem,
            this.MMI_RemoveSoundItem,
            this.menuItem9,
            this.menuItem11,
            this.menuItem10,
            this.menuItem6,
            this.menuItem7});
			this.menuItem1.Text = "File";
			// 
			// MMI_AddSoundItem
			// 
			this.MMI_AddSoundItem.Index = 0;
			this.MMI_AddSoundItem.Text = "Add sound...";
			this.MMI_AddSoundItem.Click += new System.EventHandler(this.MMI_AddNewSound);
			// 
			// MMI_RemoveSoundItem
			// 
			this.MMI_RemoveSoundItem.Enabled = false;
			this.MMI_RemoveSoundItem.Index = 1;
			this.MMI_RemoveSoundItem.Text = "Remove sound";
			this.MMI_RemoveSoundItem.Click += new System.EventHandler(this.CE_DeleteSounds);
			// 
			// menuItem9
			// 
			this.menuItem9.Index = 2;
			this.menuItem9.Text = "-";
			// 
			// menuItem11
			// 
			this.menuItem11.Index = 3;
			this.menuItem11.Text = "Refresh Devices";
			this.menuItem11.Click += new System.EventHandler(this.CE_PopulateSounds);
			// 
			// menuItem10
			// 
			this.menuItem10.Index = 4;
			this.menuItem10.Text = "Disable All Devices";
			this.menuItem10.Click += new System.EventHandler(this.CE_DisableAllSounds);
			// 
			// menuItem6
			// 
			this.menuItem6.Index = 5;
			this.menuItem6.Text = "-";
			// 
			// menuItem7
			// 
			this.menuItem7.Index = 6;
			this.menuItem7.Text = "Exit";
			this.menuItem7.Click += new System.EventHandler(this.CE_CloseProgram);
			// 
			// menuItem8
			// 
			this.menuItem8.Index = 1;
			this.menuItem8.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.ShowFriendlySoundNames,
            this.LoopPlaybackMenuItem,
            this.menuItem14});
			this.menuItem8.Text = "Options";
			// 
			// ShowFriendlySoundNames
			// 
			this.ShowFriendlySoundNames.Index = 0;
			this.ShowFriendlySoundNames.Text = "Show friendly sound names";
			this.ShowFriendlySoundNames.Click += new System.EventHandler(this.ShowFriendlySoundNamesClick);
			// 
			// LoopPlaybackMenuItem
			// 
			this.LoopPlaybackMenuItem.Index = 1;
			this.LoopPlaybackMenuItem.Text = "Loop playback";
			this.LoopPlaybackMenuItem.Click += new System.EventHandler(this.CE_LoopPlayback);
			// 
			// menuItem14
			// 
			this.menuItem14.Checked = true;
			this.menuItem14.Index = 2;
			this.menuItem14.Text = "Allow overlapping audio";
			// 
			// menuItem15
			// 
			this.menuItem15.Index = 2;
			this.menuItem15.Text = "&Stop Sound";
			this.menuItem15.Click += new System.EventHandler(this.CE_StopPlayback);
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 3;
			this.menuItem4.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem12,
            this.menuItem2,
            this.menuItem5});
			this.menuItem4.Text = "Help";
			// 
			// menuItem12
			// 
			this.menuItem12.Index = 0;
			this.menuItem12.Text = "Install Virtual Audio Drivers";
			this.menuItem12.Click += new System.EventHandler(this.CE_VirtualAudioDeviceDownload);
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 1;
			this.menuItem2.Text = "GitHub";
			this.menuItem2.Click += new System.EventHandler(this.MMI_GitHubLink);
			// 
			// menuItem5
			// 
			this.menuItem5.Index = 2;
			this.menuItem5.Text = "About";
			this.menuItem5.Click += new System.EventHandler(this.CE_AboutWindow);
			// 
			// contextMenu1
			// 
			this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem3,
            this.CM_RemoveSound});
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 0;
			this.menuItem3.Text = "Add sound...";
			this.menuItem3.Click += new System.EventHandler(this.MMI_AddNewSound);
			// 
			// CM_RemoveSound
			// 
			this.CM_RemoveSound.Enabled = false;
			this.CM_RemoveSound.Index = 1;
			this.CM_RemoveSound.Text = "Remove sound";
			this.CM_RemoveSound.Click += new System.EventHandler(this.CE_DeleteSounds);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.listView1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
			this.splitContainer1.Size = new System.Drawing.Size(519, 461);
			this.splitContainer1.SplitterDistance = 310;
			this.splitContainer1.TabIndex = 17;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(519, 147);
			this.tabControl1.TabIndex = 16;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.treeView1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(511, 121);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Devices";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.PlayQueueList);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(511, 121);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Play Queue";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// trackBar1
			// 
			this.trackBar1.Enabled = false;
			this.trackBar1.Location = new System.Drawing.Point(8, 6);
			this.trackBar1.Maximum = 100;
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Size = new System.Drawing.Size(236, 45);
			this.trackBar1.TabIndex = 15;
			this.trackBar1.TickFrequency = 10;
			this.trackBar1.Value = 100;
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.trackBar1);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(511, 121);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Settings";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// listView1
			// 
			this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.LVSoundName,
            this.LVHotKey});
			this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.listView1.Location = new System.Drawing.Point(0, 0);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(519, 310);
			this.listView1.TabIndex = 5;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			this.listView1.SelectedIndexChanged += new System.EventHandler(this.SoundViewClick);
			this.listView1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SoundListKeyUp);
			this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.SoundViewDoubleClick);
			this.listView1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ListView1_MouseUp);
			// 
			// LVSoundName
			// 
			this.LVSoundName.Text = "Sound name";
			this.LVSoundName.Width = 391;
			// 
			// LVHotKey
			// 
			this.LVHotKey.Text = "Hot Key";
			this.LVHotKey.Width = 103;
			// 
			// treeView1
			// 
			this.treeView1.CheckBoxes = true;
			this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeView1.FullRowSelect = true;
			this.treeView1.Location = new System.Drawing.Point(3, 3);
			this.treeView1.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
			this.treeView1.Name = "treeView1";
			this.treeView1.ShowLines = false;
			this.treeView1.ShowRootLines = false;
			this.treeView1.Size = new System.Drawing.Size(505, 115);
			this.treeView1.TabIndex = 11;
			this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.CE_DeviceListDoubleClick);
			// 
			// PlayQueueList
			// 
			this.PlayQueueList.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.PlayQueueList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
			this.PlayQueueList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PlayQueueList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.PlayQueueList.Location = new System.Drawing.Point(3, 3);
			this.PlayQueueList.Name = "PlayQueueList";
			this.PlayQueueList.Size = new System.Drawing.Size(505, 115);
			this.PlayQueueList.TabIndex = 6;
			this.PlayQueueList.UseCompatibleStateImageBehavior = false;
			this.PlayQueueList.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Sound name";
			this.columnHeader1.Width = 323;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Progress";
			this.columnHeader2.Width = 103;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Looping";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(519, 461);
			this.Controls.Add(this.splitContainer1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Menu = this.mainMenu1;
			this.MinimumSize = new System.Drawing.Size(535, 500);
			this.Name = "Form1";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.Text = "Jake\'s Universal Sound Board";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private LucasStuff.ExplorerThemedListView listView1;
		private System.Windows.Forms.ColumnHeader LVSoundName;
		private System.Windows.Forms.ColumnHeader LVHotKey;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem MMI_AddSoundItem;
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.MenuItem menuItem7;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.ContextMenu contextMenu1;
		private System.Windows.Forms.MenuItem CM_RemoveSound;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem8;
		private System.Windows.Forms.MenuItem ShowFriendlySoundNames;
		private System.Windows.Forms.MenuItem menuItem10;
		private System.Windows.Forms.MenuItem MMI_RemoveSoundItem;
		private System.Windows.Forms.MenuItem menuItem9;
		private System.Windows.Forms.MenuItem menuItem11;
		private System.Windows.Forms.MenuItem menuItem12;
		private System.Windows.Forms.MenuItem LoopPlaybackMenuItem;
		private System.Windows.Forms.MenuItem menuItem14;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private LucasStuff.ExplorerThemedTreeView treeView1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TrackBar trackBar1;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.MenuItem menuItem15;
		private LucasStuff.ExplorerThemedListView PlayQueueList;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
	}
}

