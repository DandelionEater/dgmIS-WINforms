using dgmIS.DBconnect;
using dgmIS.Utilities;
using WINforms.Forms;


namespace WINforms
{
	internal static class Program
	{
		public static DBconnect DB;

		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.
			ApplicationConfiguration.Initialize();
			Application.Run(new loginPage());
		}
	}
}