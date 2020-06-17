namespace Eli.CyclingDiary.App
{
	partial class RecordDialog
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecordDialog));
			this.recordDialogTlp = new System.Windows.Forms.TableLayoutPanel();
			this.dateLbl = new System.Windows.Forms.Label();
			this.minutesTotalLbl = new System.Windows.Forms.Label();
			this.distanceTotalLbl = new System.Windows.Forms.Label();
			this.recordDialogCancelBtn = new System.Windows.Forms.Button();
			this.recordDialogSaveBtn = new System.Windows.Forms.Button();
			this.noteLbl = new System.Windows.Forms.Label();
			this.dateDtp = new System.Windows.Forms.DateTimePicker();
			this.minutesTotalNud = new System.Windows.Forms.NumericUpDown();
			this.distanceTotalNud = new System.Windows.Forms.NumericUpDown();
			this.noteTB = new System.Windows.Forms.TextBox();
			this.recordDialogTlp.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.minutesTotalNud)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.distanceTotalNud)).BeginInit();
			this.SuspendLayout();
			// 
			// recordDialogTlp
			// 
			this.recordDialogTlp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.recordDialogTlp.ColumnCount = 2;
			this.recordDialogTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
			this.recordDialogTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.recordDialogTlp.Controls.Add(this.noteTB, 1, 3);
			this.recordDialogTlp.Controls.Add(this.distanceTotalNud, 1, 2);
			this.recordDialogTlp.Controls.Add(this.minutesTotalNud, 1, 1);
			this.recordDialogTlp.Controls.Add(this.noteLbl, 0, 3);
			this.recordDialogTlp.Controls.Add(this.dateLbl, 0, 0);
			this.recordDialogTlp.Controls.Add(this.minutesTotalLbl, 0, 1);
			this.recordDialogTlp.Controls.Add(this.distanceTotalLbl, 0, 2);
			this.recordDialogTlp.Controls.Add(this.dateDtp, 1, 0);
			this.recordDialogTlp.Location = new System.Drawing.Point(12, 12);
			this.recordDialogTlp.Name = "recordDialogTlp";
			this.recordDialogTlp.RowCount = 4;
			this.recordDialogTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.recordDialogTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.recordDialogTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.recordDialogTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.recordDialogTlp.Size = new System.Drawing.Size(350, 148);
			this.recordDialogTlp.TabIndex = 2;
			// 
			// dateLbl
			// 
			this.dateLbl.AutoSize = true;
			this.dateLbl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dateLbl.Location = new System.Drawing.Point(3, 0);
			this.dateLbl.Name = "dateLbl";
			this.dateLbl.Size = new System.Drawing.Size(104, 25);
			this.dateLbl.TabIndex = 0;
			this.dateLbl.Text = "Date";
			this.dateLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// minutesTotalLbl
			// 
			this.minutesTotalLbl.AutoSize = true;
			this.minutesTotalLbl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.minutesTotalLbl.Location = new System.Drawing.Point(3, 25);
			this.minutesTotalLbl.Name = "minutesTotalLbl";
			this.minutesTotalLbl.Size = new System.Drawing.Size(104, 25);
			this.minutesTotalLbl.TabIndex = 1;
			this.minutesTotalLbl.Text = "Minutes Total";
			this.minutesTotalLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// distanceTotalLbl
			// 
			this.distanceTotalLbl.AutoSize = true;
			this.distanceTotalLbl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.distanceTotalLbl.Location = new System.Drawing.Point(3, 50);
			this.distanceTotalLbl.Name = "distanceTotalLbl";
			this.distanceTotalLbl.Size = new System.Drawing.Size(104, 25);
			this.distanceTotalLbl.TabIndex = 2;
			this.distanceTotalLbl.Text = "Distance Total (km)";
			this.distanceTotalLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// recordDialogCancelBtn
			// 
			this.recordDialogCancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.recordDialogCancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.recordDialogCancelBtn.Location = new System.Drawing.Point(206, 169);
			this.recordDialogCancelBtn.MinimumSize = new System.Drawing.Size(75, 23);
			this.recordDialogCancelBtn.Name = "recordDialogCancelBtn";
			this.recordDialogCancelBtn.Size = new System.Drawing.Size(75, 23);
			this.recordDialogCancelBtn.TabIndex = 4;
			this.recordDialogCancelBtn.Text = "Cancel";
			this.recordDialogCancelBtn.UseVisualStyleBackColor = true;
			// 
			// recordDialogSaveBtn
			// 
			this.recordDialogSaveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.recordDialogSaveBtn.Location = new System.Drawing.Point(287, 169);
			this.recordDialogSaveBtn.Name = "recordDialogSaveBtn";
			this.recordDialogSaveBtn.Size = new System.Drawing.Size(75, 23);
			this.recordDialogSaveBtn.TabIndex = 5;
			this.recordDialogSaveBtn.Text = "Save";
			this.recordDialogSaveBtn.UseVisualStyleBackColor = true;
			this.recordDialogSaveBtn.Click += new System.EventHandler(this.recordDialogSaveBtn_Click);
			// 
			// noteLbl
			// 
			this.noteLbl.AutoSize = true;
			this.noteLbl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.noteLbl.Location = new System.Drawing.Point(3, 75);
			this.noteLbl.Name = "noteLbl";
			this.noteLbl.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
			this.noteLbl.Size = new System.Drawing.Size(104, 73);
			this.noteLbl.TabIndex = 6;
			this.noteLbl.Text = "Note";
			// 
			// dateDtp
			// 
			this.dateDtp.CustomFormat = "";
			this.dateDtp.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dateDtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateDtp.Location = new System.Drawing.Point(113, 3);
			this.dateDtp.Name = "dateDtp";
			this.dateDtp.Size = new System.Drawing.Size(234, 20);
			this.dateDtp.TabIndex = 8;
			// 
			// minutesTotalNud
			// 
			this.minutesTotalNud.Dock = System.Windows.Forms.DockStyle.Fill;
			this.minutesTotalNud.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.minutesTotalNud.Location = new System.Drawing.Point(113, 28);
			this.minutesTotalNud.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.minutesTotalNud.Name = "minutesTotalNud";
			this.minutesTotalNud.Size = new System.Drawing.Size(234, 20);
			this.minutesTotalNud.TabIndex = 9;
			// 
			// distanceTotalNud
			// 
			this.distanceTotalNud.DecimalPlaces = 2;
			this.distanceTotalNud.Dock = System.Windows.Forms.DockStyle.Fill;
			this.distanceTotalNud.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.distanceTotalNud.Location = new System.Drawing.Point(113, 53);
			this.distanceTotalNud.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.distanceTotalNud.Name = "distanceTotalNud";
			this.distanceTotalNud.Size = new System.Drawing.Size(234, 20);
			this.distanceTotalNud.TabIndex = 10;
			// 
			// noteTB
			// 
			this.noteTB.Dock = System.Windows.Forms.DockStyle.Fill;
			this.noteTB.Location = new System.Drawing.Point(113, 78);
			this.noteTB.Multiline = true;
			this.noteTB.Name = "noteTB";
			this.noteTB.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
			this.noteTB.Size = new System.Drawing.Size(234, 67);
			this.noteTB.TabIndex = 11;
			// 
			// RecordDialog
			// 
			this.AcceptButton = this.recordDialogSaveBtn;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.recordDialogCancelBtn;
			this.ClientSize = new System.Drawing.Size(374, 198);
			this.ControlBox = false;
			this.Controls.Add(this.recordDialogSaveBtn);
			this.Controls.Add(this.recordDialogCancelBtn);
			this.Controls.Add(this.recordDialogTlp);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(390, 189);
			this.Name = "RecordDialog";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "RecordDialog";
			this.Load += new System.EventHandler(this.RecordDialog_Load);
			this.recordDialogTlp.ResumeLayout(false);
			this.recordDialogTlp.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.minutesTotalNud)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.distanceTotalNud)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel recordDialogTlp;
		private System.Windows.Forms.Label dateLbl;
		private System.Windows.Forms.Label minutesTotalLbl;
		private System.Windows.Forms.Label distanceTotalLbl;
		private System.Windows.Forms.Button recordDialogCancelBtn;
		private System.Windows.Forms.Button recordDialogSaveBtn;
		private System.Windows.Forms.Label noteLbl;
		private System.Windows.Forms.DateTimePicker dateDtp;
		private System.Windows.Forms.NumericUpDown minutesTotalNud;
		private System.Windows.Forms.NumericUpDown distanceTotalNud;
		private System.Windows.Forms.TextBox noteTB;
	}
}