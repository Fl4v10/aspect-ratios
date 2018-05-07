using tests;
using web.Models;
using web.Repository;
using Web.Models;
using Xunit;

namespace Tests
{
    public class AdvertiseTest : AdvertiseTestBase
	{
        [Fact]
        public void GetAllDisplaysTest()
        {
			var advertise = new AdvertiseRepositoryImpl(inMemoryContext);
			var result = advertise.GetDisplay(null);

			Assert.Equal(5, result.Count);
        }

		[Fact]
		public void Get1980x1080DisplaysTest()
		{
			var advertise = new AdvertiseRepositoryImpl(inMemoryContext);
			var result = advertise.GetDisplay((int)DisplayType.Landscape);

			Assert.Equal(3, result.Count);
		}

		[Fact]
		public void Get1080x1980DisplaysTest()
		{
			var advertise = new AdvertiseRepositoryImpl(inMemoryContext);
			var result = advertise.GetDisplay((int)DisplayType.Portrait);

			Assert.Equal(2, result.Count);
		}
    }
}
