using Eli.CyclingDiary.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Eli.CyclingDiary.Repository
{
	public class RecordFileRepository : IRecordRepository
	{
		private string _fileName;

		public RecordFileRepository(string fileName)
		{
			if (fileName == null)
			{
				throw new ArgumentNullException(nameof(fileName));
			}
			_fileName = fileName;
		}

		public void Add(Record record)
		{
			if (record == null)
			{
				throw new ArgumentNullException(nameof(record));
			}
			var items = readFromFile();
			record.ID = getNewId(items);
			items.Add(record);
			saveToFile(items);
		}

		public void Delete(int id)
		{
			var items = readFromFile();
			var position = getPositionById(items, id);
			if (position != null)
			{
				items.RemoveAt(position.Value);
				saveToFile(items);
			}
		}


		public void Edit(Record record)
		{
			var items = readFromFile();
			var item = getItemById(items, record.ID);
			if (item != null)
			{
				item.Date = record.Date;
				item.MinutesTotal = record.MinutesTotal;
				item.DistanceTotal = record.DistanceTotal;
				item.Note = record.Note;
				saveToFile(items);
			}
		}


		public List<RecordVM> GetAll()
		{
			var items = readFromFileOrdered();
			var result = new List<RecordVM>();
			foreach (var item in items)
			{
				var record = new RecordVM
				{
					ID = item.ID,
					Date = item.Date,
					MinutesTotal = item.MinutesTotal,
					DistanceTotal = item.DistanceTotal,
					AverageSpeed = item.MinutesTotal > 0
						? (item.DistanceTotal / item.MinutesTotal * 60)
						: 0,
					Note = item.Note,
				};
				result.Add(record);
			}
			return result;
		}

		public Record GetForAdd()
		{
			return new Record();
		}

		public Record GetForEdit(int id)
		{
			var items = readFromFile();
			return getItemById(items, id);
		}
		private int? getPositionById(List<Record> items, int id)
		{
			for (int i = 0; i < items.Count; i++)
			{
				var item = items[i];
				if (item.ID == id)
				{
					return i;
				}
			}
			return null;
		}
		private Record getItemById(List<Record> items, int id)
		{
			var position = getPositionById(items, id);
			if (position == null)
			{
				return null;
			}
			return items[position.Value];
		}

		private int getNewId(List<Record> items)
		{
			var id = 0;
			foreach (var item in items)
			{
				if (item.ID > id)
				{
					id = item.ID;
				}
			}
			return id + 1;
		}

		private void saveToFile(List<Record> items)
		{
			using (var sw = new StreamWriter(_fileName))
			{
				sw.Write(JsonConvert.SerializeObject(items));
			}
		}


		private List<Record> readFromFile()
		{
			using (var sr = new StreamReader(_fileName))
			{
				return JsonConvert.DeserializeObject<List<Record>>(sr.ReadToEnd());
			}
		}

		private List<Record> readFromFileOrdered()
		{
			var items = readFromFile();
			return items.OrderBy(c => c.Date).ThenBy(c => c.ID).ToList();
		}
	}
}
