using System.Runtime.InteropServices;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;

namespace QuasarCare
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			
			if(File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\TempScript.cmd")) { 
				File.Delete(AppDomain.CurrentDomain.BaseDirectory + @"\TempScript.cmd");
			}
			
			if(File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\TempScriptF.cmd")) { 
				File.Delete(AppDomain.CurrentDomain.BaseDirectory + @"\TempScriptF.cmd");
			}

		}
		
		void EXEC_BTNClick(object sender, EventArgs e)
		{
			MainProgressBar.Value += 18;
			if (DEFRAG.Checked) {defragExterno();}
			MainProgressBar.Value += 15;
			if (CLEARTEMP.Checked) {limparTemp();}
			MainProgressBar.Value += 67;
			if (FLUSHDNS.Checked) {FlushDNS();}
			MainProgressBar.Value = 0;
		}
		
		public void defragExterno() 
		{
			File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + @"\TempScript.cmd",
			"@echo off\necho [Executando Desfragmentador do Windows]\nc:\\windows\\system32\\defrag c:");
			var process = Process.Start(AppDomain.CurrentDomain.BaseDirectory + @"\TempScript.cmd");
			process.WaitForExit();
		}
		
		public void limparTemp() 
		{
			System.IO.DirectoryInfo di = new DirectoryInfo("c:\\windows\\temp");

			foreach (FileInfo file in di.GetFiles())
			{
				try 
				{
  			  	file.Delete(); 
				} 
				catch {
					
				}
			}
			foreach (DirectoryInfo dir in di.GetDirectories())
			{
				try {
			    dir.Delete(true); 
				}
				catch 
				{
					
				}
			}
		}
		
		public void FlushDNS() {
			File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + @"\TempScriptF.cmd",
			"ipconfig /flushdns");
			ProcessStartInfo startInfo = new ProcessStartInfo();
			startInfo.FileName = AppDomain.CurrentDomain.BaseDirectory + @"\TempScriptF.cmd";
			startInfo.RedirectStandardOutput = true;
			startInfo.RedirectStandardError = true;
			startInfo.UseShellExecute = false;
			startInfo.CreateNoWindow = true;

			Process processTemp = new Process();
			processTemp.StartInfo = startInfo;
			processTemp.EnableRaisingEvents = true;
			try
			{
			    processTemp.Start();
			}
			catch
			{
			}
		}
		
		void Main_TimerTick(object sender, EventArgs e)
		{
		}
		
		void MainProgressBarClick(object sender, EventArgs e)
		{
			
		}
	}
	
}
