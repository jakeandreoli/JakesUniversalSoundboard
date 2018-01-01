using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JakesSoundboard.Utilities
{
	class LucasUtils
	{

		public static string FormatVersion(System.Version Version)
		{
			string Result = Version.Major.ToString();
			Result += "." + Version.Minor.ToString();
			if (Version.Build != 0 || Version.Revision != 0)
			{
				Result += "." + Version.Build.ToString();
				if (Version.Revision != 0)
					Result += "." + Version.Revision.ToString();
			}
			return Result;
		}
	}
}
