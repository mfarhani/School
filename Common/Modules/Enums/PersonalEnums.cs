using System.ComponentModel;
namespace Common.Modules.Enums
{
	public enum DegreeOfEducation
	{
		[Description("زیر دیپلم")]
		UnderDiploma=1,
		[Description("دیپلم")]
		Diploma=2,
		[Description("فوق دیپلم")]
		AssociateDegree=3,
		[Description("لیسانس")]
		Bachelor=4,
		[Description("فوق لیسانس")]
		MA=5,
		[Description("دکتری")]
		PHD=6
	}
}
