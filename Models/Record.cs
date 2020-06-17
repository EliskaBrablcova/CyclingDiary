using System;
using System.Collections.Generic;
using System.Text;

namespace Eli.CyclingDiary.Models
{
	public class Record
	{
		public Record()
		{
			Date = DateTime.Today;
		}
		public int ID { get; set; }
		public DateTime Date { get; set; }
		public int MinutesTotal { get; set; }
		public decimal DistanceTotal { get; set; }
		public string Note { get; set; }
	}
}
