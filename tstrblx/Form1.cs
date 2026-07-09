using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tstrblx
{
	public partial class tslaunch : Form
	{
		private tstrbx tstr;

		public tslaunch()
		{
			InitializeComponent();
		}

		private void hbut_Click(object sender, EventArgs e)
		{
			MessageBox.Show("You have to manually download a ROBLOX Studio client and provide the location (tip, Shift + Right Click, Copy as Path).\nThe studio client has to be from 2017-2020.\nDon't worry. It'll be saved, so you don't have to copy it every single time.\nCorescripts also must be local, else you want get a GUI ingame.\nHitting \"Launch\" will start the launcher.", "tstRBX", MessageBoxButtons.OK);
		}

		private void lbut_Click(object sender, EventArgs e)
		{
			tsvr.rbstloc = this.rbstloc.Text;
			tsvr.rbstver = this.rbstvr.Text;
			File.WriteAllText("rbxstloc.cac", this.rbstloc.Text);
			this.Hide();
			tstr = new tstrbx();
			tstr.Show();
		}

		private void tslaunch_Load(object sender, EventArgs e)
		{
			
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{
			if (File.Exists("rbxstloc.cac"))
			{
				Thread.Sleep(100);
				tsvr.rbstloc = File.ReadAllText("rbxstloc.cac");
				tsvr.rbstver = this.rbstvr.Text;
				this.Hide();
				this.Hide();
				this.Hide();
				this.Hide();
				this.Hide();
				this.Hide();
				this.Hide();
				tstr = new tstrbx();
				tstr.Show();
			}
		}
	}
	static class tsvr
	{
		private static string _rbstloc = string.Empty;
		public static string rbstloc {
			get { return _rbstloc; }
			set { _rbstloc = value; }
		}

		private static string _rbstver = string.Empty;
		public static string rbstver
		{
			get { return _rbstver; }
			set { _rbstver = value; }
		}
	}
}
