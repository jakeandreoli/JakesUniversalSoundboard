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
			this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.DisableAllOutputs = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.RefreshOutputs = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.trackBar1 = new System.Windows.Forms.TrackBar();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.MMI_AddSoundItem = new System.Windows.Forms.MenuItem();
			this.MMI_RemoveSoundItem = new System.Windows.Forms.MenuItem();
			this.menuItem6 = new System.Windows.Forms.MenuItem();
			this.menuItem7 = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			this.listView1 = new LucasStuff.ExplorerThemedListView();
			this.LVSoundName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.LVHotKey = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
			this.SuspendLayout();
			// 
			// checkedListBox1
			// 
			this.checkedListBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.checkedListBox1.FormattingEnabled = true;
			this.checkedListBox1.Location = new System.Drawing.Point(67, 254);
			this.checkedListBox1.Name = "checkedListBox1";
			this.checkedListBox1.Size = new System.Drawing.Size(440, 154);
			this.checkedListBox1.TabIndex = 0;
			this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.DeviceListChecked);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 269);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Outputs:";
			// 
			// DisableAllOutputs
			// 
			this.DisableAllOutputs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.DisableAllOutputs.Location = new System.Drawing.Point(383, 414);
			this.DisableAllOutputs.Name = "DisableAllOutputs";
			this.DisableAllOutputs.Size = new System.Drawing.Size(125, 23);
			this.DisableAllOutputs.TabIndex = 4;
			this.DisableAllOutputs.Text = "Disable All Devices";
			this.DisableAllOutputs.UseVisualStyleBackColor = true;
			this.DisableAllOutputs.Click += new System.EventHandler(this.DisableAllOutputs_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 12);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(46, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Sounds:";
			// 
			// RefreshOutputs
			// 
			this.RefreshOutputs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.RefreshOutputs.Location = new System.Drawing.Point(67, 414);
			this.RefreshOutputs.Name = "RefreshOutputs";
			this.RefreshOutputs.Size = new System.Drawing.Size(75, 23);
			this.RefreshOutputs.TabIndex = 7;
			this.RefreshOutputs.Text = "Refresh";
			this.RefreshOutputs.UseVisualStyleBackColor = true;
			this.RefreshOutputs.Click += new System.EventHandler(this.RefreshOutputs_Click);
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button1.Location = new System.Drawing.Point(143, 414);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 8;
			this.button1.Text = "Stop Sound";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1_Click);
			// 
			// trackBar1
			// 
			this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.trackBar1.Location = new System.Drawing.Point(16, 301);
			this.trackBar1.Maximum = 100;
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.trackBar1.Size = new System.Drawing.Size(45, 107);
			this.trackBar1.TabIndex = 9;
			this.trackBar1.TickFrequency = 10;
			this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.Both;
			this.trackBar1.Value = 100;
			// 
			// checkBox1
			// 
			this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(224, 418);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(50, 17);
			this.checkBox1.TabIndex = 10;
			this.checkBox1.Text = "Loop";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem4});
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MMI_AddSoundItem,
            this.MMI_RemoveSoundItem,
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
			this.MMI_RemoveSoundItem.Text = "Remove sound...";
			this.MMI_RemoveSoundItem.Click += new System.EventHandler(this.MMI_RemoveSound);
			// 
			// menuItem6
			// 
			this.menuItem6.Index = 2;
			this.menuItem6.Text = "-";
			// 
			// menuItem7
			// 
			this.menuItem7.Index = 3;
			this.menuItem7.Text = "Exit";
			this.menuItem7.Click += new System.EventHandler(this.MMI_Exit);
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 1;
			this.menuItem4.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem5});
			this.menuItem4.Text = "Help";
			// 
			// menuItem5
			// 
			this.menuItem5.Index = 0;
			this.menuItem5.Text = "About";
			this.menuItem5.Click += new System.EventHandler(this.MMI_About);
			// 
			// listView1
			// 
			this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.LVSoundName,
            this.LVHotKey});
			this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.listView1.Location = new System.Drawing.Point(68, 12);
			this.listView1.MultiSelect = false;
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(440, 236);
			this.listView1.TabIndex = 5;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			this.listView1.SelectedIndexChanged += new System.EventHandler(this.SoundViewClick);
			this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.SoundViewDoubleClick);
			// 
			// LVSoundName
			// 
			this.LVSoundName.Text = "Sound name";
			this.LVSoundName.Width = 302;
			// 
			// LVHotKey
			// 
			this.LVHotKey.Text = "Hot Key";
			this.LVHotKey.Width = 134;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(519, 450);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.trackBar1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.RefreshOutputs);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.DisableAllOutputs);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.checkedListBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Menu = this.mainMenu1;
			this.MinimumSize = new System.Drawing.Size(535, 489);
			this.Name = "Form1";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.Text = "Jake\'s Universal Sound Board";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckedListBox checkedListBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button DisableAllOutputs;
		private LucasStuff.ExplorerThemedListView listView1;
		private System.Windows.Forms.ColumnHeader LVSoundName;
		private System.Windows.Forms.ColumnHeader LVHotKey;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button RefreshOutputs;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TrackBar trackBar1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem MMI_AddSoundItem;
		private System.Windows.Forms.MenuItem MMI_RemoveSoundItem;
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.MenuItem menuItem7;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuItem5;
	}
}

