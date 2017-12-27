using System.Linq;
using GlobalHotKey;

namespace JakesSoundboard
{
	public partial class Form1 : System.Windows.Forms.Form
	{
		// Initialisation
		private IDropTargetHelper DropTargetHelper;
		void Form_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
		{
			if (e.Data.GetDataPresent(System.Windows.Forms.DataFormats.FileDrop))
			{
				string[] Paths = (string[])e.Data.GetData(System.Windows.Forms.DataFormats.FileDrop);
				if (Paths.Length >= 1)
				{
					e.Effect = System.Windows.Forms.DragDropEffects.Move;
					if (this.DropTargetHelper != null)
					{
						try
						{
							this.DropTargetHelper.DragEnter(this.Handle, (System.Runtime.InteropServices.ComTypes.IDataObject)e.Data, new System.Drawing.Point(e.X, e.Y), (int)e.Effect);
						}
						catch (System.Exception) { }
					}
					return;
				}
			}
			e.Effect = System.Windows.Forms.DragDropEffects.None;
			if (this.DropTargetHelper != null)
			{
				try
				{
					this.DropTargetHelper.DragEnter(this.Handle, (System.Runtime.InteropServices.ComTypes.IDataObject)e.Data, new System.Drawing.Point(e.X, e.Y), (int)e.Effect);
				}
				catch (System.Exception) { }
			}
		}

		void Form_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
		{
			if (this.DropTargetHelper != null)
			{
				try
				{
					this.DropTargetHelper.Drop((System.Runtime.InteropServices.ComTypes.IDataObject)e.Data, new System.Drawing.Point(e.X, e.Y), (int)e.Effect);
				}
				catch (System.Exception) { }
			}
			string[] FileList = (string[])e.Data.GetData(System.Windows.Forms.DataFormats.FileDrop, false);
			this.BeginInvoke(new System.Action<string[]>(this.AddSound), new object[] { FileList });
		}

		void Form_DragLeave(object sender, System.EventArgs e)
		{
			if (this.DropTargetHelper != null)
			{
				try
				{
					this.DropTargetHelper.DragLeave();
				}
				catch (System.Exception) { }
			}
		}

		void Form_DragOver(object sender, System.Windows.Forms.DragEventArgs e)
		{
			if (this.DropTargetHelper != null)
			{
				try
				{
					this.DropTargetHelper.DragOver(new System.Drawing.Point(e.X, e.Y), (int)e.Effect);
				}
				catch (System.Exception) { }
			}
		}

		public GlobalHotKey.HotKeyManager HotKeyManager = new GlobalHotKey.HotKeyManager();

		public Form1()
		{
			InitializeComponent();
		}


		public string SaveFileLocation = System.Windows.Forms.Application.StartupPath + System.IO.Path.DirectorySeparatorChar + "Data.jsub";
		private SaveFile UserData;
		private System.Text.RegularExpressions.Regex FriendlyNameGenerator = new System.Text.RegularExpressions.Regex("([A-Z][a-z]+|[A-Z]+(?![a-z])) *");

		private void Form1_Load(object sender, System.EventArgs e)
		{
			this.Text = this.ProductName + " (" + this.ProductVersion + ")";
			this.UserData = new SaveFile();

			bool SaveDataExists = System.IO.File.Exists(this.SaveFileLocation);

			if (SaveDataExists)
			{
				// TODO: Fix this (the message shows it's corrupted when it's out of date, we should probably show something else)
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
			this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form_DragEnter);
			this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form_DragDrop);
			this.DragLeave += new System.EventHandler(this.Form_DragLeave);
			this.DragOver += new System.Windows.Forms.DragEventHandler(this.Form_DragOver);

			this.PopulateDevices();
			this.PopulateSounds();
			this.checkBox1.Checked = this.UserData.LoopEnabled;
			this.ShowFriendlySoundNames.Checked = this.UserData.UseFriendlyNames;

			this.HotKeyManager.Register(System.Windows.Input.Key.F5, System.Windows.Input.ModifierKeys.Control);

			this.HotKeyManager.KeyPressed += this.HotKeyManagerHandler;
		}

		//

		public void DisposeWave()
		{
			throw new System.NotImplementedException();
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
					this.AddSoundToList(Sound);
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

		private string GetSoundListText(string FilePath)
		{
			string Text = System.IO.Path.GetFileNameWithoutExtension(FilePath);
			if (this.UserData.UseFriendlyNames)
				return this.FriendlyNameGenerator.Replace(Text, "$1 ").TrimEnd();
			else
				return Text;
		}

		private void AddSoundToList(SaveFile.Sound Snd)
		{
			System.Windows.Forms.ListViewItem Item = new System.Windows.Forms.ListViewItem
			{
				Text = GetSoundListText(Snd.FilePath)
			};

			string HotKeyPreview = "";

			if (Snd.HasHotKey)
			{
				System.Windows.Forms.KeysConverter KeyConverter = new System.Windows.Forms.KeysConverter();

				if (Snd.HotKeyControl)
					HotKeyPreview += KeyConverter.ConvertToString(System.Windows.Forms.Keys.Control);
				if (Snd.HotKeyAlt)
					HotKeyPreview += (HotKeyPreview.Length != 0 ? "+" : "") + KeyConverter.ConvertToString(System.Windows.Forms.Keys.Alt);
				if (Snd.HotKeyShift)
					HotKeyPreview += (HotKeyPreview.Length != 0 ? "+" : "") + KeyConverter.ConvertToString(System.Windows.Forms.Keys.Shift);
				if (Snd.Key != System.Windows.Forms.Keys.None)
					HotKeyPreview += (HotKeyPreview.Length != 0 ? "+" : "") + KeyConverter.ConvertToString(Snd.Key);
			}

			Item.SubItems.Add(HotKeyPreview.Length != 0 ? HotKeyPreview : "(none)");

			Item.Tag = Snd;
			Snd.Item = Item;

			this.listView1.Items.Add(Item);
		}

		private void AddSound(string[] Path2)
		{
			foreach (string Path in Path2)
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

				foreach (SaveFile.Sound Snd in this.UserData.Sounds)
				{
					if (Snd.FilePath == Path)
					{
						this.listView1.SelectedItems.Clear();
						Snd.Item.Selected = true;
						return;
					}
				}

				this.AddSoundToList(this.UserData.AddSound(Path));
			}
			this.UserData.Save(this.SaveFileLocation);
		}

		private void HotKeyManagerHandler(object sender, KeyPressedEventArgs e)
		{
			throw new System.NotImplementedException();
		}

		private void Button1_Click(object sender, System.EventArgs e)
		{
			System.Diagnostics.Debugger.Break();
		}

		private void RefreshOutputs_Click(object sender, System.EventArgs e)
		{
			this.PopulateDevices();
		}

		private void DisableAllOutputs_Click(object sender, System.EventArgs e)
		{
			System.Diagnostics.Debugger.Break();
		}

		private void DeviceListChecked(object sender, System.Windows.Forms.ItemCheckEventArgs e)
		{
		}

		private void SoundViewClick(object sender, System.EventArgs e)
		{
			int Count = this.listView1.SelectedItems.Count;
			bool IsMoreThanOrEqualToOne = Count >= 1;
			string Text = "Remove sound" + (Count != 1 ? "s" : "");

			this.MMI_RemoveSoundItem.Enabled = IsMoreThanOrEqualToOne;
			this.CM_RemoveSound.Enabled = IsMoreThanOrEqualToOne;
			this.MMI_RemoveSoundItem.Text = Text;
			this.CM_RemoveSound.Text = Text;
		}

		private void SoundViewDoubleClick(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			System.Windows.Forms.ListViewHitTestInfo hit = this.listView1.HitTest(e.Location);

			if (hit.Item != null)
			{
				foreach (int Sometig in this.checkedListBox1.CheckedIndices)
				{
					SaveFile.Sound Item = ((SaveFile.Sound)hit.Item.Tag);
					NAudio.Wave.WaveStream Stream;
					if (Item.SndFormat == SoundFormat.OGG)
						Stream = new NAudio.Vorbis.VorbisWaveReader(Item.FilePath);
					else if (Item.SndFormat == SoundFormat.WAV)
						Stream = new NAudio.Wave.WaveFileReader(Item.FilePath);
					else if (Item.SndFormat == SoundFormat.MP3)
						Stream = new NAudio.Wave.Mp3FileReader(Item.FilePath);
					else
						throw new System.NotSupportedException();
					var waveOut = new NAudio.Wave.WaveOutEvent();
					{
						waveOut.DeviceNumber = Sometig;
						waveOut.Init(Stream);
						waveOut.Play();
					}
				}
			};
		}

		private void MMI_AddNewSound(object sender, System.EventArgs e)
		{
			var dialog = new System.Windows.Forms.OpenFileDialog
			{
				Filter = "All Supported Formats (*.mp3;*.ogg;*.wav)|*.mp3;*.ogg;*.wav|MP3 files (*.mp3)|*.mp3|Ogg files (*.ogg)|*.ogg|WAVE Files (*.wav)|*.wav|All files (*.*)|*.*",
				Title = "Select an audio file",
				Multiselect = true
			};
			if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
				this.AddSound(dialog.FileNames);
		}

		private void MMI_RemoveSound(object sender, System.EventArgs e)
		{
			var Confirmation = LucasStuff.Message.Show("Are you sure you want to remove " + (this.listView1.SelectedItems.Count == 1 ? "this sound" : "these sounds") + "? You can re-add them later if you choose to.", "Confirmation", LucasStuff.Message.Buttons.YesNo, LucasStuff.Message.Icon.Information, this);

			if (Confirmation == System.Windows.Forms.DialogResult.Yes)
			{
				this.listView1.BeginUpdate();
				try
				{
					foreach (System.Windows.Forms.ListViewItem Item in this.listView1.SelectedItems)
					{
						this.UserData.Sounds.Remove(this.UserData.Sounds[Item.Index]);
						this.listView1.Items[Item.Index].Remove();
					}
				}
				finally
				{
					this.listView1.EndUpdate();
				}

				this.UserData.Save(this.SaveFileLocation);
			}
		}

		private void MMI_About(object sender, System.EventArgs e)
		{
			string Title = "About " + this.ProductName + " (ver " + this.ProductVersion + ")";
			string Message = "Made by Jake Andreøli.";

			LucasStuff.Message.Show(Message, Title, LucasStuff.Message.Buttons.OK, LucasStuff.Message.Icon.Information, this);
		}

		private void MMI_Exit(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void CheckBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			this.UserData.LoopEnabled = this.checkBox1.Checked;
			this.UserData.Save(this.SaveFileLocation);
		}

		private void MMI_GitHubLink(object sender, System.EventArgs e)
		{
			System.Diagnostics.Process.Start("https://github.com/jakeandreoli/JakesUniversalSoundboard");
		}

		private void ListView1_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (e.Button == System.Windows.Forms.MouseButtons.Right)
			{
				this.contextMenu1.Show(this.listView1, e.Location);
			}
		}


		private void ShowFriendlySoundNamesClick(object sender, System.EventArgs e)
		{
			this.UserData.UseFriendlyNames = this.ShowFriendlySoundNames.Checked = !this.ShowFriendlySoundNames.Checked;
			if (this.UserData.UseFriendlyNames)
			{
				var Confirmation = LucasStuff.Message.Show("This setting will attempt to split file names into human readable sentences. For example \"ThisIsFUN\" will become \"This Is FUN\". It will most likely not work in every circumstance. Are you sure you want to enable this?", "Confirmation", LucasStuff.Message.Buttons.YesNo, LucasStuff.Message.Icon.Information, this);

				if (Confirmation == System.Windows.Forms.DialogResult.No)
				{
					this.ShowFriendlySoundNames.Checked = false;
					this.UserData.UseFriendlyNames = false;
					return;
				}
			}

			this.listView1.BeginUpdate();

			foreach (System.Windows.Forms.ListViewItem Item in this.listView1.Items)
			{
				Item.Text = this.GetSoundListText(((SaveFile.Sound)Item.Tag).FilePath);
			}

			this.listView1.EndUpdate();
			this.UserData.Save(this.SaveFileLocation);
		}
	}
}
