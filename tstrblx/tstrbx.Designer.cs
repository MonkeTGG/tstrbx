using System.Windows.Forms;

namespace tstrblx
{
	partial class tstrbx
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.clstart = new System.Windows.Forms.TabPage();
			this.mlmode = new System.Windows.Forms.CheckBox();
			this.glcbut = new System.Windows.Forms.Button();
			this.jbut = new System.Windows.Forms.Button();
			this.flcmd = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.argtxcl = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.pttxcl = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.iptxcl = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.svstart = new System.Windows.Forms.TabPage();
			this.glcsv = new System.Windows.Forms.Button();
			this.jbutsv = new System.Windows.Forms.Button();
			this.flcmdsv = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.argtxsv = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.pttxsv = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.rbfltxsv = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.psstart = new System.Windows.Forms.TabPage();
			this.label19 = new System.Windows.Forms.Label();
			this.label23 = new System.Windows.Forms.Label();
			this.glcps = new System.Windows.Forms.Button();
			this.jbutps = new System.Windows.Forms.Button();
			this.label16 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.argtxps = new System.Windows.Forms.TextBox();
			this.label18 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.rbfltxps = new System.Windows.Forms.TextBox();
			this.label22 = new System.Windows.Forms.Label();
			this.ccac = new System.Windows.Forms.Button();
			this.tabControl1.SuspendLayout();
			this.clstart.SuspendLayout();
			this.svstart.SuspendLayout();
			this.psstart.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(73, 30);
			this.label1.TabIndex = 1;
			this.label1.Text = "tstRBX";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.label2.Location = new System.Drawing.Point(14, 39);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(159, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "the shittiest launcher to ever live";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.clstart);
			this.tabControl1.Controls.Add(this.svstart);
			this.tabControl1.Controls.Add(this.psstart);
			this.tabControl1.Location = new System.Drawing.Point(13, 59);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(224, 306);
			this.tabControl1.TabIndex = 3;
			// 
			// clstart
			// 
			this.clstart.Controls.Add(this.mlmode);
			this.clstart.Controls.Add(this.glcbut);
			this.clstart.Controls.Add(this.jbut);
			this.clstart.Controls.Add(this.flcmd);
			this.clstart.Controls.Add(this.label8);
			this.clstart.Controls.Add(this.argtxcl);
			this.clstart.Controls.Add(this.label7);
			this.clstart.Controls.Add(this.pttxcl);
			this.clstart.Controls.Add(this.label6);
			this.clstart.Controls.Add(this.label5);
			this.clstart.Controls.Add(this.label4);
			this.clstart.Controls.Add(this.iptxcl);
			this.clstart.Controls.Add(this.label3);
			this.clstart.Location = new System.Drawing.Point(4, 22);
			this.clstart.Name = "clstart";
			this.clstart.Padding = new System.Windows.Forms.Padding(3);
			this.clstart.Size = new System.Drawing.Size(216, 280);
			this.clstart.TabIndex = 0;
			this.clstart.Text = "Client";
			this.clstart.UseVisualStyleBackColor = true;
			// 
			// mlmode
			// 
			this.mlmode.AutoSize = true;
			this.mlmode.Checked = true;
			this.mlmode.CheckState = System.Windows.Forms.CheckState.Checked;
			this.mlmode.Location = new System.Drawing.Point(13, 205);
			this.mlmode.Name = "mlmode";
			this.mlmode.Size = new System.Drawing.Size(103, 17);
			this.mlmode.TabIndex = 16;
			this.mlmode.Text = "mutalation mode";
			this.mlmode.UseVisualStyleBackColor = true;
			this.mlmode.Visible = false;
			// 
			// glcbut
			// 
			this.glcbut.Location = new System.Drawing.Point(6, 251);
			this.glcbut.Name = "glcbut";
			this.glcbut.Size = new System.Drawing.Size(126, 23);
			this.glcbut.TabIndex = 15;
			this.glcbut.Text = "Generate Launch CMD";
			this.glcbut.UseVisualStyleBackColor = true;
			this.glcbut.Click += new System.EventHandler(this.glcbut_Click);
			// 
			// jbut
			// 
			this.jbut.Location = new System.Drawing.Point(135, 251);
			this.jbut.Name = "jbut";
			this.jbut.Size = new System.Drawing.Size(75, 23);
			this.jbut.TabIndex = 14;
			this.jbut.Text = "Join";
			this.jbut.UseVisualStyleBackColor = true;
			this.jbut.Click += new System.EventHandler(this.jbut_Click);
			// 
			// flcmd
			// 
			this.flcmd.AutoSize = true;
			this.flcmd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.flcmd.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.flcmd.Location = new System.Drawing.Point(10, 215);
			this.flcmd.Name = "flcmd";
			this.flcmd.Size = new System.Drawing.Size(16, 13);
			this.flcmd.TabIndex = 13;
			this.flcmd.Text = "...";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label8.Location = new System.Drawing.Point(10, 202);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(136, 13);
			this.label8.TabIndex = 12;
			this.label8.Text = "The full launch command is";
			// 
			// argtxcl
			// 
			this.argtxcl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.argtxcl.Location = new System.Drawing.Point(13, 179);
			this.argtxcl.Name = "argtxcl";
			this.argtxcl.Size = new System.Drawing.Size(187, 20);
			this.argtxcl.TabIndex = 11;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.label7.Location = new System.Drawing.Point(10, 163);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(57, 13);
			this.label7.TabIndex = 10;
			this.label7.Text = "Arguments";
			// 
			// pttxcl
			// 
			this.pttxcl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.pttxcl.Location = new System.Drawing.Point(13, 130);
			this.pttxcl.Name = "pttxcl";
			this.pttxcl.Size = new System.Drawing.Size(187, 20);
			this.pttxcl.TabIndex = 9;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.label6.Location = new System.Drawing.Point(10, 114);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(26, 13);
			this.label6.TabIndex = 8;
			this.label6.Text = "Port";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(92)))), ((int)(((byte)(28)))));
			this.label5.Location = new System.Drawing.Point(10, 66);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(193, 39);
			this.label5.TabIndex = 7;
			this.label5.Text = "The IP must be numbers. If it\'s not, you \r\ncan find the actual ip with \r\n\"Resolve" +
    "-DnsName [ip]\" in pwsh.";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.label4.Location = new System.Drawing.Point(10, 53);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(99, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "WARNING (2019+)";
			// 
			// iptxcl
			// 
			this.iptxcl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.iptxcl.Location = new System.Drawing.Point(13, 28);
			this.iptxcl.Name = "iptxcl";
			this.iptxcl.Size = new System.Drawing.Size(187, 20);
			this.iptxcl.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.label3.Location = new System.Drawing.Point(10, 12);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(17, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "IP";
			// 
			// svstart
			// 
			this.svstart.Controls.Add(this.glcsv);
			this.svstart.Controls.Add(this.jbutsv);
			this.svstart.Controls.Add(this.flcmdsv);
			this.svstart.Controls.Add(this.label10);
			this.svstart.Controls.Add(this.argtxsv);
			this.svstart.Controls.Add(this.label11);
			this.svstart.Controls.Add(this.pttxsv);
			this.svstart.Controls.Add(this.label12);
			this.svstart.Controls.Add(this.label13);
			this.svstart.Controls.Add(this.label14);
			this.svstart.Controls.Add(this.rbfltxsv);
			this.svstart.Controls.Add(this.label15);
			this.svstart.Location = new System.Drawing.Point(4, 22);
			this.svstart.Name = "svstart";
			this.svstart.Padding = new System.Windows.Forms.Padding(3);
			this.svstart.Size = new System.Drawing.Size(216, 280);
			this.svstart.TabIndex = 1;
			this.svstart.Text = "Server";
			this.svstart.UseVisualStyleBackColor = true;
			// 
			// glcsv
			// 
			this.glcsv.Location = new System.Drawing.Point(6, 251);
			this.glcsv.Name = "glcsv";
			this.glcsv.Size = new System.Drawing.Size(126, 23);
			this.glcsv.TabIndex = 27;
			this.glcsv.Text = "Generate Launch CMD";
			this.glcsv.UseVisualStyleBackColor = true;
			this.glcsv.Click += new System.EventHandler(this.glcsv_Click);
			// 
			// jbutsv
			// 
			this.jbutsv.Location = new System.Drawing.Point(135, 251);
			this.jbutsv.Name = "jbutsv";
			this.jbutsv.Size = new System.Drawing.Size(75, 23);
			this.jbutsv.TabIndex = 26;
			this.jbutsv.Text = "Host";
			this.jbutsv.UseVisualStyleBackColor = true;
			this.jbutsv.Click += new System.EventHandler(this.jbutsv_Click);
			// 
			// flcmdsv
			// 
			this.flcmdsv.AutoSize = true;
			this.flcmdsv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.flcmdsv.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.flcmdsv.Location = new System.Drawing.Point(10, 191);
			this.flcmdsv.Name = "flcmdsv";
			this.flcmdsv.Size = new System.Drawing.Size(16, 13);
			this.flcmdsv.TabIndex = 25;
			this.flcmdsv.Text = "...";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label10.Location = new System.Drawing.Point(10, 178);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(136, 13);
			this.label10.TabIndex = 24;
			this.label10.Text = "The full launch command is";
			// 
			// argtxsv
			// 
			this.argtxsv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.argtxsv.Location = new System.Drawing.Point(13, 155);
			this.argtxsv.Name = "argtxsv";
			this.argtxsv.Size = new System.Drawing.Size(187, 20);
			this.argtxsv.TabIndex = 23;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.label11.Location = new System.Drawing.Point(10, 139);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(57, 13);
			this.label11.TabIndex = 22;
			this.label11.Text = "Arguments";
			// 
			// pttxsv
			// 
			this.pttxsv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.pttxsv.Location = new System.Drawing.Point(13, 112);
			this.pttxsv.Name = "pttxsv";
			this.pttxsv.Size = new System.Drawing.Size(187, 20);
			this.pttxsv.TabIndex = 21;
			this.pttxsv.Text = "53640";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.label12.Location = new System.Drawing.Point(10, 96);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(26, 13);
			this.label12.TabIndex = 20;
			this.label12.Text = "Port";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(92)))), ((int)(((byte)(28)))));
			this.label13.Location = new System.Drawing.Point(10, 63);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(188, 26);
			this.label13.TabIndex = 19;
			this.label13.Text = "This must NOT have quotations.\r\nPLEASE remove them if they are there";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.label14.Location = new System.Drawing.Point(10, 50);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(60, 13);
			this.label14.TabIndex = 18;
			this.label14.Text = "WARNING";
			// 
			// rbfltxsv
			// 
			this.rbfltxsv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.rbfltxsv.Location = new System.Drawing.Point(13, 25);
			this.rbfltxsv.Name = "rbfltxsv";
			this.rbfltxsv.Size = new System.Drawing.Size(187, 20);
			this.rbfltxsv.TabIndex = 17;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.label15.Location = new System.Drawing.Point(10, 9);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(39, 13);
			this.label15.TabIndex = 16;
			this.label15.Text = "rbxl file";
			// 
			// psstart
			// 
			this.psstart.Controls.Add(this.label19);
			this.psstart.Controls.Add(this.label23);
			this.psstart.Controls.Add(this.glcps);
			this.psstart.Controls.Add(this.jbutps);
			this.psstart.Controls.Add(this.label16);
			this.psstart.Controls.Add(this.label17);
			this.psstart.Controls.Add(this.argtxps);
			this.psstart.Controls.Add(this.label18);
			this.psstart.Controls.Add(this.label20);
			this.psstart.Controls.Add(this.label21);
			this.psstart.Controls.Add(this.rbfltxps);
			this.psstart.Controls.Add(this.label22);
			this.psstart.Cursor = System.Windows.Forms.Cursors.No;
			this.psstart.Location = new System.Drawing.Point(4, 22);
			this.psstart.Name = "psstart";
			this.psstart.Padding = new System.Windows.Forms.Padding(3);
			this.psstart.Size = new System.Drawing.Size(216, 280);
			this.psstart.TabIndex = 2;
			this.psstart.Text = "Play Solo";
			this.psstart.UseVisualStyleBackColor = true;
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(92)))), ((int)(((byte)(28)))));
			this.label19.Location = new System.Drawing.Point(10, 182);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(190, 52);
			this.label19.TabIndex = 41;
			this.label19.Text = "Press F5 once you\'re in to start.\r\nIt will drop you into the viewport. I can\'t\r\nc" +
    "hange this.\r\nThere\'s no auto-play arg sadly.";
			// 
			// label23
			// 
			this.label23.AutoSize = true;
			this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.label23.Location = new System.Drawing.Point(10, 169);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(60, 13);
			this.label23.TabIndex = 40;
			this.label23.Text = "WARNING";
			// 
			// glcps
			// 
			this.glcps.Location = new System.Drawing.Point(6, 251);
			this.glcps.Name = "glcps";
			this.glcps.Size = new System.Drawing.Size(126, 23);
			this.glcps.TabIndex = 39;
			this.glcps.Text = "Generate Launch CMD";
			this.glcps.UseVisualStyleBackColor = true;
			// 
			// jbutps
			// 
			this.jbutps.Location = new System.Drawing.Point(135, 251);
			this.jbutps.Name = "jbutps";
			this.jbutps.Size = new System.Drawing.Size(75, 23);
			this.jbutps.TabIndex = 38;
			this.jbutps.Text = "Play";
			this.jbutps.UseVisualStyleBackColor = true;
			this.jbutps.Click += new System.EventHandler(this.jbutps_Click);
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.label16.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label16.Location = new System.Drawing.Point(10, 150);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(16, 13);
			this.label16.TabIndex = 37;
			this.label16.Text = "...";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.label17.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label17.Location = new System.Drawing.Point(10, 137);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(136, 13);
			this.label17.TabIndex = 36;
			this.label17.Text = "The full launch command is";
			// 
			// argtxps
			// 
			this.argtxps.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.argtxps.Location = new System.Drawing.Point(13, 114);
			this.argtxps.Name = "argtxps";
			this.argtxps.Size = new System.Drawing.Size(187, 20);
			this.argtxps.TabIndex = 35;
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.label18.Location = new System.Drawing.Point(10, 98);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(57, 13);
			this.label18.TabIndex = 34;
			this.label18.Text = "Arguments";
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(92)))), ((int)(((byte)(28)))));
			this.label20.Location = new System.Drawing.Point(10, 63);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(188, 26);
			this.label20.TabIndex = 31;
			this.label20.Text = "This must NOT have quotations.\r\nPLEASE remove them if they are there";
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.label21.Location = new System.Drawing.Point(10, 50);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(60, 13);
			this.label21.TabIndex = 30;
			this.label21.Text = "WARNING";
			// 
			// rbfltxps
			// 
			this.rbfltxps.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.rbfltxps.Location = new System.Drawing.Point(13, 25);
			this.rbfltxps.Name = "rbfltxps";
			this.rbfltxps.Size = new System.Drawing.Size(187, 20);
			this.rbfltxps.TabIndex = 29;
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.label22.Location = new System.Drawing.Point(10, 9);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(39, 13);
			this.label22.TabIndex = 28;
			this.label22.Text = "rbxl file";
			// 
			// ccac
			// 
			this.ccac.Location = new System.Drawing.Point(163, 12);
			this.ccac.Name = "ccac";
			this.ccac.Size = new System.Drawing.Size(74, 22);
			this.ccac.TabIndex = 4;
			this.ccac.Text = "Clear Cache";
			this.ccac.UseVisualStyleBackColor = true;
			this.ccac.Click += new System.EventHandler(this.ccac_Click);
			// 
			// tstrbx
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(248, 377);
			this.Controls.Add(this.ccac);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "tstrbx";
			this.Text = "tstRBX";
			this.Load += new System.EventHandler(this.tstrbx_Load);
			this.tabControl1.ResumeLayout(false);
			this.clstart.ResumeLayout(false);
			this.clstart.PerformLayout();
			this.svstart.ResumeLayout(false);
			this.svstart.PerformLayout();
			this.psstart.ResumeLayout(false);
			this.psstart.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label label1;
		private Label label2;
		private TabControl tabControl1;
		private TabPage clstart;
		private TabPage svstart;
		private Label label3;
		private TextBox iptxcl;
		private Label label5;
		private Label label4;
		private TextBox argtxcl;
		private Label label7;
		private TextBox pttxcl;
		private Label label6;
		private Button jbut;
		private Label flcmd;
		private Label label8;
		private TabPage psstart;
		private Button glcbut;
		private Button glcsv;
		private Button jbutsv;
		private Label flcmdsv;
		private Label label10;
		private TextBox argtxsv;
		private Label label11;
		private TextBox pttxsv;
		private Label label12;
		private Label label13;
		private Label label14;
		private TextBox rbfltxsv;
		private Label label15;
		private Label label19;
		private Label label23;
		private Button glcps;
		private Button jbutps;
		private Label label16;
		private Label label17;
		private TextBox argtxps;
		private Label label18;
		private Label label20;
		private Label label21;
		private TextBox rbfltxps;
		private Label label22;
		private CheckBox mlmode;
		private Button ccac;
	}
}