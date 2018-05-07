using Microsoft.EntityFrameworkCore;
using System;
using Web.Repository;

namespace tests
{
    public class AdvertiseTestBase : IDisposable
	{
		protected readonly Context inMemoryContext;

		public AdvertiseTestBase()
		{
			var options = new DbContextOptionsBuilder<Context>()
				.UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString()).Options;

			inMemoryContext = new Context(options);
			inMemoryContext.Database.EnsureCreated();
			inMemoryContext.SeedData().Wait();
		}

		public void Dispose()
		{
			inMemoryContext.Database.EnsureDeleted();
			inMemoryContext.Dispose();
		}
	}
}
