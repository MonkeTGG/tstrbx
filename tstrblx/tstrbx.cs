using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tstrblx
{
	public partial class tstrbx : Form
	{
		public delegate bool EnumChildCallback(IntPtr hwnd, ref IntPtr lParam);
		[DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
		public static extern bool SetWindowText(IntPtr hwnd, String lpString);
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
		static extern bool PostMessage(HandleRef hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

		[DllImport("User32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
		public static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);
		/*[DllImport("user32.dll")]
		static extern bool CloseWindow(IntPtr hWnd);*/

		[DllImport("User32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
		public static extern bool EnumChildWindows(IntPtr hWndParent, EnumChildCallback lpEnumFunc, ref IntPtr lParam);


		private static IntPtr rplr;
		private static Process rbx;
		private static bool clm = (tsvr.rbstver.Contains("<2019"));
		public tstrbx()
		{
			this.FormClosing += this.tstrbx_FormClosing;
			InitializeComponent();
			Console.WriteLine(tsvr.rbstloc);
		}

		private void tstrbx_Load(object sender, EventArgs e)
		{
			
		}
		private void tstrbx_FormClosing(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void jbut_Click(object sender, EventArgs e)
		{
			if (mlmode.Checked == true)
			{
				// most of this is based/taken from the old tstrbootstrapper.
				// too lazy to remake something i've already done
				// enjoy the shit code
				rbx = new Process();
				rbx.StartInfo.FileName = tsvr.rbstloc;
				if (clm)
				{
					rbx.StartInfo.Arguments = "-task StartClient -server " + this.iptxcl.Text + " -port " + this.pttxcl.Text + " " + this.argtxcl.Text;
				} else
				{
					rbx.StartInfo.Arguments = "-task StartClient -server " + this.iptxcl.Text + " -port " + this.pttxcl.Text + " " + this.argtxcl.Text;
				}
				rbx.Start();
				rbx.WaitForInputIdle();
				rbx.Refresh();
				Console.WriteLine("start::RBX");
				Console.WriteLine("start::waitForRBX");
				while (rbx.MainWindowHandle == IntPtr.Zero)
				{
					Task.Delay(1000);
				}
				Console.WriteLine("end::waitForRBX");
				Console.WriteLine("rbx::processHandle " + rbx.MainWindowHandle);
				SetWindowText(rbx.MainWindowHandle, "Roblox Player");
				IntPtr pPtr = IntPtr.Zero;
				EnumChildCallback ecc = new EnumChildCallback(enumChildProc);
				EnumChildWindows(rbx.MainWindowHandle, ecc, ref pPtr);
				Console.WriteLine("start::waitForRPlr");
				while (rplr == IntPtr.Zero)
				{
					EnumChildWindows(rbx.MainWindowHandle, ecc, ref pPtr);
				}
				Console.WriteLine("end::waitForRPlr");
				rbx.WaitForExit();
				rbx = null;
				rplr = IntPtr.Zero;
			} else
			{
				if (clm)
				{
					Process.Start(tsvr.rbstloc, "-task StartClient -server " + this.iptxcl.Text + " -port " + this.pttxcl.Text + " " + this.argtxcl.Text);
				}
				else
				{
					Process.Start(tsvr.rbstloc, "-universeId 0 --placeId 0 -task StartClient -server " + this.iptxcl.Text + " -port " + this.pttxcl.Text + " " + this.argtxcl.Text);
				}
				Process.Start(tsvr.rbstloc, "-universeId 0 --placeId 0 -task StartClient -server " + this.iptxcl.Text + " -port " + this.pttxcl.Text + " " + this.argtxcl.Text);
			}
		}

		private void glcbut_Click(object sender, EventArgs e)
		{
			this.flcmd.Text = tsvr.rbstloc + " -universeId 0 --placeId 0 -task StartClient -server " + this.iptxcl.Text + " -port " + this.pttxcl.Text;
			MessageBox.Show(tsvr.rbstloc + " -universeId 0 --placeId 0 -task StartClient -server " + this.iptxcl.Text + " -port " + this.pttxcl.Text, "Incase it's too big for the textbox", MessageBoxButtons.OK);
		}
		
		private void glcsv_Click(object sender, EventArgs e)
		{
			this.flcmd.Text = tsvr.rbstloc + " -task StartServer -universeId 0 -placeId 0 -localPlaceFile " + this.rbfltxsv.Text + " -port " + this.pttxsv.Text;
			MessageBox.Show(tsvr.rbstloc + " -task StartServer -universeId 0 -placeId 0 -localPlaceFile " + this.rbfltxsv.Text + " -port " + this.pttxsv.Text, "Incase it's too big for the textbox", MessageBoxButtons.OK);
		}

		private void jbutsv_Click(object sender, EventArgs e)
		{
			if (clm)
			{
				Process.Start(tsvr.rbstloc, tsvr.rbstloc + "-task StartServer" + " -port " + this.pttxsv.Text + " -localPlaceFile \"" + this.rbfltxsv.Text + "\"");
			}
			else
			{
				Process.Start(tsvr.rbstloc, tsvr.rbstloc + "-universeId 0 --placeId 0 -task StartServer" + " -port " + this.pttxsv.Text + " -localPlaceFile \"" + this.rbfltxsv.Text + "\"");
			}
		}

		public static bool enumChildProc(IntPtr hwndChild, ref IntPtr lParam) // stolen from the old tstrbootstrapper. // is probably skidded from some guy on stackoverflow but i couldn't care less
		{
			if (rbx != null)
			{
				StringBuilder wName = new StringBuilder(260);
				GetWindowText(hwndChild, wName, wName.Capacity);
				Console.WriteLine("foundWindow {0:x}", hwndChild.ToInt32());
				Console.WriteLine("\tcaption {0}", wName.ToString());


				if (wName.ToString() == "QOgreWidgetWindow")
				{
					rplr = hwndChild;
				}
				if (rplr != IntPtr.Zero)
				{
					// everything after this comment is not stolen from the old tstrbootstrapper
					SetWindowText(rbx.MainWindowHandle, "Roblox Player");
					if (!wName.ToString().Contains("mainViewStacked"))
					{
						if (!wName.ToString().Contains("QTabWidgetClass"))
						{
							if (!wName.ToString().Contains("qt_tabwidget_sta"))
							{
								if (!wName.ToString().Contains("QStackedWidgetClass"))
								{
									if (!wName.ToString().Contains("QWidgetClass"))
									{
										if (!wName.ToString().Contains("QScrollAreaClass"))
										{
											if (!wName.ToString().Contains("qt_scrollarea_viewport"))
											{
												if (!wName.ToString().Contains("QOgreWidget"))
												{
													PostMessage(new HandleRef(null, hwndChild), 0x0010, IntPtr.Zero, IntPtr.Zero);
												}
											}
										}
									}
								}
							}
						}
					}
				}
				return true;
			}
			else {
				rbx = null;
				rplr = IntPtr.Zero;
				return true;
			}
		}

		private void ccac_Click(object sender, EventArgs e)
		{
			File.Delete("rbxstloc.cac");
		}

		private void jbutps_Click(object sender, EventArgs e)
		{
			// this entire section is stolen from joincl with slight modifications
			// most of this is based/taken from the old tstrbootstrapper.
			// too lazy to remake something i've already done
			// enjoy the shit code
			rbx = new Process();
			rbx.StartInfo.FileName = tsvr.rbstloc;
			rbx.StartInfo.Arguments = "\"" + this.rbfltxps.Text + "\"";
			rbx.Start();
			rbx.WaitForInputIdle();
			rbx.Refresh();
			Console.WriteLine("start::RBX");
			Console.WriteLine("start::waitForRBX");
			while (rbx.MainWindowHandle == IntPtr.Zero)
			{
				Task.Delay(1000);
			}
			Console.WriteLine("end::waitForRBX");
			Console.WriteLine("rbx::processHandle " + rbx.MainWindowHandle);
			SetWindowText(rbx.MainWindowHandle, "Roblox Player");
			IntPtr pPtr = IntPtr.Zero;
			EnumChildCallback ecc = new EnumChildCallback(enumChildProc);
			EnumChildWindows(rbx.MainWindowHandle, ecc, ref pPtr);
			Console.WriteLine("start::waitForRPlr");
			while (rplr == IntPtr.Zero)
			{
				EnumChildWindows(rbx.MainWindowHandle, ecc, ref pPtr);
			}
			Console.WriteLine("end::waitForRPlr");
			rbx.WaitForExit();
			rbx = null;
			rplr = IntPtr.Zero;
		}
	}
}
