using System;
using System.Windows.Forms;

using UserInterfaces.Forms;

namespace UserInterfaces
{
	static class Program
	{
		[STAThread]
		static void Main()
		{
			_ = Application.SetHighDpiMode(HighDpiMode.SystemAware);
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new ControllingForm());
		}
	}
}
