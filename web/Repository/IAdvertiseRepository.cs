using System.Collections.Generic;
using Web.Models;

namespace web.Repository
{
    public interface IAdvertiseRepository
    {
		List<Display> GetDisplay(int? sizeId, int? aspectRatio);
    }
}
