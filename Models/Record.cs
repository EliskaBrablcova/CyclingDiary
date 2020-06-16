using System;
using System.Collections.Generic;
using System.Text;

namespace Eli.CyclingDiary.Models
{
	public class Record
	{
		public int ID { get; set; }
		public DateTime Date { get; set; }
		public int MinutesTotal { get; set; }
		public int DistanceTotal { get; set; }
		public string Note { get; set; }
	}
}
