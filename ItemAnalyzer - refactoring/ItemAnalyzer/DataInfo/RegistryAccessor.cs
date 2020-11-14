using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace ItemAnalyzer.DataInfo
{
	public class RegistryAccessor
	{
		public enum KeyName
		{
			BackColor,
			BtnColor,
			StrColor
		}

		public static void SetRegistryValue(Color color, KeyName keyplace)
		{
			var regKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"SoftWare\so2Analyze\color");

			regKey.SetValue(keyplace.ToString(), color.ToArgb());
		}

		public static Color GetRegistryValue(KeyName keyPlace)
		{
			var regKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"SoftWare\so2Analyze\color");

			var argb = regKey.GetValue(keyPlace.ToString(), SystemColors.Control.ToArgb());

			if (keyPlace == KeyName.StrColor && (int)argb == SystemColors.Control.ToArgb())
				return Color.Black;

			return Color.FromArgb((int)argb);
		}
	}
}
