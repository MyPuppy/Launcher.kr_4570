using KartRider.Common.Utilities;
using KartRider.IO;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace KartRider
{
	internal static class Program
	{
		public static Launcher LauncherDlg;
		public static GetKart GetKartDlg;
		public static Options OptionsDlg;
		public static int MAX_EQP_P;
		public static bool UseKartTune;
		public static bool UseKartPlant;
		public static bool UseKartLevel;
		public static bool UseKartParts;
		public static bool SpeedPatch;
		public static bool FavoriteItem;
		public static bool PreventItem;
		public static bool Developer_Name;
		public static ushort Version;
		public static string DataTime;

		static Program()
		{
			Program.MAX_EQP_P = 29;
			Program.Developer_Name = true;
			Program.Version = 4570;
			Program.DataTime = "BB AB 00 00"; //2020-05-14
		}

		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Launcher StartLauncher = new Launcher();
			Program.LauncherDlg = StartLauncher;
			Application.Run(StartLauncher);
		}
	}
}