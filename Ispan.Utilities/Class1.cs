using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispan.Utilities
{
	public class TaiwainStockUtility
	{
		public bool IsTradingTime(DateTime dt)
		{
			var day = dt.DayOfWeek;
			bool istradeday = false;
			if (day == DayOfWeek.Monday || day == DayOfWeek.Tuesday || day == DayOfWeek.Wednesday || day == DayOfWeek.Thursday || day == DayOfWeek.Friday)
			{
				if (dt.Hour >= 9 && dt.Hour <= 13)
					istradeday = true;
			}

			return istradeday;
		}
	}
}
