using System.ComponentModel;

namespace web.Models
{
    public enum DisplayType
    {
		[Description("16:9")]
		Landscape = 1,
		[Description("9:16")]
		Portrait = 2
    }
}
