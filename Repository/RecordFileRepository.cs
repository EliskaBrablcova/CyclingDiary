using Eli.CyclingDiary.Models;
using System;
using System.Collections.Generic;
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
			throw new NotImplementedException();
		}

		public Record GetForAdd()
		{
			throw new NotImplementedException();
		}

		public Record GetForEdit(int id)
		{
			throw new NotImplementedException();
		}
		private object getPositionById(object items, int id)
		{
			throw new NotImplementedException();
		}
		private object getItemById(object items, int iD)
		{
			throw new NotImplementedException();
		}

		private void saveToFile(object items)
		{
			throw new NotImplementedException();
		}

		private int getNewId(object items)
		{
			throw new NotImplementedException();
		}

		private object readFromFile()
		{
			throw new NotImplementedException();
		}

	}
}
