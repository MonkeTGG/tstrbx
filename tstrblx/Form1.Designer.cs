namespace tstrblx
{
    partial class tslaunch
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
			this.lbut = new System.Windows.Forms.Button();
			this.rbstloc = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.hbut = new System.Windows.Forms.Button();
			this.rbstvr = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(73, 30);
			this.label1.TabIndex = 0;
			this.label1.Text = "tstRBX";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.label2.Location = new System.Drawing.Point(15, 43);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(159, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "the shittiest launcher to ever live";
			// 
			// lbut
			// 
			this.lbut.Location = new System.Drawing.Point(304, 128);
			this.lbut.Name = "lbut";
			this.lbut.Size = new System.Drawing.Size(75, 23);
			this.lbut.TabIndex = 2;
			this.lbut.Text = "Launch";
			this.lbut.UseVisualStyleBackColor = true;
			this.lbut.Click += new System.EventHandler(this.lbut_Click);
			// 
			// rbstloc
			// 
			this.rbstloc.Location = new System.Drawing.Point(18, 78);
			this.rbstloc.Name = "rbstloc";
			this.rbstloc.Size = new System.Drawing.Size(357, 20);
			this.rbstloc.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(15, 62);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(117, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "ROBLOX Studio Location";
			// 
			// hbut
			// 
			this.hbut.Location = new System.Drawing.Point(223, 128);
			this.hbut.Name = "hbut";
			this.hbut.Size = new System.Drawing.Size(75, 23);
			this.hbut.TabIndex = 5;
			this.hbut.Text = "Help";
			this.hbut.UseVisualStyleBackColor = true;
			this.hbut.Click += new System.EventHandler(this.hbut_Click);
			// 
			// rbstvr
			// 
			this.rbstvr.FormattingEnabled = true;
			this.rbstvr.Items.AddRange(new object[] {
            "Modern (2019+)",
            "Old (<2019)"});
			this.rbstvr.Location = new System.Drawing.Point(103, 130);
			this.rbstvr.Name = "rbstvr";
			this.rbstvr.Size = new System.Drawing.Size(114, 21);
			this.rbstvr.TabIndex = 6;
			this.rbstvr.Text = "Modern (2019+)";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(15, 133);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(82, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "ROBLOX Version";
			// 
			// panel1
			// 
			this.panel1.Location = new System.Drawing.Point(248, 33);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(24, 10);
			this.panel1.TabIndex = 8;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// tslaunch
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(391, 163);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.rbstvr);
			this.Controls.Add(this.hbut);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.rbstloc);
			this.Controls.Add(this.lbut);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "tslaunch";
			this.ShowIcon = false;
			this.Text = "tstRBX Launcher";
			this.Load += new System.EventHandler(this.tslaunch_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button lbut;
        private System.Windows.Forms.TextBox rbstloc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button hbut;
		private System.Windows.Forms.ComboBox rbstvr;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel panel1;
	}
}

