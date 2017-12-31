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
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			this.contextMenu1 = new System.Windows.Forms.ContextMenu();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.CM_RemoveSound = new System.Windows.Forms.MenuItem();
			this.panel1 = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.trackBar1 = new System.Windows.Forms.TrackBar();
			this.listView1 = new LucasStuff.ExplorerThemedListView();
			this.LVSoundName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.LVHotKey = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.treeView1 = new LucasStuff.ExplorerThemedTreeView();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
			this.SuspendLayout();
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem8,
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
            this.ShowFriendlySoundNames});
			this.menuItem8.Text = "View";
			// 
			// ShowFriendlySoundNames
			// 
			this.ShowFriendlySoundNames.Index = 0;
			this.ShowFriendlySoundNames.Text = "Show friendly sound names";
			this.ShowFriendlySoundNames.Click += new System.EventHandler(this.ShowFriendlySoundNamesClick);
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 2;
			this.menuItem4.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem2,
            this.menuItem5});
			this.menuItem4.Text = "Help";
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 0;
			this.menuItem2.Text = "GitHub";
			this.menuItem2.Click += new System.EventHandler(this.MMI_GitHubLink);
			// 
			// menuItem5
			// 
			this.menuItem5.Index = 1;
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
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.Control;
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 315);
			this.panel1.Margin = new System.Windows.Forms.Padding(0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(519, 2);
			this.panel1.TabIndex = 12;
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.Location = new System.Drawing.Point(422, 322);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(85, 23);
			this.button1.TabIndex = 13;
			this.button1.Text = "&Stop Sound";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// trackBar1
			// 
			this.trackBar1.Enabled = false;
			this.trackBar1.Location = new System.Drawing.Point(2, 322);
			this.trackBar1.Maximum = 100;
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Size = new System.Drawing.Size(182, 45);
			this.trackBar1.TabIndex = 15;
			this.trackBar1.TickFrequency = 10;
			this.trackBar1.Value = 100;
			// 
			// listView1
			// 
			this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.LVSoundName,
            this.LVHotKey});
			this.listView1.Dock = System.Windows.Forms.DockStyle.Top;
			this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.listView1.Location = new System.Drawing.Point(0, 0);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(519, 315);
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
			this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.treeView1.CheckBoxes = true;
			this.treeView1.FullRowSelect = true;
			this.treeView1.Location = new System.Drawing.Point(11, 351);
			this.treeView1.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
			this.treeView1.Name = "treeView1";
			this.treeView1.ShowLines = false;
			this.treeView1.ShowRootLines = false;
			this.treeView1.Size = new System.Drawing.Size(496, 98);
			this.treeView1.TabIndex = 11;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(519, 461);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.treeView1);
			this.Controls.Add(this.trackBar1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Menu = this.mainMenu1;
			this.MinimumSize = new System.Drawing.Size(535, 500);
			this.Name = "Form1";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.Text = "Jake\'s Universal Sound Board";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

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
		private LucasStuff.ExplorerThemedTreeView treeView1;
		private System.Windows.Forms.MenuItem menuItem10;
		private System.Windows.Forms.MenuItem MMI_RemoveSoundItem;
		private System.Windows.Forms.MenuItem menuItem9;
		private System.Windows.Forms.MenuItem menuItem11;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TrackBar trackBar1;
	}
}

