using tests;
using web.Models;
using web.Repository;
using Xunit;

namespace Tests
{
    public class AdvertiseTest : AdvertiseTestBase
	{
        [Fact]
        public void GetAllDisplaysTest()
        {
			//Arrange
	        new AdvertiseTestBase();
	        var advertise = new AdvertiseRepositoryImpl(Context);

			//Action
			var result = advertise.GetDisplay(null);

			//Assert
			Assert.Equal(5, result.Count);
        }

		[Fact]
		public void Get1980X1080DisplaysTest()
		{
			//Arrange
			new AdvertiseTestBase();
			var advertise = new AdvertiseRepositoryImpl(Context);

			//Action
			var result = advertise.GetDisplay((int)DisplayType.Landscape);

			//Assert
			Assert.Equal(3, result.Count);
		}

		[Fact]
		public void Get1080X1980DisplaysTest()
		{
			//Arrange
			new AdvertiseTestBase();
			var advertise = new AdvertiseRepositoryImpl(Context);

			//Action
			var result = advertise.GetDisplay((int)DisplayType.Portrait);

			//Assert
			Assert.Equal(2, result.Count);
		}
	}
}
