using Eli.CyclingDiary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eli.CyclingDiary.App
{
	public partial class RecordDialog : Form
	{
		public Record Item { get; }
		public RecordDialog(Record item, bool isEdit)
		{
			InitializeComponent();
			if (item == null)
			{
				throw new NullReferenceException(nameof(item));
			}
			Item = item;
			if (isEdit)
			{
				Text = "Record Editation";
			}
			else
			{
				Text = "New Record";
			}
		}
		
		private void setControls()
		{
			dateDtp.Value = Item.Date;
			minutesTotalNud.Value = Item.MinutesTotal;
			distanceTotalNud.Value = Item.DistanceTotal;
			noteTB.Text = Item.Note;
		}

		private void setItem()
		{
			Item.Date = dateDtp.Value;
			Item.MinutesTotal = (int)minutesTotalNud.Value;
			Item.DistanceTotal = distanceTotalNud.Value;
			Item.Note = noteTB.Text;
		}

		private void RecordDialog_Load(object sender, EventArgs e)
		{
			setControls();
		}

		private void recordDialogSaveBtn_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
			setItem();
			Close();
		}
	}
}
