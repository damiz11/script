using System;
using System.IO;
namespace CSBackend
{
	/// <summary>
	///This class provides download utilities, the methods provided
	///download a file from remoteUri then read the contents of it 
	///into the string strOut, returning the string.
	/// </summary>
	public class DownloadUtil
	{
		string strOut;
		System.Net.WebClient webClient; 
		public DownloadUtil()
		{
			webClient = new System.Net.WebClient();
			strOut = "not set";
		}
		public string DownloadFile(String webAddr, String fileName)
		{
			string remoteUri;
			remoteUri = webAddr + fileName;
			try
			{
				webClient.DownloadFile(remoteUri, fileName);
				if (File.Exists(fileName))
				{
					ReadFile(fileName);
				}
			}
			catch(Exception e)
			{				
				strOut = "Download Failed";
			}
			return strOut;
		}
		public void ReadFile(String fileName)
		{
			StreamReader strmRead = new StreamReader(File.OpenRead(fileName), System.Text.Encoding.ASCII);
            strmRead.BaseStream.Seek(0, SeekOrigin.Begin);
			while (strmRead.Peek() > -1)
			{
				strOut = strmRead.ReadLine();
			}
			strmRead.Close();
		}
	}
}