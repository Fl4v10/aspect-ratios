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
			var advertise = new AdvertiseRepositoryImpl(Context);

			//Action
			var result = advertise.GetDisplay(null);

			//Assert
			Assert.Equal(5, result.Count);
		}

		[Fact]
		public void GetDisplaysTest()
		{
			//Arrange
			var advertise = new AdvertiseRepositoryImpl(Context);

			//Action
			var landscapeResult = advertise.GetDisplay((int) DisplayType.Landscape);
			var portraitResult = advertise.GetDisplay((int) DisplayType.Portrait);

			//Assert
			Assert.Equal(3, landscapeResult.Count);
			Assert.Equal(2, portraitResult.Count);
		}
	}
}
