using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace linkapprove
{
	internal static class Program
	{
		public static FirstForm form1;
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Program.form1 = new FirstForm();
			Application.Run(Program.form1);
		}
		public static string GetRemoteContent(string url, int reqtimeout)
		{
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
			string text = "";
			WebRequest webRequest = WebRequest.Create(url);
			webRequest.Method = "GET";
			webRequest.Timeout = reqtimeout;
			try
			{
				StreamReader streamReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
				text = streamReader.ReadToEnd();
				streamReader.Close();
			}
			catch (WebException ex)
			{
				if(ex.Status == WebExceptionStatus.Timeout) text = "-1";
				else text = "-1";
			}
			return text.Trim();
		}
	}
}
