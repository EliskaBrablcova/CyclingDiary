namespace App
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.CyclingDiaryTlp = new System.Windows.Forms.TableLayoutPanel();
			this.statisticsBtn = new System.Windows.Forms.Button();
			this.deleteBtn = new System.Windows.Forms.Button();
			this.editBtn = new System.Windows.Forms.Button();
			this.addNewBtn = new System.Windows.Forms.Button();
			this.cyclingDiaryLv = new System.Windows.Forms.ListView();
			this.versionLbl = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dateCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.minutesTotalCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.distanceTotalCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.averageSpeedCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.noteCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.logo2Pb = new System.Windows.Forms.PictureBox();
			this.logo1Pb = new System.Windows.Forms.PictureBox();
			this.CyclingDiaryTlp.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.logo2Pb)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.logo1Pb)).BeginInit();
			this.SuspendLayout();
			// 
			// CyclingDiaryTlp
			// 
			this.CyclingDiaryTlp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.CyclingDiaryTlp.ColumnCount = 2;
			this.CyclingDiaryTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
			this.CyclingDiaryTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.CyclingDiaryTlp.Controls.Add(this.statisticsBtn, 0, 4);
			this.CyclingDiaryTlp.Controls.Add(this.deleteBtn, 0, 3);
			this.CyclingDiaryTlp.Controls.Add(this.editBtn, 0, 2);
			this.CyclingDiaryTlp.Controls.Add(this.addNewBtn, 0, 1);
			this.CyclingDiaryTlp.Controls.Add(this.cyclingDiaryLv, 1, 1);
			this.CyclingDiaryTlp.Controls.Add(this.logo2Pb, 1, 0);
			this.CyclingDiaryTlp.Controls.Add(this.logo1Pb, 0, 0);
			this.CyclingDiaryTlp.Location = new System.Drawing.Point(12, 12);
			this.CyclingDiaryTlp.Name = "CyclingDiaryTlp";
			this.CyclingDiaryTlp.RowCount = 5;
			this.CyclingDiaryTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
			this.CyclingDiaryTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.CyclingDiaryTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.CyclingDiaryTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.CyclingDiaryTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.CyclingDiaryTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.CyclingDiaryTlp.Size = new System.Drawing.Size(570, 333);
			this.CyclingDiaryTlp.TabIndex = 0;
			// 
			// statisticsBtn
			// 
			this.statisticsBtn.Dock = System.Windows.Forms.DockStyle.Fill;
			this.statisticsBtn.Location = new System.Drawing.Point(3, 178);
			this.statisticsBtn.Name = "statisticsBtn";
			this.statisticsBtn.Size = new System.Drawing.Size(134, 19);
			this.statisticsBtn.TabIndex = 4;
			this.statisticsBtn.Text = "Statistics";
			this.statisticsBtn.UseVisualStyleBackColor = true;
			this.statisticsBtn.Click += new System.EventHandler(this.statisticsBtn_Click);
			// 
			// deleteBtn
			// 
			this.deleteBtn.Dock = System.Windows.Forms.DockStyle.Fill;
			this.deleteBtn.Location = new System.Drawing.Point(3, 153);
			this.deleteBtn.Name = "deleteBtn";
			this.deleteBtn.Size = new System.Drawing.Size(134, 19);
			this.deleteBtn.TabIndex = 3;
			this.deleteBtn.Text = "Delete";
			this.deleteBtn.UseVisualStyleBackColor = true;
			this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
			// 
			// editBtn
			// 
			this.editBtn.Dock = System.Windows.Forms.DockStyle.Fill;
			this.editBtn.Location = new System.Drawing.Point(3, 128);
			this.editBtn.Name = "editBtn";
			this.editBtn.Size = new System.Drawing.Size(134, 19);
			this.editBtn.TabIndex = 2;
			this.editBtn.Text = "Edit";
			this.editBtn.UseVisualStyleBackColor = true;
			this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
			// 
			// addNewBtn
			// 
			this.addNewBtn.Dock = System.Windows.Forms.DockStyle.Fill;
			this.addNewBtn.Location = new System.Drawing.Point(3, 103);
			this.addNewBtn.Name = "addNewBtn";
			this.addNewBtn.Size = new System.Drawing.Size(134, 19);
			this.addNewBtn.TabIndex = 1;
			this.addNewBtn.Text = "Add New";
			this.addNewBtn.UseVisualStyleBackColor = true;
			this.addNewBtn.Click += new System.EventHandler(this.addNewBtn_Click);
			// 
			// cyclingDiaryLv
			// 
			this.cyclingDiaryLv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cyclingDiaryLv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.dateCh,
            this.minutesTotalCh,
            this.distanceTotalCh,
            this.averageSpeedCh,
            this.noteCh});
			this.cyclingDiaryLv.HideSelection = false;
			this.cyclingDiaryLv.Location = new System.Drawing.Point(143, 103);
			this.cyclingDiaryLv.Name = "cyclingDiaryLv";
			this.CyclingDiaryTlp.SetRowSpan(this.cyclingDiaryLv, 5);
			this.cyclingDiaryLv.Size = new System.Drawing.Size(424, 227);
			this.cyclingDiaryLv.TabIndex = 5;
			this.cyclingDiaryLv.UseCompatibleStateImageBehavior = false;
			this.cyclingDiaryLv.View = System.Windows.Forms.View.Details;
			// 
			// versionLbl
			// 
			this.versionLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.versionLbl.AutoSize = true;
			this.versionLbl.Location = new System.Drawing.Point(554, 583);
			this.versionLbl.Name = "versionLbl";
			this.versionLbl.Size = new System.Drawing.Size(28, 13);
			this.versionLbl.TabIndex = 4;
			this.versionLbl.Text = "v0.1";
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(554, 348);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(28, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "v0.1";
			// 
			// dateCh
			// 
			this.dateCh.Text = "Date";
			this.dateCh.Width = 78;
			// 
			// minutesTotalCh
			// 
			this.minutesTotalCh.Text = "Minutes Total";
			this.minutesTotalCh.Width = 76;
			// 
			// distanceTotalCh
			// 
			this.distanceTotalCh.Text = "Distance Total";
			this.distanceTotalCh.Width = 83;
			// 
			// averageSpeedCh
			// 
			this.averageSpeedCh.Text = "Avg. Speed";
			this.averageSpeedCh.Width = 71;
			// 
			// noteCh
			// 
			this.noteCh.Text = "Note";
			this.noteCh.Width = 89;
			// 
			// logo2Pb
			// 
			this.logo2Pb.Dock = System.Windows.Forms.DockStyle.Fill;
			this.logo2Pb.Image = ((System.Drawing.Image)(resources.GetObject("logo2Pb.Image")));
			this.logo2Pb.Location = new System.Drawing.Point(143, 3);
			this.logo2Pb.Name = "logo2Pb";
			this.logo2Pb.Size = new System.Drawing.Size(424, 94);
			this.logo2Pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.logo2Pb.TabIndex = 6;
			this.logo2Pb.TabStop = false;
			// 
			// logo1Pb
			// 
			this.logo1Pb.Dock = System.Windows.Forms.DockStyle.Fill;
			this.logo1Pb.Image = ((System.Drawing.Image)(resources.GetObject("logo1Pb.Image")));
			this.logo1Pb.Location = new System.Drawing.Point(3, 3);
			this.logo1Pb.Name = "logo1Pb";
			this.logo1Pb.Size = new System.Drawing.Size(134, 94);
			this.logo1Pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.logo1Pb.TabIndex = 7;
			this.logo1Pb.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(594, 368);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.versionLbl);
			this.Controls.Add(this.CyclingDiaryTlp);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximumSize = new System.Drawing.Size(610, 1000);
			this.MinimumSize = new System.Drawing.Size(610, 276);
			this.Name = "MainForm";
			this.Text = "Cycling Diary";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.CyclingDiaryTlp.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.logo2Pb)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.logo1Pb)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel CyclingDiaryTlp;
		private System.Windows.Forms.Button addNewBtn;
		private System.Windows.Forms.Button statisticsBtn;
		private System.Windows.Forms.Button deleteBtn;
		private System.Windows.Forms.Button editBtn;
		private System.Windows.Forms.ListView cyclingDiaryLv;
		private System.Windows.Forms.Label versionLbl;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ColumnHeader dateCh;
		private System.Windows.Forms.ColumnHeader minutesTotalCh;
		private System.Windows.Forms.ColumnHeader distanceTotalCh;
		private System.Windows.Forms.ColumnHeader averageSpeedCh;
		private System.Windows.Forms.ColumnHeader noteCh;
		private System.Windows.Forms.PictureBox logo2Pb;
		private System.Windows.Forms.PictureBox logo1Pb;
	}
}

