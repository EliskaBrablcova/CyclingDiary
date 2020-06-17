using Eli.ColoringDiary.FormsLibrary;
using Eli.CyclingDiary.App;
using Eli.CyclingDiary.Models;
using Eli.CyclingDiary.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
	public partial class MainForm : Form
	{
		private IRecordRepository _recordRepo;
		private IList<int> _recordIds;

		public MainForm()
		{
			InitializeComponent();
			_recordRepo = new RecordFileRepository("data\\records.json");

		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			reloadAll();
		}

		private void reloadAll()
		{
			var records = _recordRepo.GetAll();
			saveIds(records);
			display(records);
			setButtonStates();
		}

		private void saveIds(List<RecordVM> records)
		{
			var ids = new List<int>();
			foreach (var record in records)
			{
				ids.Add(record.ID);
			}
			_recordIds = ids;
		}

		private void display(List<RecordVM> records)
		{
			cyclingDiaryLv.Items.Clear();
			foreach (var record in records)
			{
				addRow(record);
			}
		}

		private void addRow(RecordVM record)
		{
			var texts = new[]
			{
				record.Date.ToShortDateString(),
				record.MinutesTotal.ToString(),
				record.DistanceTotal.ToString(),
				record.AverageSpeed.ToString("0.##"),
				record.Note,

			};
			var viewItem = new ListViewItem(texts);
			cyclingDiaryLv.Items.Add(viewItem);
		}

		private void setButtonStates()
		{
			var selected = cyclingDiaryLv.SelectedIndices;
			if (selected.Count == 1)
			{
				setButtonStates(true);
			}
			else
			{
				setButtonStates(false);
			}
		}

		private void setButtonStates(bool enabled)
		{
			deleteBtn.Enabled = enabled;
			editBtn.Enabled = enabled;
		}

		private void addNewBtn_Click(object sender, EventArgs e)
		{
			var item = _recordRepo.GetForAdd();
			var dialog = new RecordDialog(item, false);
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				_recordRepo.Add(dialog.Item);
				reloadAll();
			}
		}

		private void editBtn_Click(object sender, EventArgs e)
		{
			var selected = cyclingDiaryLv.SelectedIndices;
			if (selected.Count == 1)
			{
				var selectedIndex = selected[0];
				var item = _recordRepo.GetForEdit(_recordIds[selectedIndex]);
				if (item == null)
				{
					return;
				}
				var dialog = new RecordDialog(item, true);
				var result = dialog.ShowDialog();
				if (result == DialogResult.OK)
				{
					_recordRepo.Edit(dialog.Item);
					reloadAll();
				}
			}
		}

		private void deleteBtn_Click(object sender, EventArgs e)
		{
			var selected = cyclingDiaryLv.SelectedIndices;
			if (selected.Count == 1)
			{
				var selectedIndex = selected[0];
				var item = _recordRepo.GetForEdit(_recordIds[selectedIndex]);
				if (item == null)
				{
					return;
				}
				var dialog = new CustomMessageBox("Warning", "Do you really want to delete this record?");
				var result = dialog.ShowDialog();
				if (result == DialogResult.OK)
				{
					_recordRepo.Delete(_recordIds[selectedIndex]);
					reloadAll();
				}
			}
		}

		private void statisticsBtn_Click(object sender, EventArgs e)
		{

		}
	}
}
