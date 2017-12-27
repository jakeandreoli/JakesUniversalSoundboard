using System;
using System.Windows.Forms;
using System.Linq;
using GlobalHotKey;

namespace JakesSoundboard
{
	public partial class Form1 : Form
	{
		// Initialisation
		private IDropTargetHelper DropTargetHelper;
		void Form_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				string[] Paths = (string[])e.Data.GetData(DataFormats.FileDrop);
				if (Paths.Length == 1)
				{
					e.Effect = DragDropEffects.Move;
					if (this.DropTargetHelper != null)
					{
						try
						{
							this.DropTargetHelper.DragEnter(this.Handle, (System.Runtime.InteropServices.ComTypes.IDataObject)e.Data, new System.Drawing.Point(e.X, e.Y), (int)e.Effect);
						}
						catch (Exception) { }
					}
					return;
				}
			}
			e.Effect = DragDropEffects.None;
			if (this.DropTargetHelper != null)
			{
				try
				{
					this.DropTargetHelper.DragEnter(this.Handle, (System.Runtime.InteropServices.ComTypes.IDataObject)e.Data, new System.Drawing.Point(e.X, e.Y), (int)e.Effect);
				}
				catch (Exception) { }
			}
		}

		void Form_DragDrop(object sender, DragEventArgs e)
		{
			if (this.DropTargetHelper != null)
			{
				try
				{
					this.DropTargetHelper.Drop((System.Runtime.InteropServices.ComTypes.IDataObject)e.Data, new System.Drawing.Point(e.X, e.Y), (int)e.Effect);
				}
				catch (Exception) { }
			}
			string[] FileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);
			this.BeginInvoke(new Action<string>(this.AddSound), new string[] { FileList[0] });
		}

		void Form_DragLeave(object sender, EventArgs e)
		{
			if (this.DropTargetHelper != null)
			{
				try
				{
					this.DropTargetHelper.DragLeave();
				}
				catch (Exception) { }
			}
		}

		void Form_DragOver(object sender, DragEventArgs e)
		{
			if (this.DropTargetHelper != null)
			{
				try
				{
					this.DropTargetHelper.DragOver(new System.Drawing.Point(e.X, e.Y), (int)e.Effect);
				}
				catch (Exception) { }
			}
		}

		public GlobalHotKey.HotKeyManager HotKeyManager = new GlobalHotKey.HotKeyManager();

		public Form1()
		{
			InitializeComponent();
		}

		public string SaveFileLocation = Application.StartupPath + System.IO.Path.DirectorySeparatorChar + "Data.jsub";
		private SaveFile UserData;

		private void Form1_Load(object sender, EventArgs e)
		{
			this.Text = this.ProductName + " (" + this.ProductVersion + ")";
			this.UserData = new SaveFile();

			bool SaveDataExists = System.IO.File.Exists(this.SaveFileLocation);

			if (SaveDataExists)
			{
				if (!this.UserData.Load(this.SaveFileLocation))
				{
					LucasStuff.Message.Show("Your save file is corrupted. You should probably back that up so we can look into it.", "Oh no!", LucasStuff.Message.Buttons.OK, LucasStuff.Message.Icon.Error, this);
					this.UserData = new SaveFile();
				}
			}
			else
				this.UserData.Save(this.SaveFileLocation);

			try
			{
				this.DropTargetHelper = (IDropTargetHelper)new DragDropHelper();
			}
			catch (System.Runtime.InteropServices.COMException)
			{
				this.DropTargetHelper = null;
			}

			this.AllowDrop = true;
			this.DragEnter += new DragEventHandler(this.Form_DragEnter);
			this.DragDrop += new DragEventHandler(this.Form_DragDrop);
			this.DragLeave += new EventHandler(this.Form_DragLeave);
			this.DragOver += new DragEventHandler(this.Form_DragOver);

			this.PopulateDevices();
			this.PopulateSounds();

			this.HotKeyManager.Register(System.Windows.Input.Key.F5, System.Windows.Input.ModifierKeys.Control);

			this.HotKeyManager.KeyPressed += this.HotKeyManagerHandler;
		}

		//

		public void DisposeWave()
		{
			throw new NotImplementedException();
		}

		public void PlaySound(string FileName, int DeviceNumber)
		{
			//disposeWave();// stop previous sounds before starting
			//waveReader = new NAudio.Wave.WaveFileReader(fileName);
			//var waveOut = new NAudio.Wave.WaveOut();
			//waveOut.DeviceNumber = deviceNumber;
			//output = waveOut;
			//output.Init(waveReader);
			//output.Play();
		}

		private void PopulateSounds()
		{
			this.listView1.BeginUpdate();
			try
			{
				this.listView1.Items.Clear();
				foreach (var Sound in this.UserData.Sounds)
					this.AddSoundToList(Sound.FilePath, Sound.HotKeyControl, Sound.HotKeyAlt, Sound.HotKeyShift, Sound.Key);
			}
			finally
			{
				this.listView1.EndUpdate();
			}
		}

		private void PopulateDevices()
		{
			this.checkedListBox1.BeginUpdate();
			try
			{
				this.checkedListBox1.Items.Clear();

				NAudio.CoreAudioApi.MMDeviceEnumerator DeviceNames = new NAudio.CoreAudioApi.MMDeviceEnumerator();
				NAudio.CoreAudioApi.MMDeviceCollection AllDevices = DeviceNames.EnumerateAudioEndPoints(NAudio.CoreAudioApi.DataFlow.Render, NAudio.CoreAudioApi.DeviceState.Active);

				foreach (var Device in AllDevices)
				{
					int Item = this.checkedListBox1.Items.Add(Device);

					// TODO: Implement save file device shit.
				}
			}
			finally
			{
				this.checkedListBox1.EndUpdate();
			}
		}

		private void AddSoundToList(string Path, bool HKControl = false, bool HKAlt = false, bool HKShift = false, System.Windows.Forms.Keys UsedHotKey = System.Windows.Forms.Keys.None)
		{
			ListViewItem Item = new ListViewItem
			{
				Text = System.IO.Path.GetFileNameWithoutExtension(Path)
			};

			string HotKeyPreview = "";
			System.Windows.Forms.KeysConverter KeyConverter = new System.Windows.Forms.KeysConverter();

			if (HKControl)
				HotKeyPreview += KeyConverter.ConvertToString(System.Windows.Forms.Keys.Control);
			if (HKAlt)
				HotKeyPreview += (HotKeyPreview.Length != 0 ? "+" : "") + KeyConverter.ConvertToString(System.Windows.Forms.Keys.Alt);
			if (HKShift)
				HotKeyPreview += (HotKeyPreview.Length != 0 ? "+" : "") + KeyConverter.ConvertToString(System.Windows.Forms.Keys.Shift);
			if (UsedHotKey != System.Windows.Forms.Keys.None)
				HotKeyPreview += (HotKeyPreview.Length != 0 ? "+" : "") + KeyConverter.ConvertToString(UsedHotKey);


			Item.SubItems.Add(HotKeyPreview.Length != 0 ? HotKeyPreview : "(none)");

			this.listView1.Items.Add(Item);
		}

		private void AddSound(string Path)
		{
			if (System.IO.Directory.Exists(Path))
			{
				LucasStuff.Message.Show("Folders are not supported.", "No Support", LucasStuff.Message.Buttons.OK, LucasStuff.Message.Icon.Warning, this);

				return;
			}

			string PathExtension = System.IO.Path.GetExtension(Path).ToUpperInvariant().Substring(1);
			
			if (!SaveFile.SupportedFormats.Contains(PathExtension))
			{
				LucasStuff.Message.Show("File format not supported. " + PathExtension + " is not a valid music file.", "No Support", LucasStuff.Message.Buttons.OK, LucasStuff.Message.Icon.Warning, this);

				return;
			}

			this.AddSoundToList(Path);
			this.UserData.AddSound(Path);
			this.UserData.Save(this.SaveFileLocation);
		}

		private void HotKeyManagerHandler(object sender, KeyPressedEventArgs e)
		{
			throw new NotImplementedException();
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Debugger.Break();
		}

		private void RefreshOutputs_Click(object sender, EventArgs e)
		{
			this.PopulateDevices();
		}

		private void DisableAllOutputs_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Debugger.Break();
		}

		private void DeviceListChecked(object sender, System.Windows.Forms.ItemCheckEventArgs e)
		{
			System.Diagnostics.Debugger.Break();
		}

		private void SoundViewClick(object sender, EventArgs e)
		{
			this.MMI_RemoveSoundItem.Enabled = this.listView1.SelectedItems.Count >= 1;
		}

		private void SoundViewDoubleClick(object sender, MouseEventArgs e)
		{
			ListViewHitTestInfo hit = this.listView1.HitTest(e.Location);

			if (hit.Item != null)
			{
				MessageBox.Show(hit.Item.Text);
			};
		}

		private void MMI_AddNewSound(object sender, EventArgs e)
		{
			var dialog = new OpenFileDialog
			{
				Filter = "MP3 files (*.mp3)|*.mp3|Ogg files (*.ogg)|*.ogg|WAVE Files (*.wav)|*.wav",
				Title = "Select an audio file"
			};
			if (dialog.ShowDialog() == DialogResult.OK)
				this.AddSound(dialog.FileName);
		}

		private void MMI_RemoveSound(object sender, EventArgs e)
		{

		}

		private void MMI_About(object sender, EventArgs e)
		{
			string Title = "About " + this.ProductName + " (ver " + this.ProductVersion + ")";
			string Message = "Made by Jake Andreøli of Donut Team. Copyright 2017 Donut Team";

			LucasStuff.Message.Show(Message, Title, LucasStuff.Message.Buttons.OK, LucasStuff.Message.Icon.Information, this);
		}

		private void MMI_Exit(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
