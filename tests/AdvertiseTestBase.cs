using Microsoft.EntityFrameworkCore;
using System;
using Web.Repository;

namespace tests
{
    public class AdvertiseTestBase : IDisposable
	{
		protected readonly Context Context;

		public AdvertiseTestBase()
		{
			var options = new DbContextOptionsBuilder<Context>()
				.UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;

			Context = new Context(options);
			Context.Database.EnsureCreated();
			Context.SeedData().Wait();
		}

		public void Dispose()
		{
			Context.Database.EnsureDeleted();
			Context.Dispose();
		}
	}
}
