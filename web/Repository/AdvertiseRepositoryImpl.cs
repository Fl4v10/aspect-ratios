using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Web.Models;
using Web.Repository;

namespace web.Repository
{
	public class AdvertiseRepositoryImpl : IAdvertiseRepository
	{
		private Context _context;

		public AdvertiseRepositoryImpl(Context context)
		{
			_context = context;
		}

		public List<Display> GetDisplay(int? sizeId, int? displayTypePriceId)
		{
			var display = _context.Displays
				.Include("DisplaySize")
				.Include("Prices")
				.AsQueryable().AsNoTracking();

			if (sizeId.HasValue)
				display = display.Where(p => sizeId.Value == p.DisplaySize.Id);

			if (displayTypePriceId.HasValue)
				display = display.Where(p => p.Prices.Any(m => m.Id.Equals(displayTypePriceId.Value)));

			return display.ToList();
		}
	}
}
