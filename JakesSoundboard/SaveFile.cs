namespace JakesSoundboard
{
	enum SoundFormat
	{
		MP3,
		OGG,
		WAV
	};

	class SaveFile
	{
		private const int Version = 1;
		private const string Signature = "JUSB";

		public static string[] SupportedFormats = { "MP3", "OGG", "WAV" };

		public string CurrentSignature = Signature;
		public int CurrentVersion = Version;

		public bool LoopEnabled = false;

		public System.Collections.Generic.Dictionary<string, Device> Devices = new System.Collections.Generic.Dictionary<string, Device>();
		public System.Collections.Generic.List<Sound> Sounds = new System.Collections.Generic.List<Sound>();

		public class Device
		{
			public string DeviceID;
			public string DeviceFriendlyName;
			public bool Enabled = false;
			public float Volume = 1.0f;

			public Device(System.IO.BinaryReader Reader)
			{
				this.DeviceID = Reader.ReadString();
				this.DeviceFriendlyName = Reader.ReadString();
				this.Enabled = Reader.ReadBoolean();
				this.Volume = Reader.ReadSingle();
			}

			public Device()
			{

			}

			public void Save(System.IO.BinaryWriter Writer)
			{
				Writer.Write(this.DeviceID);
				Writer.Write(this.DeviceFriendlyName);
				Writer.Write(this.Enabled);
				Writer.Write(this.Volume);
			}
		}

		public class Sound
		{
			public string FilePath;
			public bool LoopFriendly = false;

			public bool HasHotKey = false;
			public System.Windows.Forms.Keys Key;
			public bool HotKeyControl = false;
			public bool HotKeyShift = false;
			public bool HotKeyAlt = false;
			public System.Windows.Forms.ListViewItem Item;

			public Sound(System.IO.BinaryReader Reader)
			{
				this.FilePath = Reader.ReadString();
				this.LoopFriendly = Reader.ReadBoolean();
				this.HasHotKey = Reader.ReadBoolean();
				if (this.HasHotKey)
				{
					this.Key = (System.Windows.Forms.Keys)Reader.ReadInt32();
					this.HotKeyControl = Reader.ReadBoolean();
					this.HotKeyShift = Reader.ReadBoolean();
					this.HotKeyAlt = Reader.ReadBoolean();
				}
			}

			public Sound()
			{

			}

			public void Save(System.IO.BinaryWriter Writer)
			{
				Writer.Write(this.FilePath);
				Writer.Write(this.LoopFriendly);
				Writer.Write(this.HasHotKey);

				if (this.HasHotKey)
				{
					Writer.Write((int)this.Key);
					Writer.Write(this.HotKeyControl);
					Writer.Write(this.HotKeyShift);
					Writer.Write(this.HotKeyAlt);
				}
			}
		}

		public Sound AddSound(string Path)
		{
			Sound NewSound = new Sound
			{
				FilePath = Path
			};

			this.Sounds.Add(NewSound);

			return NewSound;
		}

		public bool Save(string Path)
		{
			try
			{
				using (System.IO.Stream Stream = new System.IO.FileStream(Path, System.IO.FileMode.Create, System.IO.FileAccess.Write))
				{
					System.IO.BinaryWriter Writer = new System.IO.BinaryWriter(Stream);

					Writer.Write(System.Text.Encoding.ASCII.GetBytes(Signature));
					Writer.Write(Version);
					Writer.Write(this.LoopEnabled);
					Writer.Write(this.Devices.Count);
					foreach (var Device in this.Devices)
						Device.Value.Save(Writer);
					Writer.Write(this.Sounds.Count);
					foreach (var Sound in this.Sounds)
						Sound.Save(Writer);

					Writer.Write("Jake was here.");
				}
			}
			catch (System.Exception Ex)
			{
				LucasStuff.Message.Show("You should probably tell the developers about this:\n" + Ex.ToString(), "Exception when saving file", LucasStuff.Message.Buttons.OK, LucasStuff.Message.Icon.Error);
				return false;
			}

			return true;
		}

		public bool Load(string Path)
		{
			using (System.IO.Stream Stream = new System.IO.FileStream(Path, System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.Read))
			{
				System.IO.BinaryReader Reader = new System.IO.BinaryReader(Stream);

				this.CurrentSignature = System.Text.Encoding.ASCII.GetString(Reader.ReadBytes(Signature.Length));
				if (this.CurrentSignature != Signature)
					return false;

				this.CurrentVersion = Reader.ReadInt32();
				if (this.CurrentVersion != Version)
					return false;

				this.LoopEnabled = Reader.ReadBoolean();

				int DeviceCount = Reader.ReadInt32();
				{
					int i = 0;
					while (i < DeviceCount)
					{
						Device NewDevice = new Device(Reader);
						this.Devices.Add(NewDevice.DeviceID, NewDevice);
						++i;
					}
				}

				int SoundCount = Reader.ReadInt32();
				{
					int i = 0;
					while (i < SoundCount)
					{
						this.Sounds.Add(new Sound(Reader));
						++i;
					}
				}

				return true;
			}
		}

		public SaveFile()
		{
			// TODO: Maybe?
		}
	}
}
