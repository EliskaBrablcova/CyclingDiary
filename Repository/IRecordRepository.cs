using Eli.CyclingDiary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Eli.CyclingDiary.Repository
{
	public interface IRecordRepository
	{
		void Add(Record record);
		void Edit(Record record);
		void Delete(int id);
		List<RecordVM> GetAll();
		Record GetForAdd();
		Record GetForEdit(int id);
	}
}
